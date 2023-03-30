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
using System.Text.RegularExpressions;


namespace Retail_sys
{
    public partial class ManagementAreaLogin : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public ManagementAreaLogin()
        {
            InitializeComponent();
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            int validaatiob = txtmanagercheck.Text.Length;

            if (validaatiob <= 4 || validaatiob >= 6)
            {
                MessageBox.Show("Details Entered Don't Meet The Expected Character Length Requirements. Try Again.");
                txtmanagercheck.Clear();
            }
            if (Regex.IsMatch(txtmanagercheck.Text, @"^[0-9\s]+$"))
            {
                sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
                sqlite_conn.Open();
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = "SELECT * FROM TblStaff where StaffRandID='" + txtmanagercheck.Text + "' AND StaffPosition = @StaffPosition";
                sqlite_cmd.Parameters.AddWithValue("@StaffPosition", "Manager");
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                if (sqlite_datareader.Read())
                {
                    MessageBox.Show("Login Successful! ");
                    this.Hide();
                    var opencustform = new ManagementArea();
                    opencustform.Closed += (s, args) => this.Close();
                    opencustform.Show();
                }
                else
                {
                    MessageBox.Show("Incorrct Details! Username may be wrong or not a Manager! Try Again! ");
                    txtmanagercheck.Clear();
                }
                sqlite_datareader.Close();
                sqlite_conn.Close();
            }
            else
            {
                MessageBox.Show("ID cant have special characters or letters");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMainMenuRtrn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffandManagementLogin();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void ManagementAreaLogin_Load(object sender, EventArgs e)
        {
            
        }
      
    }
}