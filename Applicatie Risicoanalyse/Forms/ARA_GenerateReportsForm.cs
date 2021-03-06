﻿using Applicatie_Risicoanalyse.Globals;
using Applicatie_Risicoanalyse.Reports;
using Applicatie_Risicoanalyse.Reports.PerformanceLevelReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_GenerateReportsForm : Form
    {
        private int projectID = 1;

        public ARA_GenerateReportsForm(int projectID)
        {
            this.projectID = projectID;

            InitializeComponent();

            //Set sorting options for listbox.
            foreach (KeyValuePair<string,string> sortingOption in ARA_Globals.RiskSortingOptions)
            {
                this.generateReportsComboBoxSort.Items.Add(sortingOption.Key as object);
            }

            //Scale form.
            this.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);
        }

        /// <summary>
        /// Click handler when the user wants to generate a RiskAssessmentReport.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button2_Click(object sender, EventArgs e)
        {
            //Did the user select a sorting option?
            if (!isSortingOptionSet())
            {
                return;
            }
            //Did the user select a location to store the file.
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                generateRiskAssessmentReport(this.folderBrowserDialog1.SelectedPath.ToString());
            }
        }

        /// <summary>
        /// Click handler when the user wants to generate a RemainingRiskReport.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button3_Click(object sender, EventArgs e)
        {
            //Did the user select a sorting option?
            if (!isSortingOptionSet())
            {
                return;
            }
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                generateRemainingRiskReport(this.folderBrowserDialog1.SelectedPath.ToString());
            }
        }

        /// <summary>
        /// Click handler when the user wants to generate a PerformanceLevelReport.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button4_Click(object sender, EventArgs e)
        {
            //Did the user select a sorting option?
            if (!isSortingOptionSet())
            {
                return;
            }
            //Did the user select a location to store the file.
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                generatePerformanceLevelReport(this.folderBrowserDialog1.SelectedPath.ToString());
            }
        }

        /// <summary>
        /// Starts generation of a performanceLevelReport.
        /// </summary>
        /// <param name="filePath">Where to save the report.</param>
        private void generatePerformanceLevelReport(string filePath)
        {
            if (hasWord2013OrLater())
            {
                PerformanceLevelReport report = new PerformanceLevelReport(
                    this.projectID,
                    this.generateReportsComboBoxSort.SelectedItem.ToString(),
                    filePath + "\\" + ARA_Constants.performanceLevelReportFileName,
                    ARA_Globals.PerformanceLevelRiskPageTemplate2013,
                    ARA_Globals.PerformanceLevelFrontPageTemplate2013);
                report.Show();
            }
            else
            {
                Debug.WriteLine(this.generateReportsComboBoxSort.SelectedItem);
                PerformanceLevelReport report = new PerformanceLevelReport(
                    this.projectID,
                    this.generateReportsComboBoxSort.SelectedItem.ToString(),
                    filePath + "\\" + ARA_Constants.performanceLevelReportFileName,
                    ARA_Globals.PerformanceLevelRiskPageTemplate,
                    ARA_Globals.PerformanceLevelFrontPageTemplate);
                report.Show();
            }
        }

        /// <summary>
        /// Starts generation of a remainingRiskReport.
        /// </summary>
        /// <param name="filePath">Where to save the report.</param>
        private void generateRemainingRiskReport(string filePath)
        {
            if (hasWord2013OrLater())
            {
                RemainingRiskReport report = new RemainingRiskReport(
                    this.projectID, this.generateReportsComboBoxSort.SelectedItem.ToString(),
                    filePath + "\\" + ARA_Constants.remainingRiskReportFileName,
                    ARA_Globals.RemainingRiskRiskPageHeaderTemplate2013,
                    ARA_Globals.RemainingRiskRiskPageTemplate2013,
                    ARA_Globals.RiskAssessmentIndexPageTemplate2013,
                    ARA_Globals.RemainingRiskFrontPageTemplate2013);
                report.Show();
            }
            else
            {
                Debug.WriteLine(this.generateReportsComboBoxSort.SelectedItem);
                RemainingRiskReport report = new RemainingRiskReport(
                    this.projectID, this.generateReportsComboBoxSort.SelectedItem.ToString(),
                    filePath + "\\" + ARA_Constants.remainingRiskReportFileName,
                    ARA_Globals.RemainingRiskRiskPageHeaderTemplate,
                    ARA_Globals.RemainingRiskRiskPageTemplate,
                    ARA_Globals.RiskAssessmentIndexPageTemplate,
                    ARA_Globals.RemainingRiskFrontPageTemplate);
                report.Show();
            }
        }

        /// <summary>
        /// Starts generation of a riskAssessmentReport.
        /// </summary>
        /// <param name="filePath">Where to save the report.</param>
        private void generateRiskAssessmentReport(string filePath)
        {
            if(hasWord2013OrLater())
            {
                RiskAssessmentReport report = new RiskAssessmentReport(
                    this.projectID, this.generateReportsComboBoxSort.SelectedItem.ToString(),
                    filePath + "\\" + ARA_Constants.riskAssesmentReportFileName,
                    ARA_Globals.RiskAssessmentRiskPageTemplate2013,
                    ARA_Globals.RiskAssessmentIndexPageTemplate2013,
                    ARA_Globals.RiskAssessmentFrontPageTemplate2013);
                report.Show();
            }
            else
            {
                Debug.WriteLine(this.generateReportsComboBoxSort.SelectedItem);
                RiskAssessmentReport report = new RiskAssessmentReport(
                    this.projectID, this.generateReportsComboBoxSort.SelectedItem.ToString(), 
                    filePath + "\\" + ARA_Constants.riskAssesmentReportFileName,
                    ARA_Globals.RiskAssessmentRiskPageTemplate,
                    ARA_Globals.RiskAssessmentIndexPageTemplate,
                    ARA_Globals.RiskAssessmentFrontPageTemplate);
                report.Show();
            }
        }

        /// <summary>
        /// Checks if the user selected a sorting option, show a popup box when false.
        /// </summary>
        /// <returns></returns>
        private bool isSortingOptionSet()
        {
            if (this.generateReportsComboBoxSort.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxSortingOptionNeeded, ARA_Constants.messageBoxSortingOptionNeededHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// The user wants to generate all the reports at once.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button1_Click(object sender, EventArgs e)
        {
            //Did the user select a sorting option?
            if (!isSortingOptionSet())
            {
                return;
            }

            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = this.folderBrowserDialog1.SelectedPath.ToString();
                generateRiskAssessmentReport(filePath);
                generateRemainingRiskReport(filePath);
                generatePerformanceLevelReport(filePath);
            }
        }

        private bool hasWord2013OrLater()
        {
            WordInterface word = new WordInterface();
            float version = word.getWordVersion();
            Console.WriteLine(version);
            word.Quit();
            return version > 14.99;
        }
    }
}
