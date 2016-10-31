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
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_EditRiskRiskReductionMesuresItem : UserControl
    {
        private bool hasControlBeenChanged = false;
        public EventHandler<MesureItemChangedEvent> itemCheckEventHandler;

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

        public ARA_EditRiskRiskReductionMesuresItem()
        {
            InitializeComponent();
        }

        public void setControlData(DataView controlData)
        {
            this.itemCheckEventHandler = null;
            this.hasControlBeenChanged = false;
            this.checkedListBox1.Items.Clear();

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
                this.checkedListBox1.Size = new Size(this.checkedListBox1.Size.Width, this.checkedListBox1.GetItemRectangle(0).Height * checkedListBox1.Items.Count);
            }

            //Delegate for mass removal of reduction mesures from riskdata.
            checkedListBox1.ItemCheck += delegate (object sender, ItemCheckEventArgs e)
            {
                if (itemCheckEventHandler != null)
                {
                    controlData.RowFilter = "MesureGroup ='" + this.checkBox1.Text + "'";

                    //Set flag so the control knows it has been changed.
                    this.hasControlBeenChanged = !(this.checkedListBox1.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked) || e.NewValue == CheckState.Checked;

                    //Trigger eventhandler.
                    itemCheckEventHandler(sender, new MesureItemChangedEvent(Int32.Parse(controlData[e.Index]["MesureID"].ToString()), e.NewValue));
                }
            };

            //Delegtate for adding/removing reduction mesure from riskdata.
            this.checkBox1.CheckStateChanged += delegate (object sender, EventArgs e)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i) == true)
                    {
                        checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            };
        }

        //Remove ugly selection color.
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkedListBox1.ClearSelected();
        }

        //Show or hide when groupcheckbox is checked.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Hide or show checkedlistbox on checkstate of checkbox1.
            this.checkedListBox1.Visible = this.checkBox1.Checked;
        }
    }
}
