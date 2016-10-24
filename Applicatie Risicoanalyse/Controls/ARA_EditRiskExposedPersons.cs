using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_EditRiskExposedPersons : UserControl
    {
        private bool hasControlBeenChanged = false;

        public ARA_EditRiskExposedPersons()
        {
            InitializeComponent();
        }

        public bool HasControlBeenChanged
        {
            get
            {
                return hasControlBeenChanged;
            }

            set
            {
                hasControlBeenChanged = value;
            }
        }
    }
}
