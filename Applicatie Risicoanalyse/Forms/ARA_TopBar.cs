using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_TopBar : Form
    {
        public ARA_TopBar(string leftText = "", string rightText = "")
        {
            InitializeComponent();
            //Scaling.
            this.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize);
            this.topBarTextLeft.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 2);
            this.topBarTextRight.Font = new System.Drawing.Font(ARA_Globals.ARA_Font, ARA_Globals.ARA_BaseFontSize - 2);

            //Set text property.
            this.topBarTextLeft.Text = leftText;
            this.topBarTextRight.Text = rightText;

            //Scale the text.
            scaleTextToFitItsControl(this.topBarTextLeft);
            scaleTextToFitItsControl(this.topBarTextRight);
        }

        /// <summary>
        /// Scales a controls font to fit its bounderies. While keeping a minimum fontsize.
        /// </summary>
        /// <param name="control"></param>
        private void scaleTextToFitItsControl(Control control)
        {
            while ((control.Width < System.Windows.Forms.TextRenderer.MeasureText(control.Text,
                new Font(control.Font.FontFamily, control.Font.Size, control.Font.Style)).Width || control.Height < System.Windows.Forms.TextRenderer.MeasureText(control.Text,
                new Font(control.Font.FontFamily, control.Font.Size, control.Font.Style)).Height) && control.Font.Size > 8F)
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size - 0.5f, control.Font.Style);
            }
        }
    }
}
