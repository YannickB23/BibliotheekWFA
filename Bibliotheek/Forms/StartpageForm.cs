﻿using Bibliotheek.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class FrmFrontPage : Form
    {
        public FrmFrontPage()
        {
            InitializeComponent();
        }

        private void BtnBezoeker_Click(object sender, EventArgs e)
        {
            BezoekerForm bezoeker = new BezoekerForm();
            bezoeker.ShowDialog();
        }

        private void BtnLid_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMedewerker_Click(object sender, EventArgs e)
        {

        }
    }
}
