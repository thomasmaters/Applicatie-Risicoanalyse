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
    public partial class ARA_EditRiskExposedPersons : UserControl
    {
        private bool hasControlBeenChanged = false;

        public ARA_EditRiskExposedPersons()
        {
            InitializeComponent();
        }

        public bool HasControlBeenChanged
        {
            get
            {
                return hasControlBeenChanged;
            }

            set
            {
                hasControlBeenChanged = value;
            }
        }

        //Adds persons from database in to control.
        public void setControlData(DataView controlData, int riskDataID)
        {
            this.flowLayoutPanel1.Controls.Clear();
            hasControlBeenChanged = false;

            foreach (DataRowView row in controlData)
            {
                //Create a new checkbox.
                CheckBox checkbox = new CheckBox();

                //Style the checkbox.
                checkbox.Text = row["PersonDescription"].ToString();
                checkbox.AutoSize = true;
                checkbox.Font = new System.Drawing.Font("Gotham Light", 12F, System.Drawing.FontStyle.Italic);
                checkbox.Checked = row["InProject"].ToString() == "1";

                //Add it to the flowLayoutPanel.
                this.flowLayoutPanel1.Controls.Add(checkbox);

                checkbox.CheckStateChanged += delegate (object sender, EventArgs e)
                {
                    if(checkbox.Checked == true)
                    {
                        this.tbl_ExposedPersons_In_RiskTableAdapter.Insert(Int32.Parse(row["ExposedPersonID"].ToString()), riskDataID);
                    }
                    else
                    {
                        this.tbl_ExposedPersons_In_RiskTableAdapter.Delete(Int32.Parse(row["ExposedPersonID"].ToString()), riskDataID);
                    }
                };
            }
        }

        private void tbl_ExposedPersons_In_RiskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ExposedPersons_In_RiskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lG_Analysis_DatabaseDataSet);

        }
    }
}
