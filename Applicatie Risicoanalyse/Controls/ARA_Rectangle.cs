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
using System.Diagnostics;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_Rectangle : Control
    {
        private Color backgroundColor = Applicatie_Risicoanalyse.Globals.ARA_Colors.ARA_Gray1;

        [Description("Background color of the rectangle."), Category("Appearance")]
        public Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }

            set
            {
                backgroundColor = value;
            }
        }

        public ARA_Rectangle()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(this.backgroundColor);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(new Point(0,0),Size));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        public void RePaint(PaintEventArgs pe)
        {
            this.OnPaint(pe);
        }
    }
}
