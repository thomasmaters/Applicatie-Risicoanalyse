using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Risicoanalyse.Reports.PerformanceLevelReport
{
    class PLCalculator
    {
        private char[] plMatrix;
        private uint severityThreshold = 2;
        private uint frequencyThreshold = 4;
        private uint possabilityOfAvoidingThreshold = 3;
        public PLCalculator()
        {
            plMatrix = new char[8]
            {
                'a','b','b','c','c','d','d','e'
            };
        }

        /// <summary>
        /// Calculates PLr from risk estimation weights.
        /// </summary>
        /// <param name="riskEstimationSeverity"></param>
        /// <param name="riskEstimationFrequency"></param>
        /// <param name="riskEstimationPossabilityOfAvoiding"></param>
        /// <returns></returns>
        public char calculatePerformanceLevel(int riskEstimationSeverity, int riskEstimationFrequency, int riskEstimationPossabilityOfAvoiding)
        {
            //Calculate weight
            uint PlrWeight = plSeverity(riskEstimationSeverity) + plFrequency(riskEstimationFrequency) + plPossabilityOfAvoiding(riskEstimationPossabilityOfAvoiding);

            Debug.Write(PlrWeight.ToString() + "->");

            //Return plr.
            return this.plMatrix[PlrWeight];
        }

        /// <summary>
        /// Calculates S from risk esitimation severity.
        /// </summary>
        /// <param name="riskEstimationSeverity"></param>
        /// <returns></returns>
        private uint plSeverity(int riskEstimationSeverity)
        {
            //Is the severity above a threshold?
            if(riskEstimationSeverity > this.severityThreshold)
            {
                return 4;
            }
            return 0;
        }
        public string plSeverityText(int riskEstimationSeverity)
        {
            //Is the severity above a threshold?
            if (riskEstimationSeverity > this.severityThreshold)
            {
                return "S2";
            }
            return "S1";
        }

        /// <summary>
        /// Calculates F from risk estimation frequency.
        /// </summary>
        /// <param name="riskEstimationFrequency"></param>
        /// <returns></returns>
        private uint plFrequency(int riskEstimationFrequency)
        {
            //Is the frequency above a threshold?
            if(riskEstimationFrequency > this.frequencyThreshold)
            {
                return 2;
            }
            return 0;
        }
        public string plFrequencyText(int riskEstimationFrequency)
        {
            //Is the frequency above a threshold?
            if (riskEstimationFrequency > this.frequencyThreshold)
            {
                return "F2";
            }
            return "F1";
        }

        /// <summary>
        /// Calculate P from risk estimation possability of avoiding.
        /// </summary>
        /// <param name="riskEstimationPossabilityOfAvoiding"></param>
        /// <returns></returns>
        private uint plPossabilityOfAvoiding(int riskEstimationPossabilityOfAvoiding)
        {
            //Is the possability of avoiding above a threshold?
            if(riskEstimationPossabilityOfAvoiding > this.possabilityOfAvoidingThreshold)
            {
                return 1;
            }
            return 0;
        }
        public string plPossabilityOfAvoidingText(int riskEstimationPossabilityOfAvoiding)
        {
            //Is the possability of avoiding above a threshold?
            if (riskEstimationPossabilityOfAvoiding > this.possabilityOfAvoidingThreshold)
            {
                return "P2";
            }
            return "P1";
        }
    }
}
