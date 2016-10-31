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
    public partial class ARA_EditRiskHazardIndentification : UserControl
    {
        private bool hasControlBeenChanged = false;
        public EventHandler<DangerChangedEvent> dangerChangedEventHandler;

        public ARA_EditRiskHazardIndentification()
        {
            InitializeComponent();
        }

        public Color IndicatorRectangleColor
        {
            get
            {
                return this.hazardIndentificationRectangleIndicator.BackgroundColor;
            }
            set
            {
                this.hazardIndentificationRectangleIndicator.BackgroundColor = value;
                this.hazardIndentificationRectangleIndicator.Invalidate();
            }
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

        public void setControlData(int riskDataID)
        {
            try
            {
                dangerChangedEventHandler = null;
                hasControlBeenChanged = false;

                //Get risk data
                DataRow riskDataRow = this.tbl_Risk_DataTableAdapter.GetData().FindByRiskDataID(riskDataID);

                //Set textbox text.
                this.arA_TextBox1.Text = riskDataRow["HazardSituation"].ToString();
                this.arA_TextBox2.Text = riskDataRow["HazardEvent"].ToString();

                //Set dropdownbox values and selected value.
                DataView dangerView = new DataView(this.tbl_DangerTableAdapter.GetData(), "", "", DataViewRowState.CurrentRows);
                this.comboBox1.DisplayMember = "DangerGroupName";
                this.comboBox1.ValueMember = "DangerID";
                this.comboBox1.DataSource = dangerView;
                this.comboBox1.SelectedValue = riskDataRow["DangerID"];

                //Set dropdownbox values and select value.
                DataView dangerSourceView = new DataView(this.tbl_Danger_SourceTableAdapter.GetData(), "", "", DataViewRowState.CurrentRows);
                dangerSourceView.RowFilter = string.Format("DangerID = {0}", this.comboBox1.SelectedValue);
                this.comboBox2.DisplayMember = "DangerSourceName";
                this.comboBox2.ValueMember = "DangerSourceID";
                this.comboBox2.DataSource = dangerSourceView;
                this.comboBox2.SelectedValue = riskDataRow["DangerSourceID"];

                //Add event for changing grouping when the first dropdownbox changes.
                this.comboBox1.SelectedIndexChanged += delegate (object sender, EventArgs e)
                {
                    dangerSourceView.RowFilter = string.Format("DangerID = {0}", this.comboBox1.SelectedValue);
                };

                //Add eventhandlers for update to harzard result.
                this.comboBox1.SelectedIndexChanged -= updateHazardResultText;
                this.comboBox2.SelectedIndexChanged -= updateHazardResultText;
                this.comboBox1.SelectedIndexChanged += updateHazardResultText;
                this.comboBox2.SelectedIndexChanged += updateHazardResultText;

                updateHazardResultText(new object(), new EventArgs());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateHazardResultText(object sender, EventArgs e)
        {
            if(this.comboBox2.SelectedValue == null)
            {
                throw new ArgumentNullException("Combobox SelectedValue","Some data in the database might be corrupted, could not set ComboBox's selected value.");
            }
            //Set text control text and update it.
            DataView dangerResultView = new DataView(this.tbl_Danger_ResultTableAdapter.GetData(), "", "", DataViewRowState.CurrentRows);
            dangerResultView.RowFilter = string.Format("DangerSourceID = {0}", this.comboBox2.SelectedValue);

            this.HazardTextConsequence1.Text = dangerResultView.Count > 0 ? dangerResultView[0]["DangerResultName"].ToString() : "";
            this.HazardTextConsequence2.Text = dangerResultView.Count > 1 ? dangerResultView[1]["DangerResultName"].ToString() : "";

            this.HazardTextConsequence1.Invalidate();
            this.HazardTextConsequence2.Invalidate();

            //Let the parent know somethings have changed.
            onDangerItemChanged();
        }

        private void arA_TextBox1_TextChanged(object sender, EventArgs e)
        {
            onDangerItemChanged();
        }

        private void arA_TextBox2_TextChanged(object sender, EventArgs e)
        {
            onDangerItemChanged();
        }

        private void onDangerItemChanged()
        {
            //Check if we can say the control has been changed.
            if (arA_TextBox1.Text.Length > ARA_Globals.HazardSituationMinimalTextLength && arA_TextBox2.Text.Length > ARA_Globals.HazardEventMinimalTextLength)
            {
                this.hasControlBeenChanged = true;
            }

            //Trigger eventhandlers.
            if (dangerChangedEventHandler != null)
            {
                dangerChangedEventHandler
                (
                    new object(), 
                    new DangerChangedEvent((Int32)this.comboBox1.SelectedValue, (Int32)this.comboBox2.SelectedValue, this.arA_TextBox1.Text, this.arA_TextBox2.Text)
                );
            }
        }
    }
}
