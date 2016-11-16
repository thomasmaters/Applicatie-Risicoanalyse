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
    public partial class ARA_EditRiskRiskEstimationItem : UserControl
    {
        private List<int> buttonWeights = new List<int>();
        private List<int> buttonIDs = new List<int>();
        public EventHandler<EventArgs> riskEstimationItemChangedEventHandler;
        private int selectedIndex = 0;
        private bool hasControlBeenChanged = false;

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

        public int SelectedWeight
        {
            get
            {
                if(selectedIndex > -1 && buttonWeights.Count > 0)
                {
                    return buttonWeights[selectedIndex];
                }
                else
                {
                    return 0;
                }
            }
        }

        public int SelectedID
        {
            get
            {
                if(selectedIndex == -1)
                {
                    return -1;
                }
                return buttonIDs[selectedIndex];
            }
        }

        public ARA_EditRiskRiskEstimationItem()
        {
            InitializeComponent();

            //Scale controls.
            foreach (Control control in this.Controls)
            {
                control.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Constants.noScaleFontSize));
            }

            //Button click binds.
            this.RiskEstimation1Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation2Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation3Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation4Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation5Button.Click += onRiskEstimationButtonClick;
        }

        //Sets groupname of item.
        public string GroupName
        {
            get
            {
                return this.RiskEstimationText.Text;
            }
            set
            {
                this.RiskEstimationText.Text = value;
            }
        }

        //Shows the amount of buttons in the control.
        public void setAmountOfButtons(int amountOfControls)
        {
            for(int i=0;i<this.RiskEstimationPanel.Controls.Count;i++)
            {
                if(i < amountOfControls)
                {
                    this.RiskEstimationPanel.Controls[i].Visible = true;
                }
                else
                {
                    this.RiskEstimationPanel.Controls[i].Visible = false;
                }
            }
        }

        //Sets button texts from a datarowcollection.
        public void setControlData(DataView buttonTexts)
        {
            setAmountOfButtons(buttonTexts.Count);
            buttonWeights.Clear();
            buttonIDs.Clear();
            hasControlBeenChanged = false;
            selectedIndex = -1;
            setButtonSelected();

            for (int i = 0; i < buttonTexts.Count; i++)
            {
                this.RiskEstimationPanel.Controls[i].Text = buttonTexts[i]["ItemDescription"].ToString();

                buttonWeights.Add(Int32.Parse(buttonTexts[i]["ItemWeight"].ToString()));
                buttonIDs.Add(Int32.Parse(buttonTexts[i]["EstimationID"].ToString()));

                if (buttonTexts[i]["InProject"].ToString() == "1")
                {
                    setButtonSelected(i);
                    this.selectedIndex = i;
                }
            }
        }

        //Sets a specific button selected, while deselecting the other ones.
        public void setButtonSelected(int buttonID)
        {
            setButtonSelected(null);
            ((ARA_Button)(this.RiskEstimationPanel.Controls[buttonID])).setButtonSelected(true);
        }

        //Sets a specific button selected, while deselecting the other ones. Als update the selected weight.
        private void setButtonSelected(ARA_Button button = null)
        {
            //Loop throuh all our buttons.
            foreach (ARA_Button control in this.RiskEstimationPanel.Controls.OfType<ARA_Button>())
            {
                if(control != button)
                {
                    control.setButtonSelected(false);
                }
                else //Update the selected weight.
                {
                    if(buttonWeights.Count > 0)
                    {
                        this.selectedIndex = this.RiskEstimationPanel.Controls.IndexOf(control);
                    }
                }
            }
        }

        //Handler when one of the buttons is pressed.
        private void onRiskEstimationButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.setButtonSelected((ARA_Button)sender);
            }
            catch (Exception)
            {
                throw;
            }
            //Set flag so the control knows it has been changed.
            this.hasControlBeenChanged = true;
            if (this.riskEstimationItemChangedEventHandler != null)
            {
                this.riskEstimationItemChangedEventHandler(this, new EventArgs());
            }
        }
    }
}
