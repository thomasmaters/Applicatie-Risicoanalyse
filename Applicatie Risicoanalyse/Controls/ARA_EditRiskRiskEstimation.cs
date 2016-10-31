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
    public partial class ARA_EditRiskRiskEstimation : UserControl
    {
        private bool hasControlBeenChanged = false;
        public EventHandler<RiskEstimationChangedEvent> riskEstimationEvenHandler;

        public Color IndicatorRectangleColor
        {
            get
            {
                return this.riskEstimationRectangleIndicatior.BackgroundColor;
            }
            set
            {
                this.riskEstimationRectangleIndicatior.BackgroundColor = value;
                this.riskEstimationRectangleIndicatior.Invalidate();
            }
        }
        public bool HasControlBeenChanged
        {
            get
            {
                return hasControlBeenChanged || ( 
                    arA_EditRiskRiskEstimationItem1.HasControlBeenChanged &&
                    arA_EditRiskRiskEstimationItem2.HasControlBeenChanged &&
                    arA_EditRiskRiskEstimationItem3.HasControlBeenChanged &&
                    arA_EditRiskRiskEstimationItem4.HasControlBeenChanged);
            }

            set
            {
                hasControlBeenChanged = value;
            }
        }

        public string TitleText
        {
            get
            {
                return this.RiskEstimationTextTitle.Text;
            }
            set
            {
                this.RiskEstimationTextTitle.Text = value;
            }
        }

        public ARA_EditRiskRiskEstimation()
        {
            InitializeComponent();
            
            //Update the text on subcontrol invalitdate.
            arA_EditRiskRiskEstimationItem1.riskEstimationItemChangedEventHandler += delegate (object sender, EventArgs e) { this.updateSafetyMesuresRequirement(); };
            arA_EditRiskRiskEstimationItem2.riskEstimationItemChangedEventHandler += delegate (object sender, EventArgs e) { this.updateSafetyMesuresRequirement(); };
            arA_EditRiskRiskEstimationItem3.riskEstimationItemChangedEventHandler += delegate (object sender, EventArgs e) { this.updateSafetyMesuresRequirement(); };
            arA_EditRiskRiskEstimationItem4.riskEstimationItemChangedEventHandler += delegate (object sender, EventArgs e) { this.updateSafetyMesuresRequirement(); };

            updateSafetyMesuresRequirement();

            //Make parent notice, some button is pressed.
            arA_EditRiskRiskEstimationItem1.riskEstimationItemChangedEventHandler += onRiskEstimationItemChanged;
            arA_EditRiskRiskEstimationItem2.riskEstimationItemChangedEventHandler += onRiskEstimationItemChanged;
            arA_EditRiskRiskEstimationItem3.riskEstimationItemChangedEventHandler += onRiskEstimationItemChanged;
            arA_EditRiskRiskEstimationItem4.riskEstimationItemChangedEventHandler += onRiskEstimationItemChanged;
        }

        //Signal parent with custom event that a riskestimationitem has changed.
        public void onRiskEstimationItemChanged(object sender, EventArgs e)
        {
            if(riskEstimationEvenHandler != null)
            {
                try
                {
                    ARA_EditRiskRiskEstimationItem tempItem = (ARA_EditRiskRiskEstimationItem)sender;
                    if(tempItem.SelectedID != -1)
                    {
                        riskEstimationEvenHandler(sender, new RiskEstimationChangedEvent(tempItem.SelectedID, tempItem.GroupName));
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //Sets the control data.
        public void setControlData(DataView riskEstimationDataTable)
        {
            riskEstimationEvenHandler = null;
            hasControlBeenChanged = false;

            DataTable temp = riskEstimationDataTable.ToTable(true, "GroupName");

            string groupName1 = temp.Rows[0]["GroupName"].ToString();
            string groupName2 = temp.Rows[1]["GroupName"].ToString();
            string groupName3 = temp.Rows[2]["GroupName"].ToString();
            string groupName4 = temp.Rows[3]["GroupName"].ToString();

            this.arA_EditRiskRiskEstimationItem1.GroupName = groupName1;
            this.arA_EditRiskRiskEstimationItem2.GroupName = groupName2;
            this.arA_EditRiskRiskEstimationItem3.GroupName = groupName3;
            this.arA_EditRiskRiskEstimationItem4.GroupName = groupName4;

            riskEstimationDataTable.RowFilter = "GroupName ='" + groupName1 + "'";
            this.arA_EditRiskRiskEstimationItem1.setControlData(riskEstimationDataTable);
            riskEstimationDataTable.RowFilter = "GroupName ='" + groupName2 + "'";
            this.arA_EditRiskRiskEstimationItem2.setControlData(riskEstimationDataTable);
            riskEstimationDataTable.RowFilter = "GroupName ='" + groupName3 + "'"; ;
            this.arA_EditRiskRiskEstimationItem3.setControlData(riskEstimationDataTable);
            riskEstimationDataTable.RowFilter = "GroupName ='" + groupName4 + "'"; ;
            this.arA_EditRiskRiskEstimationItem4.setControlData(riskEstimationDataTable);
            //Gekozen om dit met static waardes omdat de form dan sneller laad en geen controls aangemaakt hoeven te worden on runtime.

            updateSafetyMesuresRequirement();
        }

        //Updates the text when an button is pressed, and calculateds the risk class.
        public void updateSafetyMesuresRequirement()
        {
            int riskClassification = calculateRiskEstimationClass();
            string classText = "";

            switch (riskClassification)
            {
                case 1:
                    classText = "Safety measures recommended.";
                    break;
                case 2:
                    classText = "Safety measures required!";
                    break;
                default:
                    classText = "No safety measures rquired";
                    break;
            }

            this.arA_Text6.Text = "Risk class: " + riskClassification.ToString() + " (Points:" + calculateRiskPoints().ToString() + ") " + classText;
            this.arA_Text6.Invalidate();
        }

        //Calcules riskclass.
        private int calculateRiskEstimationClass()
        {
            int severity = this.arA_EditRiskRiskEstimationItem1.SelectedWeight;
            int totalRiskPoints = calculateRiskPoints();

            if (totalRiskPoints < 4 || severity == 0)
            {
                return 0;
            }

            byte[,] classMatrix = new byte[4,12]
            {
                { 0,0,0,0,0,0,0,1,1,1,2,2},
                { 0,0,0,0,1,1,1,2,2,2,2,2},
                { 0,1,1,1,2,2,2,2,2,2,2,2},
                { 1,2,2,2,2,2,2,2,2,2,2,2}
            };

            return classMatrix[severity - 1,totalRiskPoints - 4];
        }

        //Calculates the PR + AV + PS.
        private int calculateRiskPoints()
        {
            return
            (
                this.arA_EditRiskRiskEstimationItem2.SelectedWeight +
                this.arA_EditRiskRiskEstimationItem3.SelectedWeight +
                this.arA_EditRiskRiskEstimationItem4.SelectedWeight
            );
        }
    }
}
