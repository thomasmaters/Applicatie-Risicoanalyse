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
        private int riskCreatedByUserID = -1;
        private string projectState = ARA_Constants.draft;
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
            //Set project state if we are not editing the risk standard.
            if(this.projectID != -1)
            {
                this.projectState = this.tbl_Risk_AnalysisTableAdapter.GetData().FindByProjectID(this.projectID)["StateName"].ToString();
            }

            //Scaling form and controls.
            this.Font = new Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);
            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                control.Font = this.Font;
            }
            this.EditRiskButtonNextRisk.Font = new Font(ARA_Globals.ARA_Font, 11);
            this.EditRiskButtonPreviousRisk.Font = new Font(ARA_Globals.ARA_Font, 11);

            setFormData();
            setNextRisk(0);

            loadPermissions();

            setProjectEditable();
        }

        /// <summary>
        /// Loads the users permissions.
        /// </summary>
        private void loadPermissions()
        {
            this.arA_EditRiskExposedPersons1.Enabled         = ARA_ACL.getPermissionLevel("Function.EditExposedPersons") == ARA_Globals.PermissionLevel.All;
            this.arA_EditRiskHazardIndentification1.Enabled  = ARA_ACL.getPermissionLevel("Function.EditHazardIndentification") == ARA_Globals.PermissionLevel.All;
            this.arA_EditRiskRiskEstimation1.Enabled         = ARA_ACL.getPermissionLevel("Function.EditRiskEstimationBeforeRiskReduction") == ARA_Globals.PermissionLevel.All;
            this.arA_EditRiskRiskEstimation2.Enabled         = ARA_ACL.getPermissionLevel("Function.EditRiskEstimationAfterRiskReduction") == ARA_Globals.PermissionLevel.All;
            this.arA_EditRiskRiskReductionMesures1.Enabled   = ARA_ACL.getPermissionLevel("Function.EditRiskReductionMesures") == ARA_Globals.PermissionLevel.All;
            this.arA_EditRiskRiskReductionMesures2.Enabled   = ARA_ACL.getPermissionLevel("Function.EditRemaingRisk") == ARA_Globals.PermissionLevel.All;
            this.arA_ButtonEditRiskImage.Enabled             = ARA_ACL.getPermissionLevel("Function.EditRiskImage") == ARA_Globals.PermissionLevel.All;
            this.editRiskBaseFormButtonReviewAccept.Enabled  = ARA_ACL.getPermissionLevel("Function.ReviewRisks") == ARA_Globals.PermissionLevel.All;
            this.editRiskBaseFormButtonReviewDecline.Enabled = ARA_ACL.getPermissionLevel("Function.ReviewRisks") == ARA_Globals.PermissionLevel.All;
        }

        /// <summary>
        /// Sets the data for the controls and insert handles to update changes to database.
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
                this.riskCreatedByUserID = (Int32)riskDataView["UserID"];

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
                this.arA_EditRiskRiskReductionMesures1.itemCheckEventHandler += delegate (object sender, MeasureItemChangedEvent e)
                {
                    setRiskDataProjectSpecific();
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
                    setRiskDataProjectSpecific();
                    this.queriesTableAdapter1.Update_MinimalAdditionInfo_In_RiskData(this.riskDataID, this.arA_EditRiskRiskReductionMesures2.ReductionMesureInfo);
                };
                this.arA_EditRiskRiskReductionMesures2.itemCheckEventHandler += delegate (object sender, MeasureItemChangedEvent e)
                {
                    setRiskDataProjectSpecific();
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

                //Show popup box with reviewer comment on risk open.
                if (projectState == ARA_Constants.draft && this.projectID != -1)
                {
                    DataRow riskInProjectRow = this.tbl_Risks_In_ProjectTableAdapter.GetData().FindByProjectIDVersionIDRiskID(this.projectID, this.riskVersionID, this.riskID);
                    if (riskInProjectRow != null)
                    {
                        string reviewerComment = riskInProjectRow["ReviewerComment"].ToString();
                        if (reviewerComment != null && reviewerComment != string.Empty)
                        {
                            System.Windows.Forms.MessageBox.Show( ARA_Constants.messageBoxReviewerComment + reviewerComment, ARA_Constants.messageBoxReviewerCommentHeader , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception )
            {
                throw;
            }
        }

        /// <summary>
        /// Makes project editable on specific project state.
        /// </summary>
        private void setProjectEditable()
        {
            if (this.projectState != ARA_Constants.draft)
            {
                this.arA_EditRiskExposedPersons1.Enabled = false;
                this.arA_EditRiskHazardIndentification1.Enabled = false;
                this.arA_EditRiskRiskEstimation1.Enabled = false;
                this.arA_EditRiskRiskEstimation2.Enabled = false;
                this.arA_EditRiskRiskReductionMesures1.Enabled = false;
                this.arA_EditRiskRiskReductionMesures2.Enabled = false;
                this.arA_ButtonEditRiskImage.Enabled = false;
            }
            if (this.projectState == ARA_Constants.forReview
                && (Int32)this.tbl_ProjectTableAdapter.GetData().FindByProjectID(this.projectID)["UserID"] != ARA_Globals.UserID)
            {
                this.editRiskBaseFormButtonReviewAccept.Visible = true;
                this.editRiskBaseFormButtonReviewDecline.Visible = true;
            }
        }

        /// <summary>
        /// Signals the form and the database to make a project specific risk.
        /// </summary>
        private void setRiskDataProjectSpecific()
        {
            if(this.isRiskDataProjectSpecific == false)
            {
                if (this.projectID == -1)//Are we edeting the standard?
                {
                    DataRow tempRow = this.create_New_Risk_VersionTableAdapter.GetData(this.riskID, this.riskVersionID, this.riskDataID, ARA_Globals.UserID).Rows[0];
                    if(tempRow != null && tempRow["newRiskDataID"] != DBNull.Value)
                    {
                        this.riskVersionID += 1;
                        this.riskDataID = (Int32)tempRow["newRiskDataID"];

                        //Log event.
                        ARA_Events.triggerNewRiskVersionEvent(this.riskID, this.riskVersionID);

                        //Let the user know we made a new version of the risk.
                        System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxNewRiskVersion, ARA_Constants.messageBoxNewRiskVersionHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Update risks in open risk projects with new risk version.
                    this.queriesTableAdapter1.Update_Risks_In_Open_Risk_Projects();
                }
                else
                {
                    //Execute query to make risk projectspecific.
                    DataRow tempRow = this.update_RiskDataID_In_RisksInProjectTableAdapter.GetData(this.projectID, this.riskID, ARA_Globals.UserID).Rows[0];
                    this.riskDataID = (Int32)tempRow["newRiskDataID"];

                    //Log event.
                    ARA_Events.triggerProjectSpecificRiskCreatedEvent(this.riskID,this.projectID);

                    //Let the user know we made a project specific project.
                    System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxRiskProjectSpecific, ARA_Constants.messageBoxRiskProjectSpecificHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.isRiskDataProjectSpecific = true;
                setTopBarRiskInfo();
            }
        }

        /// <summary>
        /// Sets risk info in the topbar of the application.
        /// </summary>
        private void setTopBarRiskInfo()
        {
            //Set top bar info.
            ARA_TopBar aForm = new ARA_TopBar(
                    string.Format("RiskID: {0} -- {1} -> {2}\nVersion: {3}, Created by: {4}", 
                        this.riskID, 
                        this.riskGroupName, 
                        this.riskTypeName, 
                        this.riskVersionID,
                        this.tbl_UserTableAdapter.GetData().FindByUserID(this.riskCreatedByUserID)["UserName"].ToString()),
                    string.Format("{0} {1}", 
                        this.hazardSituation,
                        this.isRiskDataProjectSpecific && this.projectID != -1 ? "\n(Project specific)":""));
            ARA_Events.triggerBaseFormSetTopBarEvent(aForm);
        }

        private void ARA_EditRiskBaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_User' table. You can move, or remove it, as needed.
            this.tbl_UserTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_User);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Project' table. You can move, or remove it, as needed.
            this.tbl_ProjectTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Project);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
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

            setTopBarRiskInfo();
        }

        /// <summary>
        /// Loads image from database if we have a fileID.
        /// </summary>
        /// <param name="fileID">File id of the file in the database.</param>
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
        /// Show file selecter when button for uploading a new image is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// Event when the user selects an image file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When the next button is clicked, handle it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditRiskButtonNextRisk_Click(object sender, EventArgs e)
        {
            setNextRisk(1);
            setFormData();
        }

        /// <summary>
        /// When the previous button is clicked, handle it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditRiskButtonPreviousRisk_Click(object sender, EventArgs e)
        {
            setNextRisk(-1);
            setFormData();
        }

        /// <summary>
        /// Sets the button text for the privious en next buttons.
        /// </summary>
        private void setPreviousAndNextButtonTexts()
        {
            //Set previous and next button texts.
            this.EditRiskButtonPreviousRisk.Text = string.Format("< Previous risk in\n{0} - {1}", this.riskGroupName, this.riskTypeName);
            this.EditRiskButtonNextRisk.Text = string.Format("Next risk in>\n{0} - {1}", this.riskGroupName, this.riskTypeName);
            this.EditRiskButtonPreviousRisk.setButtonSelected(false);
            this.EditRiskButtonNextRisk.setButtonSelected(false);
        }

        /// <summary>
        /// Sets the forms current displayed risk to the next risk in the dataset.
        /// </summary>
        /// <param name="direction">Direction to go from current selected risk.</param>
        private void setNextRisk(int direction)
        {
            //Get project data when some conditions are met.
            DataTable risksInGroupAndTypeView;
            if (this.projectID == -1)
            {
                risksInGroupAndTypeView = this.get_Risks_In_Group_And_TypeTableAdapter.GetData(this.riskGroupName, this.riskTypeName);
            }
            else if (this.projectState == ARA_Constants.forReview)
            {
                risksInGroupAndTypeView = this.get_Risks_In_ProjectTableAdapter.GetData(this.projectID);
            }
            else
            {
                risksInGroupAndTypeView = this.get_Risks_With_Type_And_Group_In_ProjectTableAdapter.GetData(this.projectID, this.riskGroupName, this.riskTypeName);
            }

            //Did we get any rows from the database.
            if(risksInGroupAndTypeView.Rows.Count == 0)
            {
                throw new Exception();
            }

            //What is our current index in the component typen list?
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
            //Set next or previous buttons enabled/disabled.
            toggleNextPreviousButtons(risksInGroupAndTypeCount, currentRiskRowIndex);
        }

        /// <summary>
        /// Enables buttons for going to next or previous risk if some critics are met.
        /// </summary>
        /// <param name="riskCount">Total amount of risks.</param>
        /// <param name="riskIndex">The current risk being shown.</param>
        private void toggleNextPreviousButtons(int riskCount, int riskIndex)
        {
            //Determin wich button the user can press.
            if (this.projectState == ARA_Constants.forReview 
                && (Int32)this.tbl_ProjectTableAdapter.GetData().FindByProjectID(this.projectID)["UserID"] != ARA_Globals.UserID)
            {
                this.EditRiskButtonNextRisk.Text = "";
                this.EditRiskButtonPreviousRisk.Text = "";
                this.EditRiskButtonNextRisk.Enabled = false;
                this.EditRiskButtonPreviousRisk.Enabled = false;
            }
            else if (riskCount == 1)
            {
                this.EditRiskButtonNextRisk.Enabled = false;
                this.EditRiskButtonPreviousRisk.Enabled = false;
            }
            else if (riskIndex == 0)
            {
                this.EditRiskButtonNextRisk.Enabled = true;
                this.EditRiskButtonPreviousRisk.Enabled = false;
            }
            else if (riskCount == 2 || riskIndex == riskCount - 1)
            {
                this.EditRiskButtonNextRisk.Enabled = false;
                this.EditRiskButtonPreviousRisk.Enabled = true;
            }
            else
            {
                this.EditRiskButtonNextRisk.Enabled = true;
                this.EditRiskButtonPreviousRisk.Enabled = true;
            }
        }

        /// <summary>
        /// When the button is pressed go to the next risk and mark the risk as accepted by the reviewer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editRiskBaseFormButtonReviewAccept_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.Set_Risk_In_Project_Reviewed(this.projectID, this.riskID, ARA_Globals.UserID,string.Empty);
            setNextRisk(1);
            setFormData();
        }

        /// <summary>
        /// When this button is pressed go to the next risk and mark the risk as declined.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editRiskBaseFormButtonReviewDecline_Click(object sender, EventArgs e)
        {
            ARA_InputDialogPopupForm testDialog = new ARA_InputDialogPopupForm("Give comment", "Leave a comment why this risk is declined.");

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.queriesTableAdapter1.Set_Risk_In_Project_Reviewed(this.projectID, this.riskID, -1, "" + testDialog.inputDialogTextboxInput.Text);
                setNextRisk(1);
                setFormData();
            }
            else
            {

            }
            testDialog.Dispose();
        }
    }
}
