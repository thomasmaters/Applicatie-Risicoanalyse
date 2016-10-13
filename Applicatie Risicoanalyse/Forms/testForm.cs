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

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
            this.arA_ListGroup1.addFunction(delegate () { this.arA_ListGroup1.ARA_ListGroupText.Text = "test"; });
        }
    }
}
