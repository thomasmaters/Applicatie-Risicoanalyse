using Microsoft.Reporting.WebForms;
using System.Collections.Generic;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Data;

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
            IEnumerable<ReportParameter> headerParameters = new ReportParameter[] { new ReportParameter("ProjectID", "1") };
            IEnumerable<ReportParameter> initalRiskParameters = new ReportParameter[] {
                 new ReportParameter("ProjectID", "1"),
                new ReportParameter("RiskEstimationBeforeSE",new string[] { "",""}),
                new ReportParameter("RiskEstimationBeforeFR",new string[] { "",""}),
                new ReportParameter("RiskEstimationBeforePR",new string[] { "",""}),
                new ReportParameter("RiskEstimationBeforeAV",new string[] { "",""}),
                new ReportParameter("HazardResult",new string[] { "",""})
            };

            LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter ProjectDataTable = new Applicatie_Risicoanalyse.LG_Analysis_DatabaseDataSetTableAdapters.Tbl_Risk_AnalysisTableAdapter();
            ProjectDataTable.Fill(new LG_Analysis_DatabaseDataSet.Tbl_Risk_AnalysisDataTable());

            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Project", (DataTable)ProjectDataTable.GetData()));
            PdfDocument doc = generatePage("Reports/RiskAssesmentReport/PageRisk.rdlc", initalRiskParameters);
            

            addPagesToDocument(doc);
            IEnumerable<ReportParameter> e2 = new ReportParameter[] { };
            doc = generatePage("Reports/RiskAssesmentReport/PageRisk.rdlc", initalRiskParameters);
            addPagesToDocument(doc);
            addPagesToDocument(doc);
        }
    }
}
