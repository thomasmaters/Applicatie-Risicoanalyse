﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Applicatie_Risicoanalyse.Globals;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_ListItem : ARA_ListInterface
    {
        public new object Tag
        {
            get
            {
                return this.Tag;
            }
            set
            {
                this.arA_Text1.Tag = value;
                this.arA_Text2.Tag = value;

                this.Tooltip.SetToolTip(this.arA_Text1, "Tooltip");
                this.Tooltip.SetToolTip(this.arA_Text2, "Tooltip");
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return this.arA_Text1.BackgroundColor;
            }

            set
            {
                this.arA_Text1.BackgroundColor = value;
                this.arA_Text2.BackgroundColor = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return this.arA_Text1.ForeColor;
            }
            set
            {
                this.arA_Text1.ForeColor = value;
                this.arA_Text2.ForeColor = value;
            }
        }

        public StringAlignment HorizontalAlignment
        {
            get
            {
                return this.arA_Text1.HorizontalAlignment;
            }
            set
            {
                this.arA_Text1.HorizontalAlignment = value;
                this.arA_Text2.HorizontalAlignment = value;
            }
        }

        public StringAlignment VerticalAlginment
        {
            get
            {
                return this.arA_Text1.VerticalAlignment;
            }
            set
            {
                this.arA_Text1.VerticalAlignment = value;
                this.arA_Text2.VerticalAlignment = value;
            }
        }

        public string TextFirstControl
        {
            get
            {
                return this.arA_Text1.Text;
            }
            set
            {
                this.arA_Text1.Text = value;
            }
        }

        public string TextSecondControl
        {
            get
            {
                return this.arA_Text2.Text;
            }
            set
            {
                this.arA_Text2.Text = value;
            }
        }

        public ARA_ListItem()
        {
            InitializeComponent();
            this.arA_Text1.Click += new EventHandler(delegate (object sender, EventArgs e) { this.OnClick(e); });
            this.arA_Text2.Click += new EventHandler(delegate (object sender, EventArgs e) { this.OnClick(e); });
        }

        /// <summary>
        /// Click handler that starts the update chain.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.updateControl();
            this.updateParentControl();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.arA_Text1.Invalidate();
            this.arA_Text2.Invalidate();
        }

        /// <summary>
        /// Updates the control with the specific delegates it has.
        /// </summary>
        public override void updateControl()
        {
            base.updateControl();
            foreach (Action action in this.Functions)
            {
                action();
            }
            this.Invalidate();
        }

        /// <summary>
        /// Starts the update for the parent control if it has a parent.
        /// </summary>
        public override void updateParentControl()
        {
            base.updateParentControl();

            if(this.ListParent != null)
            {
                this.ListParent.updateControl();
                this.ListParent.updateParentControl();
            }
        }
    }
}
