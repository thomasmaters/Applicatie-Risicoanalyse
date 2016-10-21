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

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_EditRiskRiskEstimation : UserControl
    {
        private int RiskDataID = 1;

        public ARA_EditRiskRiskEstimation()
        {
            InitializeComponent();
            DataRowCollection rows = this.tbl_RiskEstimation_GroupTableAdapter.GetData().Rows;

            this.arA_EditRiskRiskEstimationItem1.setAmountOfButtons(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[0]["GroupName"].ToString()).Rows.Count);
            this.arA_EditRiskRiskEstimationItem2.setAmountOfButtons(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[1]["GroupName"].ToString()).Rows.Count);
            this.arA_EditRiskRiskEstimationItem3.setAmountOfButtons(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[2]["GroupName"].ToString()).Rows.Count);
            this.arA_EditRiskRiskEstimationItem4.setAmountOfButtons(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[3]["GroupName"].ToString()).Rows.Count);

            this.arA_EditRiskRiskEstimationItem1.setGroupName(rows[0]["GroupName"].ToString());
            this.arA_EditRiskRiskEstimationItem2.setGroupName(rows[1]["GroupName"].ToString());
            this.arA_EditRiskRiskEstimationItem3.setGroupName(rows[2]["GroupName"].ToString());
            this.arA_EditRiskRiskEstimationItem4.setGroupName(rows[3]["GroupName"].ToString());

            this.arA_EditRiskRiskEstimationItem1.setButtonTexts(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[0]["GroupName"].ToString()).Rows);
            this.arA_EditRiskRiskEstimationItem2.setButtonTexts(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[1]["GroupName"].ToString()).Rows);
            this.arA_EditRiskRiskEstimationItem3.setButtonTexts(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[2]["GroupName"].ToString()).Rows);
            this.arA_EditRiskRiskEstimationItem4.setButtonTexts(this.get_RiskEstimationItems_From_GroupTableAdapter.GetData(rows[3]["GroupName"].ToString()).Rows);

            this.arA_EditRiskRiskEstimationItem1.setButtonSelected(2);
        }
    }
}
