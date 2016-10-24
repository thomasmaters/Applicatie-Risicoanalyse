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
        private int selectedWeight = 0;
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
                return selectedWeight;
            }
        }

        public ARA_EditRiskRiskEstimationItem()
        {
            InitializeComponent();

            //Scale controls.
            foreach (Control control in this.Controls)
            {
                control.Scale(new SizeF(ARA_Globals.ARA_BaseFontSize / ARA_Globals.ARa_NoScaleFontSize, ARA_Globals.ARA_BaseFontSize / ARA_Globals.ARa_NoScaleFontSize));
            }

            this.RiskEstimation1Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation2Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation3Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation4Button.Click += onRiskEstimationButtonClick;
            this.RiskEstimation5Button.Click += onRiskEstimationButtonClick;
        }

        //Sets groupname of item.
        public void setGroupName(string groupName)
        {
            this.RiskEstimationText.Text = groupName;
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
        public void setButtonTextsAndWeights(DataView buttonTexts)
        {
            setAmountOfButtons(buttonTexts.Count);
            buttonWeights.Clear();

            for (int i = 0; i < buttonTexts.Count; i++)
            {
                this.RiskEstimationPanel.Controls[i].Text = buttonTexts[i]["ItemDescription"].ToString();

                buttonWeights.Add(Int32.Parse(buttonTexts[i]["ItemWeight"].ToString()));

                if(buttonTexts[i]["InProject"].ToString() == "1")
                {
                    setButtonSelected(i);
                    this.selectedWeight = Int32.Parse(buttonTexts[i]["ItemWeight"].ToString());
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
                        this.selectedWeight = buttonWeights[this.RiskEstimationPanel.Controls.IndexOf(control)];
                    }
                }
            }
            this.Invalidate();
        }

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
        }
    }
}
