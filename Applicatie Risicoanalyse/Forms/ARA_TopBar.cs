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
            this.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            this.arA_Text1.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 2);
            this.arA_Text2.Font = new System.Drawing.Font("Gotham Light", ARA_Globals.ARA_BaseFontSize - 2);

            //Set text property.
            this.arA_Text1.Text = leftText;
            this.arA_Text2.Text = rightText;

            while ((arA_Text2.Width < System.Windows.Forms.TextRenderer.MeasureText(arA_Text2.Text,
                new Font(arA_Text2.Font.FontFamily, arA_Text2.Font.Size, arA_Text2.Font.Style)).Width || arA_Text2.Height < System.Windows.Forms.TextRenderer.MeasureText(arA_Text2.Text,
                new Font(arA_Text2.Font.FontFamily, arA_Text2.Font.Size, arA_Text2.Font.Style)).Height) && arA_Text2.Font.Size > 8F)
            {
                arA_Text2.Font = new Font(arA_Text2.Font.FontFamily, arA_Text2.Font.Size - 0.5f, arA_Text2.Font.Style);
            }

            while ((arA_Text1.Width < System.Windows.Forms.TextRenderer.MeasureText(arA_Text1.Text,
                new Font(arA_Text1.Font.FontFamily, arA_Text1.Font.Size, arA_Text1.Font.Style)).Width || arA_Text1.Height < System.Windows.Forms.TextRenderer.MeasureText(arA_Text1.Text,
                new Font(arA_Text1.Font.FontFamily, arA_Text1.Font.Size, arA_Text1.Font.Style)).Height) && arA_Text1.Font.Size > 8F)
            {
                arA_Text1.Font = new Font(arA_Text1.Font.FontFamily, arA_Text1.Font.Size - 0.5f, arA_Text1.Font.Style);
            }
        }
    }
}
