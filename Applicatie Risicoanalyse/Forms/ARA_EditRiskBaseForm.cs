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
        private int riskID = 1;
        private int riskVersionID = 1;
        private int riskDataID = 1;
        private int projectID = 1;
        private string riskGroupName = "";
        private string riskTypeName = "";
        private string hazardSituation = "";
        private bool isRiskDataProjectSpecific = false;

        public ARA_EditRiskBaseForm(int riskID, int riskVersionID, int riskDataID, int projectID, bool isRiskDataProjectSpecific)
        {
            InitializeComponent();

            //Initialize variables.
            this.riskID = riskID;
            this.riskVersionID = riskVersionID;
            this.riskDataID = riskDataID;
            this.projectID = projectID;
            this.isRiskDataProjectSpecific = isRiskDataProjectSpecific;

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                control.Font = this.Font;
            }
            this.EditRiskButtonNextRisk.Font = new Font("Gotham Light", 11);
            this.EditRiskButtonPreviousRisk.Font = new Font("Gotham Light", 11);

            setFormData();
            setNextRisk(0);
        }

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

                //Risk estimation before risk reduction.
                DataView riskEstimationViewBefore = new DataView(this.get_RiskEstimation_In_RiskData_BeforeTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskEstimation1.setControlData(riskEstimationViewBefore);
                this.arA_EditRiskRiskEstimation1.riskEstimationEvenHandler += delegate (object sender, RiskEstimationChangedEvent e)
                {
                    setRiskDataProjectSpecific();
                    this.queriesTableAdapter1.Insert_Into_RiskEstimation_Before(riskDataID, e.estimationID, e.groupName);
                };

                //Risk reduction.
                DataView riskReductionMesuresView = new DataView(this.get_RiskReduction_In_RiskDataTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskReductionMesures1.setControlData(riskReductionMesuresView);
                this.arA_EditRiskRiskReductionMesures1.setRiskReductionInfo(riskDataView["RiskReductionInfo"].ToString());
                this.arA_EditRiskRiskReductionMesures1.reductionMesureInfoChanged += delegate (object sender, EventArgs e)
                {
                    setRiskDataProjectSpecific();
                    this.queriesTableAdapter1.Update_RiskReductionInfo_In_RiskData(this.riskDataID, this.arA_EditRiskRiskReductionMesures1.ReductionMesureInfo);
                };
                this.arA_EditRiskRiskReductionMesures1.itemCheckEventHandler += delegate (object sender, MesureItemChangedEvent e)
                {
                    setRiskDataProjectSpecific();
                    if (e.checkState == CheckState.Checked)
                    {
                        this.tbl_RiskReduction_In_RiskTableAdapter.Insert(e.mesureID, riskDataID);
                    }
                    else if (e.checkState == CheckState.Unchecked)
                    {
                        this.tbl_RiskReduction_In_RiskTableAdapter.Delete(e.mesureID, riskDataID);
                    }
                };

                //Remaing risks after risk reduction.
                DataView minimalAdditionView = new DataView(this.get_MinimalAddition_In_RiskDataTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskReductionMesures2.setControlData(minimalAdditionView);
                this.arA_EditRiskRiskReductionMesures2.setRiskReductionInfo(riskDataView["MinimalAdditionInfo"].ToString());
                this.arA_EditRiskRiskReductionMesures2.reductionMesureInfoChanged += delegate (object sender, EventArgs e)
                {
                    setRiskDataProjectSpecific();
                    this.queriesTableAdapter1.Update_MinimalAdditionInfo_In_RiskData(this.riskDataID, this.arA_EditRiskRiskReductionMesures2.ReductionMesureInfo);
                };
                this.arA_EditRiskRiskReductionMesures2.itemCheckEventHandler += delegate (object sender, MesureItemChangedEvent e)
                {
                    setRiskDataProjectSpecific();
                    if (e.checkState == CheckState.Checked)
                    {
                        this.tbl_MinimalAddition_In_RiskTableAdapter.Insert(e.mesureID, riskDataID);
                    }
                    else if (e.checkState == CheckState.Unchecked)
                    {
                        this.tbl_MinimalAddition_In_RiskTableAdapter.Delete(e.mesureID, riskDataID);
                    }
                };

                //Risk estimation after risk reduction.
                DataView riskEstimationViewAfter = new DataView(this.get_RiskEstimation_In_RiskData_AfterTableAdapter.GetData(riskDataID));
                this.arA_EditRiskRiskEstimation2.setControlData(riskEstimationViewAfter);
                this.arA_EditRiskRiskEstimation2.riskEstimationEvenHandler += delegate (object sender, RiskEstimationChangedEvent e)
                {
                    setRiskDataProjectSpecific();
                    this.queriesTableAdapter1.Insert_Into_RiskEstimation_After(riskDataID, e.estimationID, e.groupName);
                };

                //Hazard indentification.
                this.arA_EditRiskHazardIndentification1.setControlData(riskDataID);
                this.arA_EditRiskHazardIndentification1.dangerChangedEventHandler += delegate (object sender, DangerChangedEvent e)
                {
                    setRiskDataProjectSpecific();
                    this.queriesTableAdapter1.Insert_Danger_In_RiskData(riskDataID, e.dangerID, e.dangerSourceID, e.hazardSituation, e.hazardEvent);
                };

                //Exposed persons.
                DataView exposedPersonsView = new DataView(this.get_ExposedPersons_In_RiskDataTableAdapter1.GetData(riskDataID));
                this.arA_EditRiskExposedPersons1.setControlData(exposedPersonsView, riskDataID);
                this.arA_EditRiskExposedPersons1.exposedPersonChangedEventHandler += delegate (object sender, ExposedPersonChangedEvent e)
                {
                    setRiskDataProjectSpecific();
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

        //Signals the form and the database to make a project specific risk.
        private void setRiskDataProjectSpecific()
        {
            if(this.isRiskDataProjectSpecific == false)
            {
                if (this.projectID == -1)//Are we edeting the standard?
                {
                    DataRow tempRow = this.create_New_Risk_VersionTableAdapter.GetData(this.riskID, this.riskVersionID, this.riskDataID).Rows[0];
                    if(tempRow != null && tempRow["newRiskDataID"] != DBNull.Value)
                    {
                        this.riskVersionID += 1;
                        this.riskDataID = (Int32)tempRow["newRiskDataID"];
                    }

                    //Update risks in open risk projects with new risk version.
                    this.queriesTableAdapter1.Update_Risks_In_Open_Risk_Projects();
                }
                else
                {
                    DataRow tempRow = this.update_RiskDataID_In_RisksInProjectTableAdapter.GetData(this.projectID, this.riskID).Rows[0];
                    this.riskDataID = (Int32)tempRow["newRiskDataID"];
                }

                this.isRiskDataProjectSpecific = true;
                setTopBarRiskInfo();
            }
        }

        private void setTopBarRiskInfo()
        {
            //Set top bar info.
            ARA_EditRiskBaseTopBar aForm = new ARA_EditRiskBaseTopBar(
                    string.Format("RiskID: {0} -- {1} -> {2}\nVersion: {3}",this.riskID,this.riskGroupName,this.riskTypeName,this.riskVersionID),
                    string.Format("{0} {1}", this.hazardSituation,this.isRiskDataProjectSpecific && this.projectID != -1 ? "\n(Project specific)":""));
            ARA_Events.triggerBaseFormSetTopBarEvent(aForm);
        }

        private void ARA_EditRiskBaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk' table. You can move, or remove it, as needed.
            this.tbl_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_ExposedPersons_In_Risk' table. You can move, or remove it, as needed.
            this.tbl_ExposedPersons_In_RiskTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_ExposedPersons_In_Risk);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project' table. You can move, or remove it, as needed.
            this.tbl_Risks_In_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risks_In_Project);
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

        //Loads image from database if we have a fileid.
        private void loadRiskImage(int fileID)
        {
            if (fileID != -1)
            {
                DataRow blodData = this.tbl_BLOB_StorageTableAdapter.GetData().FindByFileID(fileID);
                var data = (Byte[])(blodData["FileObject"]);
                pictureBox1.Image = Image.FromStream(new MemoryStream(data));
            }
        }

        //Button clicked for uploading a new image.
        private void arA_Button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        //New image file chosen.
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel == false)
            {
                setRiskDataProjectSpecific();

                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(this.pictureBox1.Image, typeof(byte[]));

                this.queriesTableAdapter1.Insert_Picture_Into_Risk(this.riskDataID, arr);
            }
        }

        private void EditRiskButtonNextRisk_Click(object sender, EventArgs e)
        {
            setNextRisk(1);
            setFormData();
        }

        private void EditRiskButtonPreviousRisk_Click(object sender, EventArgs e)
        {
            setNextRisk(-1);
            setFormData();
        }

        //Sets button texts.
        private void setPreviousAndNextButtonTexts()
        {
            //Set previous and next button texts.
            this.EditRiskButtonPreviousRisk.Text = string.Format("< Previous risk in\n{0} - {1}", this.riskGroupName, this.riskTypeName);
            this.EditRiskButtonNextRisk.Text = string.Format("Next risk in>\n{0} - {1}", this.riskGroupName, this.riskTypeName);
            this.EditRiskButtonPreviousRisk.setButtonSelected(false);
            this.EditRiskButtonNextRisk.setButtonSelected(false);
        }

        //Sets the forms current displayed risk to the next risk in the group.
        private void setNextRisk(int direction)
        {
            DataTable risksInGroupAndTypeView;
            if (this.projectID == -1)
            {
                risksInGroupAndTypeView = this.get_Risks_In_Group_And_TypeTableAdapter.GetData(this.riskGroupName, this.riskTypeName);
            }
            else
            {
                risksInGroupAndTypeView = this.get_Risks_With_Type_And_Group_In_ProjectTableAdapter.GetData(this.projectID, this.riskGroupName, this.riskTypeName);
            }
            int currentRiskRowIndex = risksInGroupAndTypeView.Rows.IndexOf(risksInGroupAndTypeView.Select("RiskID = " + this.riskID.ToString())[0]);
            int risksInGroupAndTypeCount = risksInGroupAndTypeView.Rows.Count;

            //Calculate next riskRowIndex.
            if (currentRiskRowIndex + direction == risksInGroupAndTypeView.Rows.Count)
            {
                currentRiskRowIndex = 0;
            }
            else if(currentRiskRowIndex + direction == -1)
            {
                currentRiskRowIndex = risksInGroupAndTypeView.Rows.Count - 1;
            }
            else
            {
                currentRiskRowIndex += direction;
            }

            //Determin wich button the user can press.
            if (risksInGroupAndTypeCount == 1)
            {
                this.EditRiskButtonNextRisk.Enabled = false;
                this.EditRiskButtonPreviousRisk.Enabled = false;
            }
            else if (currentRiskRowIndex == 0)
            {
                this.EditRiskButtonNextRisk.Enabled = true;
                this.EditRiskButtonPreviousRisk.Enabled = false;
            }
            else if (risksInGroupAndTypeCount == 2 || currentRiskRowIndex == risksInGroupAndTypeCount - 1)
            {
                this.EditRiskButtonNextRisk.Enabled = false;
                this.EditRiskButtonPreviousRisk.Enabled = true;
            }
            else
            {
                this.EditRiskButtonNextRisk.Enabled = true;
                this.EditRiskButtonPreviousRisk.Enabled = true;
            }

            //Set class variables.
            this.riskID = (Int32)risksInGroupAndTypeView.Rows[currentRiskRowIndex]["RiskID"];
            this.riskVersionID = (Int32)risksInGroupAndTypeView.Rows[currentRiskRowIndex]["VersionID"];

            if(this.projectID != -1) //We are edeting a project specific risk.
            {
                if(risksInGroupAndTypeView.Rows[currentRiskRowIndex]["ProjectRiskDataID"] != DBNull.Value)
                {
                    this.riskDataID = (Int32)risksInGroupAndTypeView.Rows[currentRiskRowIndex]["ProjectRiskDataID"];
                    this.isRiskDataProjectSpecific = true;
                }
                else
                {
                    this.riskDataID = (Int32)risksInGroupAndTypeView.Rows[currentRiskRowIndex]["DefaultRiskDataID"];
                    this.isRiskDataProjectSpecific = false;
                }
            }
            else //We are editing a standard risk.
            {
                this.riskDataID = (Int32)risksInGroupAndTypeView.Rows[currentRiskRowIndex]["RiskDataID"];
                this.isRiskDataProjectSpecific = false;
            }

            //Sets navigator data.
            this.EditRiskTextAmountOfRisksInType.Text = (currentRiskRowIndex + 1).ToString() + "/" + risksInGroupAndTypeCount.ToString();

            //Set previous and next button texts.
            setPreviousAndNextButtonTexts();
        }
    }
}
