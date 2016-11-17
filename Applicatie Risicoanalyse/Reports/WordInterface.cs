using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Drawing;

using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Reports
{
    class WordInterface
    {
        private object missing = Type.Missing;
        private object paramFalse = false;
        public Microsoft.Office.Interop.Word.Application app = null;

        public WordInterface()
        {
            // Start an instance of Word.
            this.app = new Microsoft.Office.Interop.Word.Application();
        }

        /// <summary>
        /// Function to fill a table with riskReducingMeasures from the database.
        /// </summary>
        /// <param name="document">Document instance where the table can be found.</param>
        /// <param name="table">Table instance of the table to add values to.</param>
        /// <param name="dataRows">A DataView representing the data to be inserted into the table.</param>
        /// <param name="displayColumn">A Column name in the DataView representing which column to display in the table.</param>
        /// <param name="checkBoxSelectionColumn">A Column name in the DataView representing a column to check for for adding checkboxes in the table.</param>
        public void fillTableWithRiskReducingMeasures(Document document, Microsoft.Office.Interop.Word.Table table, DataView dataRows, string displayColumn, string checkBoxSelectionColumn = "")
        {
            if (table != null)
            {
                try
                {
                    for (int i = 0; i < dataRows.Count; i++)
                    {
                        //Add row if we are at the end of the table.
                        if (i % table.Columns.Count == 0)
                        {
                            table.Rows.Add(missing);
                        }

                        //Get cell so we can add stuff to it.
                        Range cell = table.Cell(table.Rows.Count - 1, (i % table.Columns.Count) + 1).Range;
                        cell.Text = dataRows[i][displayColumn].ToString();
                        cell.Select();

                        //If we have a column to add a checkbox, add a checkbox.
                        if (checkBoxSelectionColumn != "")
                        {
                            if (dataRows[i][checkBoxSelectionColumn].ToString() == "1")
                            {
                                cell.Collapse(ref missing);
                                FormField checkBox = cell.FormFields.Add(cell, WdFieldType.wdFieldFormCheckBox);
                                checkBox.CheckBox.Value = true;
                                checkBox = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        /// <summary>
        /// Search and replace all occurences of a string in a active document.
        /// </summary>
        /// <param name="app">Word application instance.</param>
        /// <param name="find">String to search for.</param>
        /// <param name="replaceWith">String to replace the searched value with.</param>
        /// <param name="textColor">A color to give to the replaced text.</param>
        public void searchAndReplace(Microsoft.Office.Interop.Word.Application app, string find, string replaceWith, Color textColor = new Color())
        {
            Microsoft.Office.Interop.Word.Find findObject = app.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = find;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replaceWith;

            if (textColor != new Color())
            {
                findObject.Replacement.Font.Color = (Microsoft.Office.Interop.Word.WdColor)(textColor.R + 0x100 * textColor.G + 0x10000 * textColor.B);
            }

            object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }

        /// <summary>
        /// Saves a document at a specific file location.
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="location">String representing a filepath where to save the document.</param>
        public void saveDocument(Document doc, string location)
        {
            object saveLocation = @location;

            //Save the document at a location.
            doc.SaveAs2(saveLocation);
        }

        /// <summary>
        /// Copies the content(no headers/footers) of a document to another document.
        /// </summary>
        /// <param name="documentToCopy">Doucment instance to copy its contents of.</param>
        /// <param name="documentToPasteIn">Document to paste the contents of the other document in.</param>
        /// <param name="addPageBreak">A bool that indicates if a pagebreak has to be inserted at the end of document.</param>
        public void copyDocumentToOtherDocument(Document documentToCopy, Document documentToPasteIn, bool addPageBreak = false)
        {
            //Select ranges.
            documentToPasteIn.Activate();
            object docStart = documentToPasteIn.Content.End - 1;
            object docEnd = documentToPasteIn.Content.End;

            object start = documentToCopy.Content.Start;
            object end = documentToCopy.Content.End;

            //Select document and copy it.
            documentToCopy.Range(ref start, ref end).Copy();
            Range documentRange = documentToPasteIn.Range(ref docStart, ref docEnd);
            documentRange.Paste();

            //Insert pagebreak
            if (addPageBreak)
            {
                documentToPasteIn.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
            }
        }

        /// <summary>
        /// Searches a document for a table with a specific Title.
        /// </summary>
        /// <param name="doc">Document instance to find the table in.</param>
        /// <param name="titleToFind">String representing the title to find in the document.</param>
        /// <returns>Microsoft.Office.Interop.Word.Table</returns>
        public Microsoft.Office.Interop.Word.Table findTableWithTitle(Document doc, string titleToFind)
        {
            foreach (Microsoft.Office.Interop.Word.Table table in doc.Tables)
            {
                if (table.Title == titleToFind)
                {
                    return table;
                }
            }
            return null;
        }

        /// <summary>
        /// Safely quits the Word instance.
        /// User has to dispose WordInterface instance immidetly after.
        /// </summary>
        public void Quit()
        {
            this.app.Quit(false);
            this.app = null;
        }
    }
}
