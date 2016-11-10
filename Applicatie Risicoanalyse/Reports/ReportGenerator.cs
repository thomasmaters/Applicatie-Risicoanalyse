using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Applicatie_Risicoanalyse.Reports.RiskAssesmentReport;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Applicatie_Risicoanalyse.Reports
{
    class ReportGenerator
    {
        /*protected ReportViewer reportViewer = new ReportViewer();
        protected PdfDocument report;
        protected string documentFileName;

        public ReportGenerator(string documentFileName)
        {
            this.documentFileName = documentFileName;
        }

        public virtual void documentCreateProcedure()
        {

        }

        protected PdfDocument generatePage(string pageRdlc, IEnumerable<ReportParameter> parameters)
        {
            //Load page into viewer.
            this.reportViewer.LocalReport.ReportPath = pageRdlc;
            this.reportViewer.LocalReport.SetParameters(parameters);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            //Convert to bytes and write it to a temp pdf file.
            using (FileStream fs = new FileStream("temp.pdf", FileMode.Create))
            {
                byte[] tempByteArray = this.reportViewer.LocalReport.Render(
                        "pdf", null, out mimeType, out encoding, out filenameExtension,
                                    out streamids, out warnings);
                fs.Write(tempByteArray, 0, tempByteArray.Length);
                fs.Dispose();
            }

            return PdfReader.Open("temp.pdf", PdfDocumentOpenMode.Import);
        }

        protected void addPagesToDocument(PdfDocument document)
        {
            using (PdfDocument outPdf = new PdfDocument())
            {
                CopyPages(this.report, outPdf);
                CopyPages(document, outPdf);

                outPdf.Save(this.documentFileName);
                outPdf.Dispose();
            }

            //Re-open our report.
            this.report = PdfReader.Open(this.documentFileName, PdfDocumentOpenMode.Import);
        }

        protected void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }*/
    }
}
