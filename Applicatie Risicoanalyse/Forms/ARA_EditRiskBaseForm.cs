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
    public partial class ARA_EditRiskBaseForm : Form
    {
        public ARA_EditRiskBaseForm()
        {
            InitializeComponent();

            //Scaling form and controls.
            this.Font = new Font("Gotham Light", ARA_Globals.ARA_BaseFontSize);
            foreach(Control control in this.Controls)
            {
                control.Font = this.Font;
            }
        }
    }
}
