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
    public partial class ARA_Button : Control
    {
        private Color baseColor = ARA_Colors.ARA_Gray1;
        private Color selectedColor = ARA_Colors.ARA_Blue6;
        private Color hoverColor = ARA_Colors.ARA_Gray2;
        private Color textColor         = Color.White;
        private Color selectedTextColor = Color.White;
        private StringAlignment horizontalAlignment = StringAlignment.Near;
        private StringAlignment verticalAlignment = StringAlignment.Center;
        public bool selected = false;
        protected bool hovering           = false;

        public bool Selected
        {
            get
            {
                return selected;
            }

            set
            {
                selected = value;
            }
        }

        [Description("Horizontal text alignment in the button."), Category("Appearance")]
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

        [Description("Vertical text alignment in the button."), Category("Appearance")]
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

        [Description("Button background color."), Category("Appearance")]
        public Color BaseColor
        {
            get
            {
                return baseColor;
            }

            set
            {
                baseColor = value;
            }
        }

        [Description("Button color when it is selected."), Category("Appearance")]
        public Color SelectedColor
        {
            get
            {
                return selectedColor;
            }

            set
            {
                selectedColor = value;
            }
        }

        [Description("Button background color when the user hovers the mouse over it."), Category("Appearance")]
        public Color HoverColor
        {
            get
            {
                return hoverColor;
            }

            set
            {
                hoverColor = value;
            }
        }

        [Description("Color of the text in the button."), Category("Appearance")]
        public Color TextColor
        {
            get
            {
                return textColor;
            }

            set
            {
                textColor = value;
            }
        }

        [Description("Color of the text in the button when the button is selected."), Category("Appearance")]
        public Color SelectedTextColor
        {
            get
            {
                return selectedTextColor;
            }

            set
            {
                selectedTextColor = value;
            }
        }

        public ARA_Button()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
            System.Drawing.SolidBrush backgroundBrush;
            System.Drawing.SolidBrush textBrush = new System.Drawing.SolidBrush(this.TextColor);

            //Change color of button when the user is hovering or the control is selected or disabled.
            if (!this.Selected && this.hovering)
            {
                backgroundBrush = new System.Drawing.SolidBrush(this.hoverColor);
            }
            else if(this.Selected)
            {
                backgroundBrush = new System.Drawing.SolidBrush(this.selectedColor);
                textBrush = new System.Drawing.SolidBrush(this.SelectedTextColor);
            }
            else if(this.Enabled == false)
            {
                backgroundBrush = new System.Drawing.SolidBrush(Applicatie_Risicoanalyse.Globals.ARA_Colors.ARA_Gray2);
            }
            else
            {
                backgroundBrush = new System.Drawing.SolidBrush(this.baseColor);
            }

            //Create graphics object.
            System.Drawing.Graphics formGraphics = this.CreateGraphics();

            //Draw the button background rectangle.
            formGraphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), this.Size));
            formGraphics.FillRectangle(backgroundBrush, new Rectangle(new Point(0,0), this.Size));

            //Align text in button to center.
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = this.horizontalAlignment;
            stringFormat.LineAlignment = this.verticalAlignment;

            //Draw the text.
            formGraphics.DrawString(this.Text, this.Font, textBrush, new Rectangle(new Point(Padding.Left, 0), Size),stringFormat);

            //Clean.
            backgroundBrush.Dispose();
            textBrush.Dispose();
            formGraphics.Dispose();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.hovering = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.hovering = false;
            this.Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if(e.Button != MouseButtons.Left)
            {
                return;
            }
            if(e.Clicks == 1)
            {
                this.Selected = !this.Selected;
                this.Invalidate();
            }
        }

        public void setButtonSelected(bool e)
        {
            this.selected = e;
            this.Invalidate();
        }
    }
}
