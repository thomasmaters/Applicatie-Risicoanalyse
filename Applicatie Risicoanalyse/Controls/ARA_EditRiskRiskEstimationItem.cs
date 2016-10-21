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

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_EditRiskRiskEstimationItem : UserControl
    {
        private int[] buttonWeights = { 0};

        public int[] ButtonWeights
        {
            get
            {
                return buttonWeights;
            }

            set
            {
                buttonWeights = value;
            }
        }

        public ARA_EditRiskRiskEstimationItem()
        {
            InitializeComponent();
        }

        public void setGroupName(string groupName)
        {
            this.RiskEstimationText.Text = groupName;
        }

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

        public void setButtonTexts(DataRowCollection buttonTexts)
        {
            for (int i = 0; i < buttonTexts.Count; i++)
            {
                this.RiskEstimationPanel.Controls[i].Text = buttonTexts[i]["ItemDescription"].ToString();
            }
        }

        public void setButtonSelected(int buttonID)
        {
            setButtonSelected(null);
            ((ARA_Button)(this.RiskEstimationPanel.Controls[buttonID])).setButtonSelected(true);
        }

        private void setButtonSelected(ARA_Button button = null)
        {
            Debug.WriteLine("setButtonSelected");
            foreach(ARA_Button control in this.RiskEstimationPanel.Controls.OfType<ARA_Button>())
            {
                if(control != button)
                {
                    control.setButtonSelected(false);
                }
            }
        }

        private void RiskEstimation4Button_Click(object sender, EventArgs e)
        {
            this.setButtonSelected((ARA_Button)sender);
        }

        private void RiskEstimation2Button_Click(object sender, EventArgs e)
        {
            this.setButtonSelected((ARA_Button)sender);
        }

        private void RiskEstimation3Button_Click(object sender, EventArgs e)
        {
            this.setButtonSelected((ARA_Button)sender);
        }

        private void RiskEstimation1Button_Click(object sender, EventArgs e)
        {
            this.setButtonSelected((ARA_Button)sender);
        }

        private void RiskEstimation5Button_Click(object sender, EventArgs e)
        {
            this.setButtonSelected((ARA_Button)sender);
        }
    }
}
