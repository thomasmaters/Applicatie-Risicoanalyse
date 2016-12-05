using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_NewRiskRiskGrouping : UserControl
    {
        private bool hasControlBeenChanged = false;
        public EventHandler<RiskComponentGroupAndTypeChangedEvent> riskComponentGroupAndTypeChangedEventHandler;

        public ARA_NewRiskRiskGrouping()
        {
            InitializeComponent();
        }

        public Color IndicatorRectangleColor
        {
            get
            {
                return this.riskGroupingRectangleIndicator.BackgroundColor;
            }
            set
            {
                this.riskGroupingRectangleIndicator.BackgroundColor = value;
                this.riskGroupingRectangleIndicator.Invalidate();
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

        private void tbl_Component_GroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_Component_GroupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lG_Analysis_DatabaseDataSet);

        }

        /// <summary>
        /// Sets the datafor all the controls and handler when they change.
        /// </summary>
        public void setControlData()
        {
            //Set componentgroupe combobox datasource.
            DataView componentGroupView = new DataView(this.tbl_Component_GroupTableAdapter.GetData(), "", "", DataViewRowState.CurrentRows);

            this.riskGroupingComboBoxComponentGroup.DisplayMember = "GroupName";
            this.riskGroupingComboBoxComponentGroup.ValueMember = "GroupName";
            this.riskGroupingComboBoxComponentGroup.DataSource = componentGroupView;

            //Set componenttype combobox datasource.
            DataView componentTypeView = new DataView(this.tbl_Component_TypeTableAdapter.GetData(), "", "", DataViewRowState.CurrentRows);
            componentTypeView.RowFilter = string.Format("GroupName = '{0}'", this.riskGroupingComboBoxComponentGroup.SelectedValue);

            this.riskGroupingComboBoxComponentType.DisplayMember = "TypeName";
            this.riskGroupingComboBoxComponentType.ValueMember = "TypeName";
            this.riskGroupingComboBoxComponentType.DataSource = componentTypeView;

            //Add event for changing grouping when the first dropdownbox changes.
            this.riskGroupingComboBoxComponentGroup.SelectedIndexChanged += delegate (object sender, EventArgs e)
            {
                //Apply filter
                componentTypeView.RowFilter = string.Format("GroupName = '{0}'", this.riskGroupingComboBoxComponentGroup.SelectedValue);

                //Trigger update event.
                this.hasControlBeenChanged = true;
                if (this.riskComponentGroupAndTypeChangedEventHandler != null && this.riskGroupingComboBoxComponentType.SelectedValue != null)
                {
                    riskComponentGroupAndTypeChangedEventHandler(sender, new RiskComponentGroupAndTypeChangedEvent(this.riskGroupingComboBoxComponentGroup.SelectedValue.ToString(), this.riskGroupingComboBoxComponentType.SelectedValue.ToString()));
                }
            };

            this.hasControlBeenChanged = false;
        }

        private void riskGroupingComboBoxComponentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hasControlBeenChanged = true;
            if (this.riskComponentGroupAndTypeChangedEventHandler != null)
            {
                riskComponentGroupAndTypeChangedEventHandler(sender, new RiskComponentGroupAndTypeChangedEvent(this.riskGroupingComboBoxComponentGroup.SelectedValue.ToString(), this.riskGroupingComboBoxComponentType.SelectedValue.ToString()));
            }
        }
    }
}
