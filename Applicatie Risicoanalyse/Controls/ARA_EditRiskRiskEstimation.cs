using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_EditRiskRiskEstimation : UserControl
    {
        public ARA_EditRiskRiskEstimation()
        {
            InitializeComponent();

            arA_EditRiskRiskEstimationItem1.Invalidated += delegate(object sender, InvalidateEventArgs e) { this.updateSafetyMesuresRequirement(); };
            arA_EditRiskRiskEstimationItem2.Invalidated += delegate (object sender, InvalidateEventArgs e) { this.updateSafetyMesuresRequirement(); };
            arA_EditRiskRiskEstimationItem3.Invalidated += delegate (object sender, InvalidateEventArgs e) { this.updateSafetyMesuresRequirement(); };
            arA_EditRiskRiskEstimationItem4.Invalidated += delegate (object sender, InvalidateEventArgs e) { this.updateSafetyMesuresRequirement(); };
        }

        public void setRiskEstimationData(DataTable selectedRowDataTable)
        { 
            DataRowCollection rows = this.tbl_RiskEstimation_GroupTableAdapter.GetData().Rows;
            string groupName1 = rows[0]["GroupName"].ToString();
            string groupName2 = rows[1]["GroupName"].ToString();
            string groupName3 = rows[2]["GroupName"].ToString();
            string groupName4 = rows[3]["GroupName"].ToString();

            this.arA_EditRiskRiskEstimationItem1.setGroupName(groupName1);
            this.arA_EditRiskRiskEstimationItem2.setGroupName(groupName2);
            this.arA_EditRiskRiskEstimationItem3.setGroupName(groupName3);
            this.arA_EditRiskRiskEstimationItem4.setGroupName(groupName4);

            this.arA_EditRiskRiskEstimationItem1.setButtonTextsAndWeights(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(groupName1).Rows);
            this.arA_EditRiskRiskEstimationItem2.setButtonTextsAndWeights(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(groupName2).Rows);
            this.arA_EditRiskRiskEstimationItem3.setButtonTextsAndWeights(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(groupName3).Rows);
            this.arA_EditRiskRiskEstimationItem4.setButtonTextsAndWeights(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(groupName4).Rows);

            this.arA_EditRiskRiskEstimationItem1.setButtonSelected()
        }

        public void updateSafetyMesuresRequirement()
        {
            int riskClassification = calculateRiskEstimationClass();
            string classText = "";

            if(riskClassification == 1)
            {
                classText = "Safety measures recommended.";
            }
            else if(riskClassification == 2)
            {
                classText = "Safety measures required!";
            }
            else
            {
                classText = "No safety measures rquired";
            }

            this.arA_Text6.Text = "Risk class:" + riskClassification.ToString() + " (Points:" + calculateRiskPoints().ToString() + ") " + classText;
            this.arA_Text6.Invalidate();
        }

        public int calculateRiskEstimationClass()
        {
            int severity = this.arA_EditRiskRiskEstimationItem1.SelectedWeight;
            int totalRiskPoints = calculateRiskPoints();

            if (totalRiskPoints < 4)
            {
                return 0;
            }

            int[,] classMatrix = new int[4,12]
            {
                { 0,0,0,0,0,0,0,1,1,1,2,2},
                { 0,0,0,0,1,1,1,2,2,2,2,2},
                { 0,1,1,1,2,2,2,2,2,2,2,2},
                { 1,2,2,2,2,2,2,2,2,2,2,2}
            };

            return classMatrix[severity - 1,totalRiskPoints - 4];
        }

        public int calculateRiskPoints()
        {
            return
            (
                this.arA_EditRiskRiskEstimationItem2.SelectedWeight +
                this.arA_EditRiskRiskEstimationItem3.SelectedWeight +
                this.arA_EditRiskRiskEstimationItem4.SelectedWeight
            );
        }
    }
}
