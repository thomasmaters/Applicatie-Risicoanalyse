using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_EditRiskBaseForm : Form
    {
        public ARA_EditRiskBaseForm()
        {
            InitializeComponent();
            DataRow riskDataView = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(1);

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach(Control control in this.flowLayoutPanel1.Controls)
            {
                control.Font = this.Font;
            }

            DataView riskEstimationViewBefore = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(1));
            this.arA_EditRiskRiskEstimation1.setRiskEstimationData(riskEstimationViewBefore);

            DataView riskReductionMesuresView = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(1));
            this.arA_EditRiskRiskReductionMesures1.setControlData(riskReductionMesuresView);
            this.arA_EditRiskRiskReductionMesures1.setRiskReductionInfo(riskDataView["RiskReductionInfo"].ToString());

            DataView minimalAdditionView = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(1));
            this.arA_EditRiskRiskReductionMesures2.setControlData(minimalAdditionView);
            this.arA_EditRiskRiskReductionMesures2.setRiskReductionInfo(riskDataView["MinimalAdditionInfo"].ToString());

            DataView riskEstimationViewAfter = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(1));
            this.arA_EditRiskRiskEstimation2.setRiskEstimationData(riskEstimationViewAfter);
        }

        private void ARA_EditRiskBaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Data' table. You can move, or remove it, as needed.
            this.tbl_Risk_DataTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Data);
        }
    }
}
