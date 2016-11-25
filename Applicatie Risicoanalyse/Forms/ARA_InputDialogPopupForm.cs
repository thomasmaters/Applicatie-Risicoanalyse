using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Forms
{
    public partial class ARA_InputDialogPopupForm : Form
    {
        public ARA_InputDialogPopupForm(string formTitle, string dialogText)
        {
            InitializeComponent();

            this.Text = formTitle;
            this.inputDialogText.Text = dialogText;
        }

        private void inputDialogOK_Click(object sender, EventArgs e)
        {
            this.DialogResult =  DialogResult.OK;
        }

        private void inputDialogCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ARA_InputDialogPopupForm_Load(object sender, EventArgs e)
        {
            //Sets the users focus in the textbox.
            this.inputDialogTextboxInput.Focus();
            this.inputDialogTextboxInput.Select();
            //this.ActiveControl = this.inputDialogTextboxInput;
        }
    }
}
