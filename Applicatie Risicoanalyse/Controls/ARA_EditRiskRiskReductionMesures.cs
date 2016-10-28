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
    public partial class ARA_EditRiskRiskReductionMesures : UserControl
    {
        private bool hasControlBeenChanged = false;
        public EventHandler<MesureItemChangedEvent> itemCheckEventHandler;
        public EventHandler<EventArgs> reductionMesureInfoChanged;

        public bool HasControlBeenChanged
        {
            get
            {
                if(hasControlBeenChanged)
                {
                    return true;
                }
                foreach(ARA_EditRiskRiskReductionMesuresItem item in this.flowLayoutPanel1.Controls.OfType<ARA_EditRiskRiskReductionMesuresItem>())
                {
                    if (item.HasControlBeenChanged)
                    {
                        this.hasControlBeenChanged = true;
                        return true;
                    }
                }
                return false;
            }

            set
            {
                hasControlBeenChanged = value;
            }
        }

        public string ReductionMesureInfo
        {
            get
            {
                return "" + this.arA_TextBox1.Text;
            }
        }

        public ARA_EditRiskRiskReductionMesures()
        {
            InitializeComponent();
        }

        public string TitleText
        {
            get
            {
                return this.HarzardTextTitle.Text;
            }

            set
            {
                this.HarzardTextTitle.Text = value;
            }
        }

        public void setControlData(DataView controlData)
        {
            //Remove previously added controls.
            this.itemCheckEventHandler = null;
            this.reductionMesureInfoChanged = null;
            for (int i = this.flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
            {
                if (this.flowLayoutPanel1.Controls[i] is ARA_EditRiskRiskReductionMesuresItem)
                {
                    this.flowLayoutPanel1.Controls.RemoveAt(i);
                }
            }

            //Get all unique groupnames.
            DataTable distinctGroupNamesDataTable = controlData.ToTable(true, "MesureGroup");
            DataView  distinctGroupNamesDataView = new DataView(distinctGroupNamesDataTable);

            //Create subgroups for each group.
            foreach (DataRowView row in distinctGroupNamesDataView)
            {
                controlData.RowFilter = "MesureGroup = '" + row["MesureGroup"].ToString()+ "'";
                ARA_EditRiskRiskReductionMesuresItem riskReductionMesureItem = new ARA_EditRiskRiskReductionMesuresItem();

                riskReductionMesureItem.setControlData(controlData);
                riskReductionMesureItem.itemCheckEventHandler += riskReductionMesureItemChecked;

                this.flowLayoutPanel1.Controls.Add(riskReductionMesureItem);
            }
        }

        public void setRiskReductionInfo(string riskReductionInfo)
        {
            this.arA_TextBox1.Text = riskReductionInfo;
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            this.arA_Rectangle2.Size = new Size(this.arA_Rectangle2.Width, this.flowLayoutPanel1.Size.Height - 10);
        }

        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.hasControlBeenChanged = true;
            if(reductionMesureInfoChanged != null)
            {
                reductionMesureInfoChanged(sender, e);
            }
        }

        private void riskReductionMesureItemChecked(object sender, MesureItemChangedEvent e)
        {
            if(itemCheckEventHandler != null)
            {
                this.itemCheckEventHandler(sender, e);
            }
        }
    }
}
