using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Retail_sys
{
    public partial class ManagementArea : Form
    {
        public ManagementArea()
        {
            InitializeComponent();
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffandManagementLogin();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }     
        private void btntoeditstaffinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffInformation();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btntosalesrecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new ManagementReport();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();



        }

        private void ManagementArea_Load(object sender, EventArgs e)
        {

        }
    }
}
