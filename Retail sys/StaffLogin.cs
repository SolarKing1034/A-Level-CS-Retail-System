using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.section.io/engineering-education/create-login-and-register-system-with-csharp-winforms/

namespace Retail_sys
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            if (this.textBox1.Text == "123")
            {
                MessageBox.Show("Access Granted!");
                this.Hide();
                var opencustform = new StaffMainMenu();
                opencustform.Closed += (s, args) => this.Close();
                opencustform.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password! Exiting to Main Menu...");
                this.Hide();
                var opencustform = new MainMenu();
                opencustform.Closed += (s, args) => this.Close();
                opencustform.Show();           
            }
        }
        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new MainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
