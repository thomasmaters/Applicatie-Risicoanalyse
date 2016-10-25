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
            int riskDataID = 1;

            DataRow riskDataView = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(1);

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach(Control control in this.flowLayoutPanel1.Controls)
            {
                control.Font = this.Font;
            }

            DataView riskEstimationViewBefore = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
            this.arA_EditRiskRiskEstimation1.setControlData(riskEstimationViewBefore);
            this.arA_EditRiskRiskEstimation1.riskEstimationEvenHandler += delegate (object sender, RiskEstimationChangedEvent e)
            {
                this.queriesTableAdapter1.Insert_Into_RiskEstimation_Before(riskDataID, e.estimationID, e.groupName);
            };

            DataView riskReductionMesuresView = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
            this.arA_EditRiskRiskReductionMesures1.setControlData(riskReductionMesuresView);
            this.arA_EditRiskRiskReductionMesures1.setRiskReductionInfo(riskDataView["RiskReductionInfo"].ToString());
            this.arA_EditRiskRiskReductionMesures1.reductionMesureInfoChanged += delegate (object sender, EventArgs e)
            {
                riskDataView["RiskReductionInfo"] = this.arA_EditRiskRiskReductionMesures1.ReductionMesureInfo;
                this.tbl_Risk_DataTableAdapter.Update(riskDataView);
            };
            this.arA_EditRiskRiskReductionMesures1.itemCheckEventHandler += delegate (object sender, MesureItemChangedEvent e)
            {
                if(e.checkState == CheckState.Checked)
                {
                    this.tbl_RiskReduction_In_RiskTableAdapter.Insert(e.mesureID, riskDataID);
                }
                else if(e.checkState == CheckState.Unchecked)
                {
                    this.tbl_RiskReduction_In_RiskTableAdapter.Delete(e.mesureID, riskDataID);
                }
            };

            DataView minimalAdditionView = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));
            this.arA_EditRiskRiskReductionMesures2.setControlData(minimalAdditionView);
            this.arA_EditRiskRiskReductionMesures2.setRiskReductionInfo(riskDataView["MinimalAdditionInfo"].ToString());
            this.arA_EditRiskRiskReductionMesures2.reductionMesureInfoChanged += delegate (object sender, EventArgs e)
            {
                riskDataView["MinimalAdditionInfo"] = this.arA_EditRiskRiskReductionMesures2.ReductionMesureInfo;
                this.tbl_Risk_DataTableAdapter.Update(riskDataView);
            };
            this.arA_EditRiskRiskReductionMesures2.itemCheckEventHandler += delegate (object sender, MesureItemChangedEvent e)
            {
                if (e.checkState == CheckState.Checked)
                {
                    this.tbl_MinimalAddition_In_RiskTableAdapter.Insert(e.mesureID, riskDataID);
                }
                else if (e.checkState == CheckState.Unchecked)
                {
                    this.tbl_MinimalAddition_In_RiskTableAdapter.Delete(e.mesureID, riskDataID);
                }
            };

            DataView riskEstimationViewAfter = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
            this.arA_EditRiskRiskEstimation2.setControlData(riskEstimationViewAfter);
            this.arA_EditRiskRiskEstimation2.riskEstimationEvenHandler += delegate (object sender, RiskEstimationChangedEvent e)
            {
                this.queriesTableAdapter1.Insert_Into_RiskEstimation_After(riskDataID, e.estimationID, e.groupName);
            };

            this.arA_EditRiskHazardIndentification1.setControlData(riskDataID);

            DataView exposedPersonsView = new DataView(this.get_ExposedPersons_In_RiskDataTableAdapter1.GetData(riskDataID));
            this.arA_EditRiskExposedPersons1.setControlData(exposedPersonsView, riskDataID);
        }

        private void ARA_EditRiskBaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_MinimalAddition_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_MinimalAddition_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_MinimalAddition_In_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_RiskReduction_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_RiskReduction_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_RiskReduction_In_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Data' table. You can move, or remove it, as needed.
            this.tbl_Risk_DataTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Data);
        }
    }
}
