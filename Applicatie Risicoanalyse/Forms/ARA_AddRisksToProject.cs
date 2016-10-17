using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;
using System.Data.Sql;
using System.IO;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_AddRisksToProject : Form
    {
        private int projectID;

        public ARA_AddRisksToProject(int projectID)
        {
            //Initialize variables.
            this.projectID = projectID;
            InitializeComponent();

            //Add event.
            ARA_Events.AddRiskToProjectEventHandler += addRiskToProject;
        }

        private void onRiskProjectOverviewLoad()
        {
            //Set scaling.
            this.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);

            foreach (DataRow datarow in this.tbl_Component_GroupTableAdapter.GetData().Rows)
            {
                ARA_ListGroup listGroup = new ARA_ListGroup();
                styleListGroupAsGroup(listGroup);
                //Set button text.
                listGroup.DropDownButtonText = datarow["GroupName"].ToString();
                //Add functions.
                listGroup.addFunction(delegate () 
                {
                    DataRow risksInGroupDataRow = this.get_Risks_In_Project_GroupTableAdapter.GetData(this.projectID, datarow["GroupName"].ToString()).Rows[0];
                    listGroup.LabelText = risksInGroupDataRow["RisksInProjectGroup"] + "/" + risksInGroupDataRow["RisksInGroup"];
                });
                listGroup.updateControl();
                listGroup.addFunction(delegate () { this.addTypeControlsToGroupControl(listGroup); });

                //Add listGroup to addRiskToProjectPanel.
                this.addRiskToProjectPanelContent.Controls.Add(listGroup);
            }
        }

        public void addTypeControlsToGroupControl(ARA_ListGroup parentGroup)
        {
            if(parentGroup.ARA_ListGroupDropDownButton.ConnectedPanel.Controls.Count != 0)
            {
                return;
            }
            foreach (DataRow datarow in this.get_TypeNames_In_GroupTableAdapter.GetData(parentGroup.DropDownButtonText).Rows)
            {
                ARA_ListGroup listType = new ARA_ListGroup();
                styleListGroupAsType(parentGroup, listType);
                listType.DropDownButtonText = datarow["TypeName"].ToString();

                //Add functions.
                listType.addFunction(delegate ()
                {
                    DataRow risksInTypeDataRow = this.get_Risks_In_Project_TypeTableAdapter.GetData(this.projectID, parentGroup.DropDownButtonText, datarow["TypeName"].ToString()).Rows[0];
                    listType.LabelText = risksInTypeDataRow["RisksInProjectGroup"] + "/" + risksInTypeDataRow["RisksInGroup"];
                });
                listType.updateControl();
                listType.addFunction(delegate () { this.addRiskControlsToTypeControl(parentGroup, listType); });

                //Add click handler for mass insert/delete risks in project on doubleclick.
                listType.DoubleClick += delegate (object o, EventArgs e)
                {
                    DataRow risksInTypeDataRow = this.get_Risks_In_Project_TypeTableAdapter.GetData(this.projectID, parentGroup.DropDownButtonText, datarow["TypeName"].ToString()).Rows[0];
                    //Execute procedure to add or remove risks from a specific type in the project.
                    this.queriesTableAdapter1.Insert_Risks_From_Type_Into_Project
                    (
                        this.projectID,
                        datarow["TypeName"].ToString(), 
                        risksInTypeDataRow["RisksInProjectGroup"].ToString() != risksInTypeDataRow["RisksInGroup"].ToString()
                    );
                };
            }
        }

        public void addRiskControlsToTypeControl(ARA_ListGroup parentGroup, ARA_ListGroup parentType)
        {
            //Did we already create the controls?
            if (parentType.ARA_ListGroupDropDownButton.ConnectedPanel.Controls.Count != 0)
            {
                return;
            }
            //Execute querye and loop through the results.
            foreach (DataRow datarow in this.get_Risks_In_ProjectGroupTypeTableAdapter.GetData(this.projectID,parentGroup.DropDownButtonText,parentType.DropDownButtonText).Rows)
            {
                ARA_ListItem listItem = new ARA_ListItem();
                styleListItemAsRisk(parentType,listItem);
                if(datarow["FileObject"].ToString() != "")
                {
                    var data = (Byte[])(datarow["FileObject"]);
                    var stream = new MemoryStream(data);
                    listItem.Tooltip.Tag = Image.FromStream(stream);
                }

                //Set text of listItem.
                listItem.TextFirstControl = "ID " + datarow["RiskID"].ToString();
                listItem.TextSecondControl = datarow["TypeName"].ToString();
                listItem.BackgroundColor = datarow["InProject"].ToString() == "1" ? ARA_Colors.ARA_Green : System.Drawing.Color.White;

                //Add let it execute an event on click.
                listItem.Click += delegate (object o, System.EventArgs e)
                {
                    ARA_Events.onAddRiskToProjectEvent(o, this.projectID, Int32.Parse(datarow["RiskID"].ToString()));
                };
                listItem.addFunction(delegate ()
                {
                    listItem.BackgroundColor = this.is_Risk_In_ProjectTableAdapter.GetData(this.projectID, Int32.Parse(datarow["RiskID"].ToString())).Rows[0]["InProject"].ToString() == "1" ? ARA_Colors.ARA_Green : Color.White;
                });
            }
        }

        private void styleListGroupAsGroup(ARA_ListGroup listGroup)
        {
            listGroup.ARA_ListGroupDropDownButton.Font = this.Font;
            listGroup.ARA_ListGroupDropDownButton.Padding = new Padding(0);
            listGroup.ARA_ListGroupText.Font = this.Font;
            listGroup.BackColor = System.Drawing.SystemColors.Control;
            listGroup.BackgroundColor = ARA_Colors.ARA_Gray1;
            listGroup.DropDownButtonFirstTrianglePadding = -1;
            listGroup.DropDownButtonSecondTrianglePadding = -1;
            listGroup.DropDownButtonSize = new System.Drawing.Size(656, 37);
            listGroup.HoverColor = ARA_Colors.ARA_Gray2;
            listGroup.ImeMode = System.Windows.Forms.ImeMode.On;
            listGroup.ListParent = null;
            listGroup.Location = new System.Drawing.Point(31, 9);
            listGroup.Margin = new System.Windows.Forms.Padding(0);
            listGroup.Name = "arA_ListGroup1";
            listGroup.SelectedColor = ARA_Colors.ARA_Blue6;
            listGroup.Size = new System.Drawing.Size(750, 415);
            listGroup.TextSize = new System.Drawing.Size(94, 37);
        }

        private void styleListGroupAsType(ARA_ListGroup listParent ,ARA_ListGroup listGroup)
        {
            listGroup.ARA_ListGroupDropDownButton.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            listGroup.ARA_ListGroupText.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            listGroup.BackColor = System.Drawing.SystemColors.Control;
            listGroup.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            listGroup.DropDownButtonFirstTrianglePadding = 5;
            listGroup.DropDownButtonSecondTrianglePadding = -1;
            listGroup.DropDownButtonSize = new System.Drawing.Size(656, 28);
            listGroup.HoverColor = ARA_Colors.ARA_Blue4;
            listGroup.ImeMode = System.Windows.Forms.ImeMode.On;
            listGroup.ListParent = listParent;
            listGroup.Location = new System.Drawing.Point(31, 9);
            listGroup.Margin = new System.Windows.Forms.Padding(0);
            listGroup.Name = "arA_ListGroup1";
            listGroup.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(160)))), ((int)(((byte)(198)))));
            listGroup.Size = new System.Drawing.Size(750, 415);
            listGroup.TextSize = new System.Drawing.Size(94, 28);

            listParent.addChild(listGroup);
            listParent.addControlToDropDownButton(listGroup);
            listGroup.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize/ARA_Globals.ARa_NoScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Globals.ARa_NoScaleFontSize));
        }

        private void styleListItemAsRisk(ARA_ListGroup listParent, ARA_ListItem listItem)
        {
            listItem.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 4F);
            listItem.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            listItem.Location = new System.Drawing.Point(111, 65);
            listItem.Margin = new System.Windows.Forms.Padding(0);
            listItem.Size = new System.Drawing.Size(750, 24);
            listItem.Name = "addRisksToProjectTextID";
            listItem.ListParent = listParent;

            listParent.addChild(listItem);
            listParent.addControlToDropDownButton(listItem);
            listItem.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize / ARA_Globals.ARa_NoScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Globals.ARa_NoScaleFontSize));
        }

        private void addRiskToProject(object sender, AddRiskToProjectEvent e)
        {
            ARA_ListItem clickedText = (ARA_ListItem)sender;
            if (clickedText != null)
            {
                //Is the risk already in the project?
                if (clickedText.BackgroundColor == ARA_Colors.ARA_Green)
                {
                    //Change its color and remove it from the database.
                    clickedText.BackgroundColor = Color.White;
                    this.queriesTableAdapter1.Delete_From_ProjectRisks(e.projectID, e.riskID);
                }
                else
                {
                    //Change its color and add a new risk to the database.
                    clickedText.BackgroundColor = ARA_Colors.ARA_Green;
                    this.queriesTableAdapter1.Insert_In_ProjectRisks(e.projectID, e.riskID);
                }
            }
            clickedText.Invalidate();
        }

        private void ARA_AddRisksToProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Component_Type' table. You can move, or remove it, as needed.
            this.tbl_Component_TypeTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Component_Type);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Component_Group' table. You can move, or remove it, as needed.
            this.tbl_Component_GroupTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Component_Group);
            this.onRiskProjectOverviewLoad();
        }

        private void onSearchBarTextChanged(object sender, EventArgs e)
        {
            this.addRiskToProjectSearchDataGrid.Visible = this.addRiskToProjectSearchTextBox.Text != "";
            this.addRiskToProjectSearchDataGrid.DataSource = this.search_Risks_In_ProjectTableAdapter.GetData(this.projectID, this.addRiskToProjectSearchTextBox.Text);
            this.addRiskToProjectSearchDataGrid.Refresh();
        }

        private void onDataGridRowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in this.addRiskToProjectSearchDataGrid.Rows)
            { 
                if (row.Cells["inProjectDataGridViewTextBoxColumn"].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = ARA_Colors.ARA_Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void onDataGridRowDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Execute query to add or delete the risk to the project.
            if (this.addRiskToProjectSearchDataGrid.Rows[e.RowIndex].Cells["inProjectDataGridViewTextBoxColumn"].Value.ToString() == "1")
            {
                this.queriesTableAdapter1.Delete_From_ProjectRisks(this.projectID, Int32.Parse(this.addRiskToProjectSearchDataGrid.Rows[e.RowIndex].Cells["riskIDDataGridViewTextBoxColumn"].Value.ToString()));
            }
            else
            {
                this.queriesTableAdapter1.Insert_In_ProjectRisks(this.projectID, Int32.Parse(this.addRiskToProjectSearchDataGrid.Rows[e.RowIndex].Cells["riskIDDataGridViewTextBoxColumn"].Value.ToString()));
            }
            //Sneaky way to fire a textchange event without changing the text.
            this.addRiskToProjectSearchTextBox.Text += "";
        }

        private void onDataGridSelectionChanged(object sender, EventArgs e)
        {
            this.addRiskToProjectSearchDataGrid.ClearSelection();
        }
        /*
private ARA_DropDownButton createGroupNameDropDownButton(string groupName)
{
ARA_DropDownButton newDropDownButton = new ARA_DropDownButton();
FlowLayoutPanel newFlowLayoutPanel = new FlowLayoutPanel();
//Style the button
newDropDownButton.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
newDropDownButton.BaseColor = ARA_Colors.ARA_Gray1;
newDropDownButton.HorizontalAlignment = System.Drawing.StringAlignment.Near;
newDropDownButton.HoverColor = ARA_Colors.ARA_Gray2;
newDropDownButton.Location = new System.Drawing.Point(0, 0);
newDropDownButton.Margin = new System.Windows.Forms.Padding(0);
newDropDownButton.Name = "addRiskToProjectButton" + groupName;
newDropDownButton.PaddingFirstTriangle = -1;
newDropDownButton.PaddingSecondTriangle = -1;
newDropDownButton.Selected = false;
newDropDownButton.SelectedColor = ARA_Colors.ARA_Blue6;
newDropDownButton.Size = new System.Drawing.Size(690, 37);
newDropDownButton.Text = groupName;
newDropDownButton.TextColor = System.Drawing.Color.White;
newDropDownButton.TriangleSize = 22;
newDropDownButton.VerticalAlignment = System.Drawing.StringAlignment.Center;

//Style panel.
newFlowLayoutPanel.Location = new System.Drawing.Point(0, 40);
newFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
newFlowLayoutPanel.Name = "addRiskToProjectPanel" + groupName;
newFlowLayoutPanel.Size = new System.Drawing.Size(750, 100);
newFlowLayoutPanel.AutoSize = true;
newFlowLayoutPanel.Visible = false;

//Add panels to addRiskToProject content panel.
this.addRiskToProjectPanelContent.Controls.Add(newDropDownButton);
this.createGroupNameRiskCountText(groupName);
this.addRiskToProjectPanelContent.Controls.Add(newFlowLayoutPanel);
//Connect panel to button.
newDropDownButton.setConnectedPanel(newFlowLayoutPanel);

//Return the button
return newDropDownButton;
}

private ARA_DropDownButton createTypeNameDropDownButton(FlowLayoutPanel parentPanel, string groupName, string typeName)
{
ARA_DropDownButton newDropDownButton = new ARA_DropDownButton();
FlowLayoutPanel newFlowLayoutPanel = new FlowLayoutPanel();
//Style the button
newDropDownButton.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
newDropDownButton.BaseColor = ARA_Colors.ARA_Gray2;
newDropDownButton.HorizontalAlignment = System.Drawing.StringAlignment.Near;
newDropDownButton.HoverColor = ARA_Colors.ARA_Gray2;
newDropDownButton.Location = new System.Drawing.Point(0, 37);
newDropDownButton.Margin = new System.Windows.Forms.Padding(0);
newDropDownButton.Name = "addRiskToProjectButton" + groupName + typeName;
newDropDownButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
newDropDownButton.PaddingFirstTriangle = 5;
newDropDownButton.PaddingSecondTriangle = -1;
newDropDownButton.Selected = false;
newDropDownButton.SelectedColor = ARA_Colors.ARA_Blue4;
newDropDownButton.Size = new System.Drawing.Size(690, 28);
newDropDownButton.Text = typeName;
newDropDownButton.TextColor = System.Drawing.Color.White;
newDropDownButton.TriangleSize = 18;
newDropDownButton.VerticalAlignment = System.Drawing.StringAlignment.Center;

//Style panel.
newFlowLayoutPanel.Location = new System.Drawing.Point(0, 40);
newFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
newFlowLayoutPanel.Name = "addRiskToProjectPanel" + typeName;
//newFlowLayoutPanel.Size = new System.Drawing.Size(750, 100);
newFlowLayoutPanel.Visible = false;
newFlowLayoutPanel.AutoSize = true;

//Add panels to addRiskToProject content panel.
parentPanel.Controls.Add(newDropDownButton);
this.createTypeNameRiskCountText(parentPanel,groupName , typeName);
parentPanel.Controls.Add(newFlowLayoutPanel);
//Connect panel to button.
newDropDownButton.setConnectedPanel(newFlowLayoutPanel);

//Return the button
return newDropDownButton;
}

private void createGroupNameRiskCountText(string groupName)
{
ARA_Text newText = new ARA_Text();
//Execute procedure to get risk count.
DataRow risksInProjectRow = this.get_Risks_In_Project_GroupTableAdapter.GetData(this.projectID, groupName).Rows[0];

//Style the text.
newText.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
newText.BackgroundColor = ARA_Colors.ARA_Gray1;
newText.ForeColor = System.Drawing.Color.White;
newText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
newText.Location = new System.Drawing.Point(685, 37);
newText.Margin = new System.Windows.Forms.Padding(0);
newText.Name = "addRisksToProjectText" + groupName;
newText.Size = new System.Drawing.Size(60, 37);
newText.Text = risksInProjectRow["RisksInProjectGroup"] + "/" + risksInProjectRow["RisksInGroup"];
newText.VerticalAlignment = System.Drawing.StringAlignment.Center;

//Add it to addRisksToProjectPanelContent controls.
this.addRiskToProjectPanelContent.Controls.Add(newText);
}

private void createTypeNameRiskCountText(FlowLayoutPanel parentPanel, string groupName, string typeName)
{
ARA_Text newText = new ARA_Text();
//Execute procedure to get risk count.
DataRow risksInProjectRow = this.get_Risks_In_Project_TypeTableAdapter.GetData(this.projectID, groupName, typeName).Rows[0];

//Style the text.
newText.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
newText.BackgroundColor = ARA_Colors.ARA_Gray1;
newText.ForeColor = System.Drawing.Color.White;
newText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
newText.Location = new System.Drawing.Point(685, 37);
newText.Margin = new System.Windows.Forms.Padding(0);
newText.Name = "addRisksToProjectText" + groupName + typeName;
newText.Size = new System.Drawing.Size(60, 28);
newText.Text = risksInProjectRow["RisksInProjectGroup"] + "/" + risksInProjectRow["RisksInGroup"];
newText.VerticalAlignment = System.Drawing.StringAlignment.Center;

//Add it to the parent panel.
parentPanel.Controls.Add(newText);
}

private void createRiskIdText(FlowLayoutPanel parentPanel, string riskID)
{
ARA_Text newText = new ARA_Text();

newText.BackgroundColor = System.Drawing.Color.White;
newText.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 4F);
newText.ForeColor = System.Drawing.Color.Black;
newText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
newText.Location = new System.Drawing.Point(0, 65);
newText.Margin = new System.Windows.Forms.Padding(0);
newText.Name = "addRisksToProjectTextID" + riskID;
newText.Size = new System.Drawing.Size(60, 24);
newText.Text = "ID " + riskID;
newText.VerticalAlignment = System.Drawing.StringAlignment.Center;

parentPanel.Controls.Add(newText);
}

private void createRiskDescriptionText(FlowLayoutPanel parentPanel, int riskID, string description, string InProject)
{
ARA_Text newText = new ARA_Text();

newText.BackgroundColor = InProject == "1" ? ARA_Colors.ARA_Green : System.Drawing.Color.White;
newText.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 4F);
newText.HorizontalAlignment = System.Drawing.StringAlignment.Near;
newText.Location = new System.Drawing.Point(111, 65);
newText.Margin = new System.Windows.Forms.Padding(0);
newText.Size = new System.Drawing.Size(690, 24);
newText.Name = "addRisksToProjectTextID" + description;
newText.Text = description;
newText.Click += delegate (object o, System.EventArgs e)
{
ARA_Events.onAddRiskToProjectEvent(o, this.projectID, riskID);
};

parentPanel.Controls.Add(newText);
}

private void addRiskToProject(object sender,AddRiskToProjectEvent e)
{
ARA_Text clickedText = (ARA_Text)sender;
if(clickedText != null)
{
//Is the risk already in the project?
if(clickedText.BackgroundColor == ARA_Colors.ARA_Green)
{
//Change its color and remove it from the database.
clickedText.BackgroundColor = Color.White;
this.queriesTableAdapter1.Delete_From_ProjectRisks(e.projectID, e.riskID);
}
else
{
//Change its color and add a new risk to the database.
clickedText.BackgroundColor = ARA_Colors.ARA_Green;
this.queriesTableAdapter1.Insert_In_ProjectRisks(e.projectID, e.riskID);
}
}

clickedText.Invalidate();
updateAmountOfRisksInProject();
}

//Ugly function for updating al the text boxes with the amount of risks.
private void updateAmountOfRisksInProject()
{
foreach (ARA_DropDownButton control in this.addRiskToProjectPanelContent.Controls.OfType<ARA_DropDownButton>())
{
string groupName = control.Text;
int buttonIndex = this.addRiskToProjectPanelContent.Controls.GetChildIndex(control);

ARA_Text groupText = (ARA_Text)this.addRiskToProjectPanelContent.Controls[buttonIndex + 1];
DataRow risksInProjectRow = this.get_Risks_In_Project_GroupTableAdapter.GetData(this.projectID, groupName).Rows[0];
groupText.Text = risksInProjectRow["RisksInProjectGroup"] + "/" + risksInProjectRow["RisksInGroup"];
groupText.Invalidate();
Debug.WriteLine(groupName);
foreach (ARA_DropDownButton subControl in this.addRiskToProjectPanelContent.Controls[buttonIndex + 2].Controls.OfType<ARA_DropDownButton>())
{
string typeName = subControl.Text;
int subButtonIndex = this.addRiskToProjectPanelContent.Controls[buttonIndex + 2].Controls.GetChildIndex(subControl);
Debug.WriteLine(typeName);
ARA_Text subGroupText = (ARA_Text)this.addRiskToProjectPanelContent.Controls[buttonIndex + 2].Controls[subButtonIndex + 1];
DataRow risksInProjectGroupRow = this.get_Risks_In_Project_TypeTableAdapter.GetData(this.projectID, groupName, typeName).Rows[0];
subGroupText.Text = risksInProjectGroupRow["RisksInProjectGroup"] + "/" + risksInProjectGroupRow["RisksInGroup"];
subGroupText.Invalidate();
}
}
}
*/
    }
}
