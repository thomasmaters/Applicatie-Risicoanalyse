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
using Applicatie_Risicoanalyse.Controls;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_ListGroup : ARA_ListInterface
    {
        private List<ARA_ListInterface> childeren = new List<ARA_ListInterface>();

        public ARA_ListGroup()
        {
            InitializeComponent();
            //Connect panel.
            this.ARA_ListGroupDropDownButton.setConnectedPanel(this.ARA_ListGroupPanelButton);

            //Pass click events of button and text to this instance.
            this.ARA_ListGroupDropDownButton.Click += new EventHandler(delegate(object sender, EventArgs e) { this.OnClick(e); });
            this.ARA_ListGroupDropDownButton.DoubleClick += new EventHandler(delegate (object sender, EventArgs e) { this.OnDoubleClick(e); });
            this.ARA_ListGroupText.DoubleClick += new EventHandler(delegate (object sender, EventArgs e) { this.OnDoubleClick(e); });

            //Add random function.
        }
        [Category("Sub controls")]
        public Color TextColor
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.TextColor;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.TextColor = value;
                this.ARA_ListGroupText.ForeColor = value;
            }
        }

        [Category("Sub controls")]
        public Color BackgroundColor
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.BaseColor;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.BaseColor = value;
                this.ARA_ListGroupText.BackgroundColor = value;
            }
        }

        [Category("Sub controls")]
        public Size DropDownButtonSize
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.Size;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.Size = value;
            }
        }

        [Category("Sub controls")]
        public Size TextSize
        {
            get
            {
                return this.ARA_ListGroupText.Size;
            }
            set
            {
                this.ARA_ListGroupText.Size = value;
            }
        }

        [Category("Sub controls")]
        public Color HoverColor
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.HoverColor;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.HoverColor = value;
            }
        }

        [Category("Sub controls")]
        public Color SelectedColor
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.SelectedColor;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.SelectedColor = value;
            }
        }

        [Category("Sub controls")]
        public int DropDownButtonFirstTrianglePadding
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.PaddingFirstTriangle;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.PaddingFirstTriangle = value;
            }
        }

        [Category("Sub controls")]
        public int DropDownButtonSecondTrianglePadding
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.PaddingSecondTriangle;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.PaddingSecondTriangle = value;
            }
        }

        [Category("Sub controls")]
        public string DropDownButtonText
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.Text;
            }
            set
            {
                this.ARA_ListGroupDropDownButton.Text = value;
            }
        }

        [Category("Sub controls")]
        public string LabelText
        {
            get
            {
                return this.ARA_ListGroupText.Text;
            }
            set
            {
                this.ARA_ListGroupText.Text = value;
            }
        }

        public override Font Font
        {
            get
            {
                return this.ARA_ListGroupDropDownButton.Font;
            }
            set
            {
                this.ARA_ListGroupContentPanel.Font = this.Font;
                this.ARA_ListGroupDropDownButton.Font = this.Font;
                this.ARA_ListGroupPanelButton.Font = this.Font;
                this.ARA_ListGroupText.Font = this.Font;
            }
        }

        protected List<ARA_ListInterface> Childeren
        {
            get
            {
                return childeren;
            }

            set
            {
                childeren = value;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.ARA_ListGroupContentPanel.Invalidate();
            this.ARA_ListGroupPanelButton.Invalidate();
            this.ARA_ListGroupText.BackgroundColor = this.ARA_ListGroupDropDownButton.Selected ? this.SelectedColor : this.BackgroundColor;
            this.ARA_ListGroupText.Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.updateControl();
            this.updateParentControl();
            this.updateChilderenControls();
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            this.updateControl();
            this.updateParentControl();
            this.updateChilderenControls();
        }

        public override void updateControl()
        {
            base.updateControl();
            foreach (Action action in this.Functions)
            {
                action();
            }
            this.Invalidate();
        }

        public override void updateParentControl()
        {
            base.updateParentControl();

            if(this.ListParent != null)
            {
                this.ListParent.updateControl();
                this.ListParent.updateParentControl();
            }
            this.Invalidate();
        }

        public override void updateChilderenControls()
        {
            base.updateChilderenControls();

            foreach (ARA_ListInterface child in this.Childeren)
            {
                ARA_ListGroup aListGroupChild = child as ARA_ListGroup;
                if(aListGroupChild == null)
                {
                    child.updateControl();
                }
                else
                {
                    aListGroupChild.updateChilderenControls();
                }
            }
        }

        public void addChild(ARA_ListInterface child)
        {
            if(child != null)
            {
                this.Childeren.Add(child);
            }
        }

        public void addControlToDropDownButton(Control control)
        {
            this.ARA_ListGroupDropDownButton.addControlToConnectedPanel(control);
        }

        private void onListGroupLoad(object sender, EventArgs e)
        {


        }
    }
}
