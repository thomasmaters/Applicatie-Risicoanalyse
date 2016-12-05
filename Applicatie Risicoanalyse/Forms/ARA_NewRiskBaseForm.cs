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
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_NewRiskBaseForm : Form
    {
        private int riskID = 1;
        private int riskVersionID = 1;
        private int riskDataID = 1;
        private string riskGroupName = "";
        private string riskTypeName = "";
        private string hazardSituation = "";

        public ARA_NewRiskBaseForm()
        {
            InitializeComponent();

            //Initalize variables.
            DataRow newRisk = this.create_New_RiskTableAdapter.GetData().Rows[0];
            this.riskID = (Int32)newRisk["newRiskID"];
            this.riskDataID = (Int32)newRisk["newRiskDataID"];

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                control.Font = this.Font;
            }

            //Add event.
            ARA_Events.OpenContentFormEventHandler += checkIfControlHasBeenFilledOnClose;

            //Fill form.
            setFormData();
            setControlsEnabled();
        }

        /// <summary>
        /// Set the data for all the controls.
        /// </summary>
        private void setFormData()
        {
            try
            {
                //Get risk data.
                DataRow riskView = this.tbl_RiskTableAdapter.GetData().FindByRiskIDVersionID(this.riskID, this.riskVersionID);
                DataRow riskDataView = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);
                if (riskDataView == null || riskView == null)
                {
                    throw new ArgumentNullException("riskDataView/riskView","Couldn't retrieve data from database with riskId: " + this.riskDataID.ToString());
                }

                this.riskGroupName = riskView["GroupName"].ToString();
                this.riskTypeName = riskView["TypeName"].ToString();
                this.hazardSituation = riskDataView["HazardSituation"].ToString();

                //Risk grouping.
                this.arA_NewRiskRiskGrouping1.setControlData();
                this.arA_NewRiskRiskGrouping1.riskComponentGroupAndTypeChangedEventHandler += delegate (object sender, RiskComponentGroupAndTypeChangedEvent e)
                {
                    setControlsEnabled();

                    //Update some displayed data.
                    this.riskGroupName = e.componentGroup;
                    this.riskTypeName = e.componentType;
                    setTopBarRiskInfo();

                    this.queriesTableAdapter1.Update_ComponentTypeAndGroup_In_Risk(this.riskID, this.riskVersionID, e.componentGroup, e.componentType);
                };

                //Risk estimation before risk reduction.
                DataView riskEstimationViewBefore = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskEstimation1.setControlData(riskEstimationViewBefore);
                this.arA_EditRiskRiskEstimation1.riskEstimationEvenHandler += delegate (object sender, RiskEstimationChangedEvent e)
                {
                    setControlsEnabled();
                    this.queriesTableAdapter1.Insert_Into_RiskEstimation_Before(riskDataID, e.estimationID, e.groupName);
                };

                //Risk reduction after risk reduction.
                DataView riskReductionMesuresView = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskReductionMesures1.setControlData(riskReductionMesuresView);
                this.arA_EditRiskRiskReductionMesures1.setRiskReductionInfo(riskDataView["RiskReductionInfo"].ToString());
                this.arA_EditRiskRiskReductionMesures1.reductionMesureInfoChanged += delegate (object sender, EventArgs e)
                {
                    setControlsEnabled();
                    this.queriesTableAdapter1.Update_RiskReductionInfo_In_RiskData(this.riskDataID, this.arA_EditRiskRiskReductionMesures1.ReductionMesureInfo);
                };
                this.arA_EditRiskRiskReductionMesures1.itemCheckEventHandler += delegate (object sender, MeasureItemChangedEvent e)
                {
                    setControlsEnabled();
                    if (e.checkState == CheckState.Checked)
                    {
                        this.tbl_RiskReduction_In_RiskTableAdapter.Insert(e.measureID, riskDataID);
                    }
                    else if (e.checkState == CheckState.Unchecked)
                    {
                        this.tbl_RiskReduction_In_RiskTableAdapter.Delete(e.measureID, riskDataID);
                    }
                };

                //Remaing risks after risk reduction.
                DataView minimalAdditionView = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskReductionMesures2.setControlData(minimalAdditionView);
                this.arA_EditRiskRiskReductionMesures2.setRiskReductionInfo(riskDataView["MinimalAdditionInfo"].ToString());
                this.arA_EditRiskRiskReductionMesures2.reductionMesureInfoChanged += delegate (object sender, EventArgs e)
                {
                    setControlsEnabled();
                    this.queriesTableAdapter1.Update_MinimalAdditionInfo_In_RiskData(this.riskDataID, this.arA_EditRiskRiskReductionMesures2.ReductionMesureInfo);
                };
                this.arA_EditRiskRiskReductionMesures2.itemCheckEventHandler += delegate (object sender, MeasureItemChangedEvent e)
                {
                    setControlsEnabled();
                    if (e.checkState == CheckState.Checked)
                    {
                        this.tbl_MinimalAddition_In_RiskTableAdapter.Insert(e.measureID, riskDataID);
                    }
                    else if (e.checkState == CheckState.Unchecked)
                    {
                        this.tbl_MinimalAddition_In_RiskTableAdapter.Delete(e.measureID, riskDataID);
                    }
                };

                //Risk estimation after risk reduction.
                DataView riskEstimationViewAfter = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskEstimation2.setControlData(riskEstimationViewAfter);
                this.arA_EditRiskRiskEstimation2.riskEstimationEvenHandler += delegate (object sender, RiskEstimationChangedEvent e)
                {
                    setControlsEnabled();
                    this.queriesTableAdapter1.Insert_Into_RiskEstimation_After(riskDataID, e.estimationID, e.groupName);
                };

                //Hazard indentification.
                this.arA_EditRiskHazardIndentification1.setControlData(riskDataID);
                this.arA_EditRiskHazardIndentification1.dangerChangedEventHandler += delegate (object sender, DangerChangedEvent e)
                {
                    setControlsEnabled();
                    this.queriesTableAdapter1.Insert_Danger_In_RiskData(riskDataID, e.dangerID, e.dangerSourceID, e.hazardSituation, e.hazardEvent);
                };

                //Exposed persons.
                DataView exposedPersonsView = new DataView(this.get_ExposedPersons_In_RiskDataTableAdapter1.GetData(riskDataID));
                this.arA_EditRiskExposedPersons1.setControlData(exposedPersonsView, riskDataID);
                this.arA_EditRiskExposedPersons1.exposedPersonChangedEventHandler += delegate (object sender, ExposedPersonChangedEvent e)
                {
                    setControlsEnabled();
                    if (e.checkedState == CheckState.Checked)
                    {
                        this.tbl_ExposedPersons_In_RiskTableAdapter.Insert(e.exposedPersonID,this.riskDataID);
                    }
                    else
                    {
                        this.tbl_ExposedPersons_In_RiskTableAdapter.Delete(e.exposedPersonID, this.riskDataID);
                    }
                };

                //Do we have an image, load default picture otherwise.
                if (riskDataView["FileID"] != DBNull.Value)
                {
                    loadRiskImage((Int32)riskDataView["FileID"]);
                }
                else
                {
                    pictureBox1.Image = Applicatie_Risicoanalyse.Properties.Resources.NoRiskPicture;
                }

                setTopBarRiskInfo();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Signals the form and the database to make a project specific risk.
        /// </summary>
        private void setControlsEnabled()
        {
            this.arA_EditRiskExposedPersons1.Enabled = this.arA_NewRiskRiskGrouping1.HasControlBeenChanged;
            this.arA_EditRiskHazardIndentification1.Enabled = this.arA_EditRiskExposedPersons1.HasControlBeenChanged;
            this.arA_EditRiskRiskEstimation1.Enabled = this.arA_EditRiskHazardIndentification1.HasControlBeenChanged;
            this.arA_EditRiskRiskReductionMesures1.Enabled = this.arA_EditRiskRiskEstimation1.HasControlBeenChanged;
            this.arA_EditRiskRiskEstimation2.Enabled = this.arA_EditRiskRiskReductionMesures1.HasControlBeenChanged;
            this.arA_EditRiskRiskReductionMesures2.Enabled = this.arA_EditRiskRiskEstimation2.HasControlBeenChanged;

            //Set indicator color to show user what is correctly filled in.
            this.arA_NewRiskRiskGrouping1.IndicatorRectangleColor = this.arA_EditRiskExposedPersons1.Enabled ? ARA_Colors.ARA_Green : ARA_Colors.ARA_Red;
            this.arA_EditRiskExposedPersons1.IndicatorRectangleColor = this.arA_EditRiskHazardIndentification1.Enabled ? ARA_Colors.ARA_Green : ARA_Colors.ARA_Red;
            this.arA_EditRiskHazardIndentification1.IndicatorRectangleColor = this.arA_EditRiskRiskEstimation1.Enabled ? ARA_Colors.ARA_Green : ARA_Colors.ARA_Red;
            this.arA_EditRiskRiskEstimation1.IndicatorRectangleColor = this.arA_EditRiskRiskReductionMesures1.Enabled ? ARA_Colors.ARA_Green : ARA_Colors.ARA_Red;
            this.arA_EditRiskRiskReductionMesures1.IndicatorRectangleColor = this.arA_EditRiskRiskEstimation2.Enabled ? ARA_Colors.ARA_Green : ARA_Colors.ARA_Red;
            this.arA_EditRiskRiskEstimation2.IndicatorRectangleColor = this.arA_EditRiskRiskReductionMesures2.Enabled ? ARA_Colors.ARA_Green : ARA_Colors.ARA_Red;
            this.arA_EditRiskRiskReductionMesures2.IndicatorRectangleColor = ARA_Colors.ARA_Green;
        }

        /// <summary>
        /// Sets project info on the topbar.
        /// </summary>
        private void setTopBarRiskInfo()
        {
            //Set top bar info.
            ARA_TopBar aForm = new ARA_TopBar(
                    string.Format("RiskID: {0} -- {1} -> {2}\nVersion: {3}",this.riskID,this.riskGroupName,this.riskTypeName,this.riskVersionID),
                    string.Format("{0}", this.hazardSituation));
            ARA_Events.triggerBaseFormSetTopBarEvent(aForm);
        }

        private void ARA_EditRiskBaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk' table. You can move, or remove it, as needed.
            this.tbl_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_ExposedPersons_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_ExposedPersons_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_ExposedPersons_In_Risk);
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

        /// <summary>
        /// Loads image from database if we have a fileId.
        /// </summary>
        /// <param name="fileID"></param>
        private void loadRiskImage(int fileID)
        {
            if (fileID != -1)
            {
                DataRow blodData = this.tbl_BLOB_StorageTableAdapter.GetData().FindByFileID(fileID);
                var data = (Byte[])(blodData["FileObject"]);
                pictureBox1.Image = Image.FromStream(new MemoryStream(data));
            }
        }
        /// <summary>
        /// Button clicked for uploading a new image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// Handler when the user selects a image file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                setControlsEnabled();

                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(this.pictureBox1.Image, typeof(byte[]));

                this.queriesTableAdapter1.Insert_Picture_Into_Risk(this.riskDataID, arr);
            }
        }

        /// <summary>
        /// Check if we have filled the form, delete the risk otherwise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkIfControlHasBeenFilledOnClose(object sender, OpenContentFormEvent e)
        {
            if(e.Form == this)
            {
                return;
            }

            deleteControlIfItIsNotFilled();
        }

        /// <summary>
        /// Checks if the risk is correctly filled in, deletes it otherwise.
        /// </summary>
        private void deleteControlIfItIsNotFilled()
        {
            if (this.arA_NewRiskRiskGrouping1.HasControlBeenChanged == false ||
            this.arA_EditRiskExposedPersons1.HasControlBeenChanged == false ||
            this.arA_EditRiskHazardIndentification1.HasControlBeenChanged == false ||
            this.arA_EditRiskRiskEstimation1.HasControlBeenChanged == false ||
            this.arA_EditRiskRiskReductionMesures1.HasControlBeenChanged == false) //The form is not filled in correctly.
            {
                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxCoudntCreateRisk, ARA_Constants.messageBoxCoudntCreateRiskHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.queriesTableAdapter1.Delete_Risk(this.riskID, this.riskDataID);
            }
            else //We filled the form correctly
            {
                //Log event.
                ARA_Events.triggerNewRiskAddedToStandardEvent(this.riskID);

                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxAddedRiskToStandard, ARA_Constants.messageBoxAddedRiskToStandardHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ARA_Events.OpenContentFormEventHandler -= checkIfControlHasBeenFilledOnClose;
        }
    }
}
