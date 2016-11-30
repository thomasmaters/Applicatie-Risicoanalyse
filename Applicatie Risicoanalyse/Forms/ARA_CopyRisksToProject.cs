using Applicatie_Risicoanalyse.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_CopyRisksToProject : Form
    {
        private int projectID = -1;
        public ARA_CopyRisksToProject(int projectID)
        {
            this.projectID = projectID;
            InitializeComponent();

            //Scale form.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            this.arA_Text1.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 3);
            this.copyRisksComboBoxProjects.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 3);
            this.copyRisksDataGrid.DefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 5);
            this.copyRisksDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 3);
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis' table. You can move, or remove it, as needed.
            this.tbl_Risk_AnalysisTableAdapter.Fill(this.lG_Analysis_DatabaseDataSet.Tbl_Risk_Analysis);
        }

        /// <summary>
        /// Handler when the user selects an other project to copy risks from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Did the user select something?
            if(this.copyRisksComboBoxProjects.SelectedValue != null && this.copyRisksComboBoxProjects.SelectedIndex != -1)
            {
                //Change datasource if we changed our combobox selection.
                this.copyRisksDataGrid.DataSource = this.get_Risks_With_RiskData_In_ProjectTableAdapter.GetData((Int32)this.copyRisksComboBoxProjects.SelectedValue);

                //Recolor datagrid items.
                addStyleToDataGrid();

                //Clear the selection.
                this.copyRisksDataGrid.ClearSelection();
            }
        }

        /// <summary>
        /// Handler when the user wants to add the selected risks to the current opend project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_Button1_Click(object sender, EventArgs e)
        {
            //Do we have our selection?
            if(this.copyRisksDataGrid.SelectedRows.Count > 0 && this.copyRisksComboBoxProjects.SelectedValue != null)
            {
                //Loop through selected rows.
                foreach (DataGridViewRow row in this.copyRisksDataGrid.SelectedRows)
                {
                    //Execute procedure to copy risks to another project.
                    this.queriesTableAdapter1.Copy_Risk_From_Project_Into_Project((Int32)row.Cells["riskIDDataGridViewTextBoxColumn"].Value, (Int32)this.copyRisksComboBoxProjects.SelectedValue, this.projectID);
                }

                //Let the user know the added some risks to the current opend project.
                System.Windows.Forms.MessageBox.Show(ARA_Constants.messageBoxSuccesCopiedRisks, ARA_Constants.messageBoxSuccesCopiedRisksHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Adds styling to the datagridview so the user knows wich risks are project specific.
        /// </summary>
        private void addStyleToDataGrid()
        {
            foreach(DataGridViewRow row in this.copyRisksDataGrid.Rows)
            {
                if(row.Cells["projectRiskDataIDDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    row.DefaultCellStyle.BackColor = ARA_Colors.ARA_Blue1;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            addStyleForOutOfDateRisks();
        }

        /// <summary>
        /// Color a the first column in the copyRisksDataGrid if it is not the newest version of the risk.
        /// </summary>
        private void addStyleForOutOfDateRisks()
        {
            foreach (DataGridViewRow row in this.copyRisksDataGrid.Rows)
            {
                if (this.is_Risk_OldTableAdapter.GetData(
                    (Int32)row.Cells["riskIDDataGridViewTextBoxColumn"].Value,
                    (Int32)row.Cells["versionIDDataGridViewTextBoxColumn1"].Value)[0]["IsRiskOld"].ToString() == "1")
                {
                    row.Cells[0].Style.BackColor = ARA_Colors.ARA_Blue5;
                }
                else
                {
                    row.Cells[0].Style.BackColor = Color.White;
                }
            }
        }
    }
}
