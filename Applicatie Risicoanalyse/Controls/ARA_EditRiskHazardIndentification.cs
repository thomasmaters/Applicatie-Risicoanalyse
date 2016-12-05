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

        /// <summary>
        /// Set control data for a specific riskdataid.
        /// </summary>
        /// <param name="riskDataID"></param>
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
                this.hazardComboBoxDangerGroup.DisplayMember = "DangerGroupName";
                this.hazardComboBoxDangerGroup.ValueMember = "DangerID";
                this.hazardComboBoxDangerGroup.DataSource = dangerView;
                this.hazardComboBoxDangerGroup.SelectedValue = riskDataRow["DangerID"];

                //Set dropdownbox values and select value.
                DataView dangerSourceView = new DataView(this.tbl_Danger_SourceTableAdapter.GetData(), "", "", DataViewRowState.CurrentRows);
                dangerSourceView.RowFilter = string.Format("DangerID = {0}", this.hazardComboBoxDangerGroup.SelectedValue);
                this.hazardComboBoxDangerSource.DisplayMember = "DangerSourceName";
                this.hazardComboBoxDangerSource.ValueMember = "DangerSourceID";
                this.hazardComboBoxDangerSource.DataSource = dangerSourceView;
                this.hazardComboBoxDangerSource.SelectedValue = riskDataRow["DangerSourceID"];

                //Add event for changing grouping when the first dropdownbox changes.
                this.hazardComboBoxDangerGroup.SelectedIndexChanged += delegate (object sender, EventArgs e)
                {
                    dangerSourceView.RowFilter = string.Format("DangerID = {0}", this.hazardComboBoxDangerGroup.SelectedValue);
                };


                //Add eventhandlers for update to harzard result.
                this.hazardComboBoxDangerGroup.SelectedIndexChanged -= updateHazardResultText;
                this.hazardComboBoxDangerSource.SelectedIndexChanged -= updateHazardResultText;
                this.hazardComboBoxDangerGroup.SelectedIndexChanged += updateHazardResultText;
                this.hazardComboBoxDangerSource.SelectedIndexChanged += updateHazardResultText;
                
                updateHazardResultText(new object(), new EventArgs());
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Updates the hazard consequences text when the dangersource changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateHazardResultText(object sender, EventArgs e)
        {
            //Did we select something?
            if(this.hazardComboBoxDangerSource.SelectedValue == null)
            {
                throw new ArgumentNullException("Combobox SelectedValue","Some data in the database might be corrupted, could not set ComboBox's selected value.");
            }

            //Set text control text and update it.
            DataRow selectedDangerSourceRow = this.tbl_Danger_SourceTableAdapter.GetData().FindByDangerSourceID((Int32)hazardComboBoxDangerSource.SelectedValue);

            //Do we got a danger consequence?
            if (selectedDangerSourceRow["DangerResultID1"] != DBNull.Value)
            {
                DataRow row = this.tbl_Danger_ResultTableAdapter.GetData().FindByDangerResultID((Int32)selectedDangerSourceRow["DangerResultID1"]);
                this.HazardTextConsequence1.Text = row["DangerResultName"].ToString();
            }
            else
            {
                this.HazardTextConsequence1.Text = "";
            }

            //Do we got our second danger consequence?
            if(selectedDangerSourceRow["DangerResultID2"] != DBNull.Value)
            {
                DataRow row = this.tbl_Danger_ResultTableAdapter.GetData().FindByDangerResultID((Int32)selectedDangerSourceRow["DangerResultID1"]);
                this.HazardTextConsequence2.Text = row["DangerResultName"].ToString();
            }
            else
            {
                this.HazardTextConsequence2.Text = "";
            }

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
            this.hasControlBeenChanged = (arA_TextBox1.Text.Length > ARA_Constants.hazardSituationMinimalTextLength && arA_TextBox2.Text.Length > ARA_Constants.hazardEventMinimalTextLength);

            //Trigger eventhandlers.
            if (dangerChangedEventHandler != null)
            {
                dangerChangedEventHandler
                (
                    new object(), 
                    new DangerChangedEvent((Int32)this.hazardComboBoxDangerGroup.SelectedValue, (Int32)this.hazardComboBoxDangerSource.SelectedValue, this.arA_TextBox1.Text, this.arA_TextBox2.Text)
                );
            }
        }
    }
}
