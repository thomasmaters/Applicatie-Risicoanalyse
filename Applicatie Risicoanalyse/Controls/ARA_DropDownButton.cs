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

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_DropDownButton : ARA_Button
    {
        private FlowLayoutPanel connectedPanel = null;
        private Color triangleColor = Color.White;
        private int paddingFirstTriangle = 100;
        private int paddingSecondTriangle = 200;
        private int triangleSize = 22;

        [Browsable(true)]
        [Description("Padding of the first triangle."), Category("Appearance")]
        public int PaddingFirstTriangle
        {
            get
            {
                return paddingFirstTriangle;
            }

            set
            {
                paddingFirstTriangle = value;
            }
        }

        [Browsable(true)]
        [Description("Padding of the second triangle."), Category("Appearance")]
        public int PaddingSecondTriangle
        {
            get
            {
                return paddingSecondTriangle;
            }

            set
            {
                paddingSecondTriangle = value;
            }
        }

        [Browsable(true)]
        [Description("Sets the size of the triangles."), Category("Appearance")]
        public int TriangleSize
        {
            get
            {
                return triangleSize;
            }

            set
            {
                triangleSize = value;
            }
        }

        [Browsable(true)]
        public FlowLayoutPanel ConnectedPanel
        {
            get
            {
                return connectedPanel;
            }
        }

        public ARA_DropDownButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to draw the dropdown button.
        /// </summary>
        /// <param name="pe"></param>
        protected override void OnPaint(PaintEventArgs pe)
        {
            //Draw button base.
            base.OnPaint(pe);

            //Check if we have a connected panel and sets its visability.
            if(this.connectedPanel != null && connectedPanel.Visible != this.selected)
            {
                connectedPanel.Visible = this.selected;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            //Create brushes.
            System.Drawing.SolidBrush triangleBrush = new System.Drawing.SolidBrush(this.triangleColor);

            //Create graphics object.
            System.Drawing.Graphics formGraphics = this.CreateGraphics();

            Point triangleTop;
            Point triangleLeft;
            Point triangleRight;
            
            //Flip rectangle if it is selected.
            if (this.Selected)
            {
                triangleTop = new Point(this.TriangleSize/2, 0);
                triangleLeft = new Point(0, TriangleSize);
                triangleRight = new Point(TriangleSize, TriangleSize);
            }
            else
            {
                triangleTop = new Point(TriangleSize/2, TriangleSize);
                triangleLeft = new Point(0, 0);
                triangleRight = new Point(TriangleSize, 0);
            }

            //Calculate height value for vertical centering.
            int rectangleYPosition = (this.Size.Height - this.TriangleSize) / 2;

            //Add padding for left and right triangle.
            Point[] baseTrianglePoints  = { triangleTop, triangleLeft, triangleRight };
            int tempPaddingFirstTriangle = (int)((float)this.Size.Width / 750 * this.PaddingFirstTriangle);
            int tempPaddingSecondTriangle = (int)((float)this.Size.Width / 750 * this.PaddingSecondTriangle);
            Point[] leftTrianglePoints  = Array.ConvertAll(baseTrianglePoints, element => new Point(element.X + tempPaddingFirstTriangle, element.Y + rectangleYPosition));
            Point[] rightTrianglePoints = Array.ConvertAll(baseTrianglePoints, element => new Point(element.X + tempPaddingSecondTriangle, element.Y + rectangleYPosition));

            if(this.paddingFirstTriangle != -1)
                formGraphics.FillPolygon(triangleBrush, leftTrianglePoints);
            if(this.paddingSecondTriangle != -1)
                formGraphics.FillPolygon(triangleBrush, rightTrianglePoints);

            //Clean.
            formGraphics.Dispose();
        }

        /// <summary>
        /// Connects a panel to a dropdown button.
        /// </summary>
        /// <param name="panel"></param>
        public void setConnectedPanel(FlowLayoutPanel panel)
        {
            if (panel == null) { return; }
            this.connectedPanel = panel;
        }

        /// <summary>
        /// Adds a sub control (form) to the connected panel of the dropdownbutton.
        /// </summary>
        /// <param name="control"></param>
        public void addControlToConnectedPanel(Control control)
        {
            if(control != null && ConnectedPanel != null)
            {
                this.ConnectedPanel.Controls.Add(control);
            }
        }
    }
}
