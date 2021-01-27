using System;
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
    public partial class RegistreerAlsLidForm : Form
    {
        public RegistreerAlsLidForm()
        {
            InitializeComponent();
        }

        private void ledenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ledenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBLedenDataSet);

        }

        private void RegistreerAlsLidForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLedenDataSet.Leden' table. You can move, or remove it, as needed.
            this.ledenTableAdapter.Fill(this.dBLedenDataSet.Leden);

        }
    }
}
