using Microsoft.Reporting.WebForms;
using System.Collections.Generic;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Data;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

namespace Applicatie_Risicoanalyse.Reports.RiskAssesmentReport
{
    class RiskAssesmentReport : ReportGenerator
    {
        public RiskAssesmentReport(string documentFileName) : base(documentFileName)
        {
            this.reportViewer.ProcessingMode = ProcessingMode.Local;
            
            //Create new document.
            this.report = new PdfDocument();
            this.report.AddPage();
            this.report.Save(this.documentFileName);

            //Set the pdf to import mode so we can add pages to it.
            this.report = PdfReader.Open(this.documentFileName, PdfDocumentOpenMode.Import);
        }

        public override void documentCreateProcedure()
        {
            
        }
    }
}
