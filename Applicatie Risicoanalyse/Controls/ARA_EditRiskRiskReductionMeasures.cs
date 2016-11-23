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
    public partial class ARA_EditRiskRiskReductionMeasures : UserControl
    {
        private bool includeMeasuresWithNoGroup = false;
        private bool hasControlBeenChanged = false;
        public EventHandler<MeasureItemChangedEvent> itemCheckEventHandler;
        public EventHandler<EventArgs> reductionMesureInfoChanged;

        public Color IndicatorRectangleColor
        {
            get
            {
                return this.riskReductionRectangleIndicator.BackgroundColor;
            }
            set
            {
                this.riskReductionRectangleIndicator.BackgroundColor = value;
                this.riskReductionRectangleIndicator.Invalidate();
            }
        }

        public bool HasControlBeenChanged
        {
            get
            {
                if(hasControlBeenChanged)
                {
                    return true;
                }
                foreach(ARA_EditRiskRiskReductionMeasuresItem item in this.flowLayoutPanel1.Controls.OfType<ARA_EditRiskRiskReductionMeasuresItem>())
                {
                    if (item.HasControlBeenChanged)
                    {
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

        public ARA_EditRiskRiskReductionMeasures()
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

        public bool IncludeMeasuresWithNoGroup
        {
            get
            {
                return includeMeasuresWithNoGroup;
            }
            set
            {
                includeMeasuresWithNoGroup = value;
            }
        }

        /// <summary>
        /// Adds RiskReductionMesureItems to this form based on possible risk reduction measures in the database.
        /// </summary>
        /// <param name="controlData">RiskReductions in riskData.</param>
        public void setControlData(DataView controlData)
        {
            try
            {
                //Remove previously added controls.
                this.itemCheckEventHandler = null;
                this.reductionMesureInfoChanged = null;
                for (int i = this.flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
                {
                    if (this.flowLayoutPanel1.Controls[i] is ARA_EditRiskRiskReductionMeasuresItem || this.flowLayoutPanel1.Controls[i] is CheckBox)
                    {
                        this.flowLayoutPanel1.Controls.RemoveAt(i);
                    }
                }

                //Get all unique groupnames.
                DataTable distinctGroupNamesDataTable = controlData.ToTable(true, "MeasureGroup");
                DataView distinctGroupNamesDataView = new DataView(distinctGroupNamesDataTable);

                //Create subgroups for each group.
                foreach (DataRowView row in distinctGroupNamesDataView)
                {
                    if (row["MeasureGroup"] != DBNull.Value)
                    {
                        controlData.RowFilter = "MeasureGroup = '" + row["MeasureGroup"].ToString() + "'";
                        ARA_EditRiskRiskReductionMeasuresItem riskReductionMesureItem = new ARA_EditRiskRiskReductionMeasuresItem();

                        riskReductionMesureItem.setControlData(controlData);
                        riskReductionMesureItem.itemCheckEventHandler += riskReductionMesureItemChecked;

                        this.flowLayoutPanel1.Controls.Add(riskReductionMesureItem);
                    }
                }

                //Do we want to add reductionMeasures with no group?
                if (this.includeMeasuresWithNoGroup)
                {
                    addRiskReductionMeasuresWithNoGroup(controlData);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds checkboxes for riskReductionMeasures with no group assigned to them.
        /// </summary>
        /// <param name="controlData">DataView representing all the risk reduction measures.</param>
        private void addRiskReductionMeasuresWithNoGroup(DataView controlData)
        {
            //Set a new rowFilter to find NULL values.
            controlData.RowFilter = "MeasureGroup IS NULL";

            //Add checkboxes for items that are not in a group.
            foreach (DataRowView row in controlData)
            {
                if (row["MeasureGroup"] == DBNull.Value)
                {
                    //Create a new checkbox and style it a little.
                    CheckBox riskReductionMeasureItem = new CheckBox();
                    riskReductionMeasureItem.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 5);
                    riskReductionMeasureItem.Text = row["MeasureSubGroup"].ToString();
                    riskReductionMeasureItem.AutoSize = true;
                    riskReductionMeasureItem.Checked = row["InProject"].ToString() == "1";

                    //Add an event when its checkedStateChanges.
                    riskReductionMeasureItem.CheckStateChanged += delegate (object sender, EventArgs e)
                    {
                        riskReductionMesureItemChecked(sender, new MeasureItemChangedEvent((Int32)row["MeasureID"], riskReductionMeasureItem.CheckState));
                    };

                    //Add it to the flow layout panel.
                    this.flowLayoutPanel1.Controls.Add(riskReductionMeasureItem);
                }
            }
        }

        /// <summary>
        /// Sets the text in the other riskReductionMeasures textbox.
        /// </summary>
        /// <param name="riskReductionInfo">String to set the riskReductionTextBox text too.</param>
        public void setRiskReductionInfo(string riskReductionInfo)
        {
            this.arA_TextBox1.Text = riskReductionInfo;
        }

        /// <summary>
        /// Increases the size of the checkboxList when a new checkbox is added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            this.riskReductionRectangleIndicator.Size = new Size(this.riskReductionRectangleIndicator.Width, this.flowLayoutPanel1.Size.Height - 10);
        }

        /// <summary>
        /// Triggers an event that a textBox has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.hasControlBeenChanged = arA_TextBox1.Text != "";
            if(reductionMesureInfoChanged != null)
            {
                reductionMesureInfoChanged(sender, e);
            }
        }

        /// <summary>
        /// Trigger an event when the user checks a checkbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void riskReductionMesureItemChecked(object sender, MeasureItemChangedEvent e)
        {
            if(itemCheckEventHandler != null)
            {
                this.itemCheckEventHandler(sender, e);
            }
        }
    }
}
