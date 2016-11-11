using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;
using Applicatie_Risicoanalyse.Reports.RiskAssesmentReport;
using System.Windows.Documents;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class testForm : Form
    {
        object missing = Type.Missing;
        object paramFalse = false;

        public testForm()
        {
            InitializeComponent();
            Debug.WriteLine("Strating to do things1");
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project' table. You can move, or remove it, as needed.
            this.tbl_Risks_In_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);

            

            Microsoft.Office.Interop.Word.Application wordApplication = null;
            Document wordDocument = null;

            Object paramDocPath = "C:\\Users\\Thomas\\Desktop\\Test.docx";
            Debug.WriteLine("Strating to do things2");
            try
            {
                // Start an instance of Word.
                wordApplication = new Microsoft.Office.Interop.Word.Application();
                // Open a new document.
                wordDocument = wordApplication.Documents.Open(paramDocPath);

                DataRow projectInfoRow = tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(3);

                Document doc2 = wordApplication.Documents.Open((object)"C:\\Users\\Thomas\\Desktop\\Test2.docx");
                foreach (DataRow riskDataRow in this.get_Risks_With_RiskData_In_ProjectTableAdapter.GetData(3).Rows)
                {
                    //Set checkbox controls selected or not.
                    doc2.SelectContentControlsByTitle("ExposedPersonOperator")[(object)1].Checked = true ;

                    //Copy template.
                    this.copyDocumentToOtherDocument(doc2, wordDocument, true);
                    wordDocument.Activate();

                    //Find table and do stuff with it.
                    Microsoft.Office.Interop.Word.Table test = findTableWithTitle(wordDocument, "AppliedRiskReductionMeasures");
                    if(test != null)
                    {
                        Row addedRow = test.Rows.Add(missing);

                        Range cell2Range = addedRow.Cells[2].Range;
                        cell2Range.Collapse(ref missing);
                        addedRow.Cells[2].Range.Text = " petra";
                        FormField checkBox = wordDocument.FormFields.Add(cell2Range, WdFieldType.wdFieldFormCheckBox);
                        checkBox.CheckBox.Value = true;

                        test.Title = "asdf";
                    }

                    //Search and replace headerinfo.
                    this.searchAndReplace(wordApplication, "<CustomerName>", projectInfoRow["Customer"].ToString());
                    this.searchAndReplace(wordApplication, "<MachineInfo>", projectInfoRow["MachineNumber"].ToString() + "/" + projectInfoRow["OrderNumber"].ToString());
                    this.searchAndReplace(wordApplication, "<RiskID>", riskDataRow["RiskID"].ToString());
                    this.searchAndReplace(wordApplication, "<BriefActionDescription>", riskDataRow["HazardSituation"].ToString());

                    //Search and replace riskdata.
                    this.searchAndReplace(wordApplication, "<RiskGroup>", riskDataRow["GroupName"].ToString() + " - " + riskDataRow["TypeName"].ToString());
                    //this.searchAndReplace(wordApplication, "<ActionEvent>", riskDataRow["HazardEvent"].ToString());

                }
                doc2.Close();

                // Save the document.
                this.saveDocument(wordDocument, (string)paramDocPath);

            }
            catch (Exception ex)
            {
                // Respond to the error
            }
            finally
            {
                // Close and release the Document object.
                if (wordDocument != null)
                {
                    ((_Document)wordDocument).Close(ref paramFalse, ref missing,
                        ref missing);
                    wordDocument = null;
                }

                // Quit Word and release the ApplicationClass object.
                if (wordApplication != null)
                {
                    wordApplication.Quit(ref missing, ref missing,
                        ref missing);
                    wordApplication = null;
                }
    
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void searchAndReplace(Microsoft.Office.Interop.Word.Application app,string find, string replaceWith)
        {
            Microsoft.Office.Interop.Word.Find findObject = app.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = find;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replaceWith;

            object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }

        private void saveDocument(Document doc, string location)
        {
            object saveLocation = location;

            //Save the document at a location.
            doc.SaveAs(ref saveLocation, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing);
        }

        private void copyDocumentToOtherDocument(Document documentToCopy, Document documentToPasteIn, bool addPageBreak = false)
        {
            //Select ranges.
            object docStart = documentToPasteIn.Content.End - 1;
            object docEnd = documentToPasteIn.Content.End;

            object start = documentToCopy.Content.Start;
            object end = documentToCopy.Content.End;

            //Select document and copy it.
            documentToCopy.Range(ref start, ref end).Copy();
            Range documentRange = documentToPasteIn.Range(ref docStart, ref docEnd);
            documentRange.Paste();

            //Insert pagebreak
            if(addPageBreak)
            {
                documentToPasteIn.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
            }
        }

        private Microsoft.Office.Interop.Word.Table findTableWithTitle(Document doc, string titleToFind)
        {
            foreach (Microsoft.Office.Interop.Word.Table table in doc.Tables)
            {
                if(table.Title == titleToFind)
                {
                    return table;
                }
            }
            return null;
        }
    }
}
