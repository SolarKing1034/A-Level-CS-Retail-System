using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Retail_sys
{
    public partial class CustomerLogin : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public CustomerLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openmainmenu = new MainMenu();
            openmainmenu.Closed += (s, args) => this.Close();
            openmainmenu.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brntoacccreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openmainmenu = new NewCustomerCreation();
            openmainmenu.Closed += (s, args) => this.Close();
            openmainmenu.Show();
        }
        private void btnpasscheck_Click(object sender, EventArgs e)
        {
            int charlengthusername= usernametextbox.Text.Length;
            int charlengthpassword = passwordtextbox.Text.Length;
            if (charlengthusername <= 4 || charlengthusername >= 6 || charlengthpassword >=13||String.IsNullOrEmpty(usernametextbox.Text)||String.IsNullOrEmpty(passwordtextbox.Text))
            {
                MessageBox.Show("Details Entered Don't Meet The Expected Character Length Requirements. Try Again.");
                this.Hide();
                var opendmainmenu = new CustomerLogin();
                opendmainmenu.Closed += (s, args) => this.Close();
                opendmainmenu.Show();
            }
            //make another if for user and pass matching  
            //change else below to be inside of username and password match if statement so that it will only send to custmainmenu when username and password has been matched
            else
            {
                this.Hide();
                var openmainmenu = new CustomerMainMenu();
                openmainmenu.Closed += (s, args) => this.Close();
                openmainmenu.Show();
            }

        }
        private void CustomerLogin_Load(object sender, EventArgs e)
        {
            passwordtextbox.UseSystemPasswordChar = true;
            ShowOrHide.MouseDown += new MouseEventHandler(ClickedOnEye);
            ShowOrHide.MouseUp += new MouseEventHandler(ClickedOffEye);
        }
        private void ClickedOnEye(object sender, MouseEventArgs e)
        {
            passwordtextbox.UseSystemPasswordChar = false;
        }
        private void ClickedOffEye(object sender, MouseEventArgs e)
        {
            passwordtextbox.UseSystemPasswordChar = true;
        }

        private void ShowOrHide_Click(object sender, EventArgs e)
        {

        }

        
    }
}

