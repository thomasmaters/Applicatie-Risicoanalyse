using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Risicoanalyse.Globals
{
    public static class ARA_Constants
    {
        //Application constants.
        public const string applicationVersion = "ALPHA-V3.001";
        public const float noScaleFontSize = 15F;

        //New risk creation constants.
        public const int hazardSituationMinimalTextLength = 25;
        public const int hazardEventMinimalTextLength = 25;

        //Document generation constants.
        public const string riskAssesmentReportFileName = "Risk Assessment Report.docx";
        public const string remainingRiskReportFileName = "Remaining Rest-Risk Report.docx";
    }
}
