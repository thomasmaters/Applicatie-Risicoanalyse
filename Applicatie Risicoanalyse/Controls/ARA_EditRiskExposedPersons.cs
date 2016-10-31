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
    public partial class ARA_EditRiskExposedPersons : UserControl
    {
        private bool hasControlBeenChanged = false;
        public EventHandler<ExposedPersonChangedEvent> exposedPersonChangedEventHandler;
        public Color IndicatorRectangleColor
        {
            get
            {
                return this.exposedPersonsRectangleIndicator.BackgroundColor;
            }
            set
            {
                this.exposedPersonsRectangleIndicator.BackgroundColor = value;
                this.exposedPersonsRectangleIndicator.Invalidate();
            }
        }

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
            //Reset form.
            this.flowLayoutPanel1.Controls.Clear();
            this.exposedPersonChangedEventHandler = null;
            hasControlBeenChanged = false;

            //Add checkboxes from database.
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
                    setControlHasBeenChanged();

                    if (exposedPersonChangedEventHandler != null)
                    {
                        exposedPersonChangedEventHandler(checkbox, new ExposedPersonChangedEvent((Int32)row["ExposedPersonID"],checkbox.CheckState));
                    }
                };
            }
        }

        private void setControlHasBeenChanged()
        {
            hasControlBeenChanged = false;
            foreach (CheckBox control in this.flowLayoutPanel1.Controls.OfType<CheckBox>())
            {
                if (control.CheckState == CheckState.Checked)
                {
                    hasControlBeenChanged = true;
                    break;
                }
            }
        }
    }
}
