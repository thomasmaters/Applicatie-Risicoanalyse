using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_Text : Control
    {
        private Color backgroundColor = Applicatie_Risicoanalyse.Globals.ARA_Colors.ARA_Gray1;
        private StringAlignment horizontalAlignment = StringAlignment.Near;
        private StringAlignment verticalAlignment = StringAlignment.Center;

        public ARA_Text()
        {
            InitializeComponent();
        }

        [Description("Background color of the textbox."), Category("Appearance")]
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

        [Description("Horizontal text alignment."), Category("Appearance")]
        public StringAlignment HorizontalAlignment
        {
            get
            {
                return horizontalAlignment;
            }

            set
            {
                horizontalAlignment = value;
            }
        }

        [Description("Vertical text alignment."), Category("Appearance")]
        public StringAlignment VerticalAlignment
        {
            get
            {
                return verticalAlignment;
            }

            set
            {
                verticalAlignment = value;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(ForeColor);
            System.Drawing.SolidBrush backgroundBrush = new System.Drawing.SolidBrush(backgroundColor);

            //Create graphics object.
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(backgroundBrush, new Rectangle(new Point(0, 0), this.Size));

            //String formatting.
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = this.HorizontalAlignment;
            stringFormat.LineAlignment = this.VerticalAlignment;

            //Draw the text.
            formGraphics.DrawString(Text, Font, textBrush, new Rectangle(new Point(Padding.Left, 0), Size), stringFormat);

            //Clean.
            textBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
