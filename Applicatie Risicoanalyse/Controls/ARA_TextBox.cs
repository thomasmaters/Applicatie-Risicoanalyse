using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_TextBox : RichTextBox
    {
        private int borderSize = 1;
        private Color borderColor = Applicatie_Risicoanalyse.Globals.ARA_Colors.ARA_Gray2;
        private Color backGroundColor = Applicatie_Risicoanalyse.Globals.ARA_Colors.ARA_Blue1;

        [Description("Size of the textbox border."), Category("Appearance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
            }
        }

        [Description("Color of the border."), Category("Appearance")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
            }
        }

        public ARA_TextBox()
        {
            InitializeComponent();
            base.BackColor = this.backGroundColor;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Debug.WriteLine("draw");
            //Create brush.
            System.Drawing.Pen aPen = new System.Drawing.Pen(new System.Drawing.SolidBrush(this.BorderColor),(float)(this.BorderSize));
            //Create graphics object.
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            //Draw broder.
            formGraphics.DrawRectangle(aPen, new System.Drawing.Rectangle(new Point(0, 0), Size));

            aPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
