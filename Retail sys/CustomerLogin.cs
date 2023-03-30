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
using System.Security.Cryptography;
using System.Text;
using System.Web;
using GMap.NET;
using System.Text.RegularExpressions;

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
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            if (Regex.IsMatch(usernametextbox.Text, @"^[0-9\s]+$"))
            {
                int userid = Convert.ToInt32(usernametextbox.Text);
                string userpass = passwordtextbox.Text;
                sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
                sqlite_conn.Open();
                SQLiteDataReader sqlite_datareader;

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = "SELECT * FROM TblCustomer";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                Sha256 sha256 = new Sha256();
                bool login = false;
                while (sqlite_datareader.Read())
                {
                    int Username = sqlite_datareader.GetInt32(5);
                    string Pass = sqlite_datareader.GetString(4);

                    if (Username == userid && Pass == sha256.SHA256(userpass))
                    {
                        login = true;
                        UserInfo.IsLoggedIn = true;
                        UserInfo.CustomerID = usernametextbox.Text;

                        MessageBox.Show("Login Successful! ");
                        this.Hide();
                        var openmainmenu = new CustomerMainMenu();
                        openmainmenu.Closed += (s, args) => this.Close();
                        openmainmenu.Show();
                    }
                }
                if (login == false)
                {
                    MessageBox.Show("Incorrct Details! Try Again! ");
                    usernametextbox.Clear();
                    passwordtextbox.Clear();
                }
                login = false;
            }
            else
            {
                MessageBox.Show("ID cant have special characters or letters");

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

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

