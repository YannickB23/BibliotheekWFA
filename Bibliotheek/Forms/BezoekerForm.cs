﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek.Forms
{
    public partial class BezoekerForm : Form
    {
        public BezoekerForm()
        {
            InitializeComponent();
        }

        private void RegistreerLidBTN_Click(object sender, EventArgs e)
        {
            RegistreerLidForm registreerLid = new RegistreerLidForm();
            registreerLid.Show();
        }
    }
}
