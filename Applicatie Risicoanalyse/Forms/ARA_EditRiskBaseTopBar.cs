﻿using System;
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
    public partial class ARA_EditRiskBaseTopBar : Form
    {
        public ARA_EditRiskBaseTopBar(string leftText = "", string rightText = "")
        {
            InitializeComponent();
            this.arA_Text1.Text = leftText;
            this.arA_Text2.Text = rightText;
        }
    }
}