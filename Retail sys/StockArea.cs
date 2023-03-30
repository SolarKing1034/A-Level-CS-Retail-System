using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_sys
{
    public partial class StockArea : Form
    {
        public StockArea()
        {
            InitializeComponent();
        }

        private void btnbacktostaffmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffMainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnexits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
