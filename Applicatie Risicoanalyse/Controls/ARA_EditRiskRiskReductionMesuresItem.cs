using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_EditRiskRiskReductionMesuresItem : UserControl
    {
        public ARA_EditRiskRiskReductionMesuresItem()
        {
            InitializeComponent();
        }

        public void setControlData(DataView controlData)
        {
            this.checkBox1.Text = controlData[0]["MesureGroup"].ToString();

            this.checkedListBox1.Items.Clear();
            //Fill checklistbox with items.
            foreach(DataRowView row in controlData)
            {
                this.checkedListBox1.Items.Add(row["MesureSubGroup"]);
                //Is this option in riskData.
                if (row["InProject"].ToString() == "1")
                {
                    this.checkedListBox1.SetItemChecked(this.checkedListBox1.Items.Count - 1, true);
                    this.checkBox1.Checked = true;
                    this.checkedListBox1.Visible = true;
                }

                //Scale checkedlistbox height when we add an item.
                this.checkedListBox1.ClientSize = new Size(this.checkedListBox1.ClientSize.Width, this.checkedListBox1.GetItemRectangle(0).Height * checkedListBox1.Items.Count);
            }
        }

        //Remove ugly selection color.
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkedListBox1.ClearSelected();
        }

        //Show or hide when groupcheckbox is checked.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked == true)
            {
                this.checkedListBox1.Visible = true;
            }
            else
            {
                this.checkedListBox1.Visible = false;
            }
        }
    }
}
