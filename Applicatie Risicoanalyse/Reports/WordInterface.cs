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

        public void saveDocument(Document doc, string location)
        {
            object saveLocation = @location;

            //Save the document at a location.
            doc.SaveAs2(saveLocation);
            /*doc.SaveAs(ref saveLocation, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing);*/
        }

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

        public void Quit()
        {
            this.app.Quit(false);
            this.app = null;
        }
    }
}
