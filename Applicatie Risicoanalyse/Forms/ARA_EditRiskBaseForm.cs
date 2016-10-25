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
using System.IO;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_EditRiskBaseForm : Form
    {
        private int riskDataID = 1;

        public ARA_EditRiskBaseForm()
        {
            InitializeComponent();

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                control.Font = this.Font;
            }

            setFormData();
        }

        private void setFormData()
        {
            try
            {
                //Get risk data.
                DataRow riskDataView = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);
                if (riskDataView == null)
                {
                    throw new ArgumentNullException();
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
                    if (e.checkState == CheckState.Checked)
                    {
                        this.tbl_RiskReduction_In_RiskTableAdapter.Insert(e.mesureID, riskDataID);
                    }
                    else if (e.checkState == CheckState.Unchecked)
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
                this.arA_EditRiskHazardIndentification1.dangerChangedEventHandler += delegate (object sender, DangerChangedEvent e)
                {
                    this.queriesTableAdapter1.Insert_Danger_In_RiskData(riskDataID, e.dangerID, e.dangerSourceID, e.hazardSituation, e.hazardEvent);
                };

                DataView exposedPersonsView = new DataView(this.get_ExposedPersons_In_RiskDataTableAdapter1.GetData(riskDataID));
                this.arA_EditRiskExposedPersons1.setControlData(exposedPersonsView, riskDataID);

                if (riskDataView["FileID"] != DBNull.Value)
                {
                    loadRiskImage((Int32)riskDataView["FileID"]);
                }
                else
                {
                    pictureBox1.Image = Applicatie_Risicoanalyse.Properties.Resources.NoRiskPicture;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ARA_EditRiskBaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_BLOB_Storage' table. You can move, or remove it, as needed.
            this.tbl_BLOB_StorageTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_BLOB_Storage);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Data' table. You can move, or remove it, as needed.
            this.tbl_Risk_DataTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Data);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_MinimalAddition_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_MinimalAddition_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_MinimalAddition_In_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_RiskReduction_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_RiskReduction_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_RiskReduction_In_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Data' table. You can move, or remove it, as needed.
            this.tbl_Risk_DataTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Data);
        }

        private void loadRiskImage(int fileID)
        {
            if (fileID != -1)
            {
                DataRow blodData = this.tbl_BLOB_StorageTableAdapter.GetData().FindByFileID(fileID);
                var data = (Byte[])(blodData["FileObject"]);
                pictureBox1.Image = Image.FromStream(new MemoryStream(data));
            }
        }

        private void arA_Button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(this.pictureBox1.Image, typeof(byte[]));
                this.queriesTableAdapter1.Insert_Picture_Into_Risk(this.riskDataID, arr);
            }
        }

        private void EditRiskButtonNextRisk_Click(object sender, EventArgs e)
        {
            this.riskDataID = 2;
            setFormData();
        }

        private void EditRiskButtonPreviousRisk_Click(object sender, EventArgs e)
        {
            this.riskDataID = 1;
            setFormData();
        }
    }
}
