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

            //Special scaling for the searchdatagrid.
            this.addRiskToProjectSearchDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 3);
            this.addRiskToProjectSearchDataGrid.DefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 5);
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

        /// <summary>
        /// Adds component types to a component group.
        /// </summary>
        /// <param name="parentGroup"></param>
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
                        parentGroup.DropDownButtonText,
                        datarow["TypeName"].ToString(), 
                        risksInTypeDataRow["RisksInProjectGroup"].ToString() != risksInTypeDataRow["RisksInGroup"].ToString()
                    );

                    //Let the application know we added a risk.
                    ARA_Events.triggerRiskAddedToProjectEvent(this.projectID);
                };
            }
        }

        /// <summary>
        /// Add risks in component type into the component type listGroup.
        /// </summary>
        /// <param name="parentGroup"></param>
        /// <param name="parentType"></param>
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
                    listItem.Tag = Image.FromStream(stream);
                }

                //Set text of listItem.
                listItem.TextFirstControl = "ID " + datarow["RiskID"].ToString();
                listItem.TextSecondControl = datarow["HazardSituation"].ToString();
                listItem.BackgroundColor = datarow["InProject"].ToString() == "1" ? ARA_Colors.ARA_Green : System.Drawing.Color.White;

                //Add let it execute an event on click.
                listItem.Click += delegate (object o, System.EventArgs e)
                {
                    ARA_Events.triggerAddRiskToProjectEvent(o, this.projectID, Int32.Parse(datarow["RiskID"].ToString()));
                };
                listItem.addFunction(delegate ()
                {
                    listItem.BackgroundColor = this.is_Risk_In_ProjectTableAdapter.GetData(this.projectID, Int32.Parse(datarow["RiskID"].ToString())).Rows[0]["InProject"].ToString() == "1" ? ARA_Colors.ARA_Green : Color.White;
                });
            }
        }

        /// <summary>
        /// Style the listGroup as a component group control.
        /// </summary>
        /// <param name="listGroup"></param>
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

            listGroup.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize));
        }

        /// <summary>
        /// Style a component type listGroup as a componentType listgroup.
        /// </summary>
        /// <param name="listParent"></param>
        /// <param name="listGroup"></param>
        private void styleListGroupAsType(ARA_ListGroup listParent ,ARA_ListGroup listGroup)
        {
            listGroup.ARA_ListGroupDropDownButton.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            listGroup.ARA_ListGroupText.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            listGroup.BackColor = Color.White;
            listGroup.BackgroundColor = Color.White;
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
            listGroup.TextColor = Color.Black;

            listParent.addChild(listGroup);
            listParent.addControlToDropDownButton(listGroup);
            listGroup.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize/ARA_Constants.noScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize));
        }

        /// <summary>
        /// Add style for the listItems.
        /// </summary>
        /// <param name="listParent"></param>
        /// <param name="listItem"></param>
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
            listItem.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize));
        }

        /// <summary>
        /// Handler when the user has added a risk to the project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRiskToProject(object sender, AddRiskToProjectEvent e)
        {
            if(e.projectID != this.projectID)
            {
                return;
            }
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
                //Update the text.
                clickedText.Invalidate();
            }

            //Let the application know we added a risk.
            ARA_Events.triggerRiskAddedToProjectEvent(this.projectID);
        }

        private void ARA_AddRisksToProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Component_Type' table. You can move, or remove it, as needed.
            this.tbl_Component_TypeTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Component_Type);
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Component_Group' table. You can move, or remove it, as needed.
            this.tbl_Component_GroupTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Component_Group);
            this.onRiskProjectOverviewLoad();
        }

        /// <summary>
        /// Handler when the user wants to search to risk collection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSearchBarTextChanged(object sender, EventArgs e)
        {
            int tempScrollPosition = this.addRiskToProjectSearchDataGrid.FirstDisplayedScrollingRowIndex;

            this.addRiskToProjectSearchDataGrid.Visible = this.addRiskToProjectSearchTextBox.Text != "";
            this.addRiskToProjectSearchDataGrid.DataSource = this.search_Risks_In_ProjectTableAdapter.GetData(this.projectID, this.addRiskToProjectSearchTextBox.Text);
            this.addRiskToProjectSearchDataGrid.Refresh();

            if(tempScrollPosition != -1 && tempScrollPosition < this.addRiskToProjectSearchDataGrid.Rows.Count)
            {
                this.addRiskToProjectSearchDataGrid.FirstDisplayedScrollingRowIndex = tempScrollPosition;
            }
        }

        /// <summary>
        /// Add style for the datagrid whether the risk is in the project or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onDataGridRowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in this.addRiskToProjectSearchDataGrid.Rows)
            { 
                //Is risk in the project.
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

        /// <summary>
        /// Deletes or adds a risk to the project directly from the searchbar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onDataGridRowDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
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

                //Let the application know we added a risk.
                ARA_Events.triggerRiskAddedToProjectEvent(this.projectID);
            }
        }

        /// <summary>
        /// Clear the selection of the datagrid when the user tries to select something.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onDataGridSelectionChanged(object sender, EventArgs e)
        {
            this.addRiskToProjectSearchDataGrid.ClearSelection();
        }
    }
}
