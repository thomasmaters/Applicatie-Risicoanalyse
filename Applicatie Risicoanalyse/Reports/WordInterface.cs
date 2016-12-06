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
    public class WordInterface
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
        public void searchAndReplace(Document wordDocument, string find, string replaceWith, Color textColor = new Color(), bool searchInShapes = false)
        {
            Microsoft.Office.Interop.Word.Find findObject = this.app.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = find;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replaceWith;

            //Set text color if it is given.
            if (textColor != new Color())
            {
                findObject.Replacement.Font.Color = (Microsoft.Office.Interop.Word.WdColor)(textColor.R + 0x100 * textColor.G + 0x10000 * textColor.B);
            }

            object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            if(searchInShapes)
            {
                //Also check shapes
                var shapes = wordDocument.Shapes;
                //Finds text within textboxes, then changes them
                foreach (Microsoft.Office.Interop.Word.Shape shape in shapes)
                {
                    if(shape.Type == MsoShapeType.msoTextBox)
                    {
                        shape.TextFrame.TextRange.Find.ClearFormatting();

                        shape.TextFrame.TextRange.Find.Execute((object)find,
                            ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, (object)replaceWith, ref missing, ref missing, ref missing,
                            ref missing, ref missing);
                    }
                }
            }
        }

        /// <summary>
        /// Saves a document as a word document at a specific file location.
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="location">String representing a filepath where to save the document.</param>
        public void saveDocument(Document doc, string location)
        {
            object saveLocation = @location + ".docx";

            //Save the document at a location.
            doc.SaveAs2(saveLocation);
        }

        public void saveDocumentAsPdf(Document doc, string location)
        {
            object saveLocation = @location + ".pdf";

            //Save the document at a location.
            doc.Activate();
            doc.SaveAs2(saveLocation, WdSaveFormat.wdFormatPDF);
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
        /// Adds text to a table cell and removes the trailing enter.
        /// </summary>
        /// <param name="cellRange"></param>
        /// <param name="textToAdd"></param>
        /// <param name="addComma"></param>
        public void addTextToTableCell(Range cellRange, string textToAdd, bool addComma = false)
        {
            string temp;
            if (cellRange.Text.Length < 3)
            {
                temp = cellRange.Text.Substring(0, cellRange.Text.Length - 2) + textToAdd;
            }
            else if (cellRange.Text.Length > 2 && addComma == true)
            {
                temp = cellRange.Text.Substring(0, cellRange.Text.Length - 2) + ", " +  textToAdd;
            }
            else
            {
                temp = cellRange.Text.Substring(0, cellRange.Text.Length - 2) + textToAdd;
            }
            cellRange.Text = temp;
        }

        /// <summary>
        /// Sets the background color of all even rows in a table.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="color"></param>
        public void setAlternatingTableRowStyle(Table table, Color backgroundColor, int indexToStartAt = 2)
        {
            WdColor newBackgroundColor = (Microsoft.Office.Interop.Word.WdColor)(backgroundColor.R + 0x100 * backgroundColor.G + 0x10000 * backgroundColor.B);
            for (int i = indexToStartAt; i <= table.Rows.Count; i = i + 2)
            {
                table.Rows[i].Shading.BackgroundPatternColor = newBackgroundColor;
            }
        }

        /// <summary>
        /// Sets the background color of specific table row.
        /// </summary>
        /// <param name="tableRow"></param>
        /// <param name="color"></param>
        public void setTableRowBackgroundColor(Row tableRow, Color color)
        {
            tableRow.Shading.BackgroundPatternColor = (Microsoft.Office.Interop.Word.WdColor)(color.R + 0x100 * color.G + 0x10000 * color.B);
        }

        /// <summary>
        /// Merges all the cells in a row into 1.
        /// </summary>
        /// <param name="tableRow">Row to merge the cells of.</param>
        public void mergeTableRowCells(Row tableRow)
        {
            for (int i = 0; i < tableRow.Cells.Count + 1; i++)
            {
                tableRow.Cells[2].Merge(tableRow.Cells[1]);
                Debug.WriteLine(tableRow.Cells.Count);
            }
        }

        /// <summary>
        /// Sets the table row style of rows with a specific table row count.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="cellCount"></param>
        /// <param name="color"></param>
        public void setStyleOfTableRowsWithCellCount(Table table, int cellCount, Color color)
        {
            WdColor newBackgroundColor = (Microsoft.Office.Interop.Word.WdColor)(color.R + 0x100 * color.G + 0x10000 * color.B);
            foreach (Row row in table.Rows)
            {
                if (row.Cells.Count == cellCount)
                {
                    row.Shading.BackgroundPatternColor = newBackgroundColor;
                }
            }
        }

        /// <summary>
        /// Copies a table and paste it at the end of the document.
        /// </summary>
        /// <param name="document">Document to paste table in.</param>
        /// <param name="tableRange">Table range to copy.</param>
        /// <returns></returns>
        public Table copyTable(Document document, Range tableRange)
        {
            //Copy old table.
            tableRange.Copy();

            //Get the end of the document.
            Range rng = tableRange;
            rng.SetRange(document.Content.End, document.Content.End);

            //Insert linebreak.
            this.insertLineBreakAtRange(rng);
            rng.SetRange(document.Content.End, document.Content.End);

            //Paste the new table, 
            rng.Paste();

            return document.Tables[document.Tables.Count];
        }

        /// <summary>
        /// Inserts a watermark into a document.
        /// </summary>
        /// <param name="doc">The input document.</param>
        /// <param name="watermarkText">Text of the watermark.</param>
        public void insertWatermarkText(Document doc, string watermarkText)
        {
            Microsoft.Office.Interop.Word.Shape nShape = null;

            foreach (Section section in doc.Sections)
            {
                nShape = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Shapes.AddTextEffect(MsoPresetTextEffect.msoTextEffect1, watermarkText, "Gotham Light", 100, MsoTriState.msoTrue, MsoTriState.msoFalse, 0, 0);
                nShape.Fill.Visible = MsoTriState.msoTrue;
                nShape.Line.Visible = MsoTriState.msoFalse;
                nShape.Rotation = 45;
                nShape.Fill.Solid();
                nShape.Fill.ForeColor.RGB = (Int32)WdColor.wdColorGray20;
                nShape.RelativeHorizontalPosition = WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin;
                nShape.RelativeVerticalPosition = WdRelativeVerticalPosition.wdRelativeVerticalPositionMargin;
                // center location
                nShape.Left = (float)WdShapePosition.wdShapeCenter;
                nShape.Top = (float)WdShapePosition.wdShapeCenter;
            }
        }

        /// <summary>
        /// Inserts linebreak at specific range.
        /// </summary>
        /// <param name="range"></param>
        public void insertLineBreakAtRange(Range range)
        {
            range.Text += "\u2028\n";
        }

        /// <summary>
        /// Inserts pagebreak at specific range.
        /// </summary>
        /// <param name="range"></param>
        public void insertPageBreakAtRange(Range range)
        {
            range.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
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
