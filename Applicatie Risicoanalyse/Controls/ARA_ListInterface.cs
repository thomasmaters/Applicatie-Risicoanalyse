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
    public partial class ARA_ListInterface : UserControl
    {
        private ARA_ListInterface listParent;
        private List<Action> functions = new List<Action>();
        private ARA_ImageTooltip tooltip = null;

        public ARA_ListInterface()
        {
            InitializeComponent();
        }

        public ARA_ListInterface ListParent
        {
            get
            {
                return listParent;
            }

            set
            {
                listParent = value;
            }
        }

        protected List<Action> Functions
        {
            get
            {
                return functions;
            }

            set
            {
                functions = value;
            }
        }

        public ARA_ImageTooltip Tooltip
        {
            get
            {
                if(tooltip == null)
                {
                    this.tooltip = new ARA_ImageTooltip();
                }
                return tooltip;
            }

            set
            {
                tooltip = value;
            }
        }

        public virtual void updateParentControl()
        {

        }

        public virtual void updateChilderenControls()
        {

        }

        public virtual void updateControl()
        {

        }

        public void addFunction(Action action)
        {
            if(action != null)
            {
                this.Functions.Add(action);
            }
        }
    }
}
