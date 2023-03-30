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
    public partial class StaffandManagementLogin : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public StaffandManagementLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int charlengthusername = txtStaffID.Text.Length;
            if (charlengthusername <= 4 || charlengthusername >= 6)
            {
               MessageBox.Show("Details Entered Don't Meet The Expected Character Length Requirements. Try Again.");
                txtStaffID.Clear();
            }
            if (Regex.IsMatch(txtStaffID.Text, @"^[0-9 \s ]+$"))
            {
                sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
                sqlite_conn.Open();
                SQLiteDataReader sqlite_datareader;
                string id = txtStaffID.Text;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = "SELECT * FROM TblStaff where StaffRandID = @StaffRandID";
                sqlite_cmd.Parameters.AddWithValue("@StaffRandID", txtStaffID.Text);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                if (sqlite_datareader.Read())
                {
                    StaffLoginInfo.IsLoggedIn = true;
                    StaffLoginInfo.StaffID = txtStaffID.Text;

                    MessageBox.Show("Login Successful! ");
                    this.Hide();
                    var opencustform = new StaffMainMenu();
                    opencustform.Closed += (s, args) => this.Close();
                    opencustform.Show();
                }
                else
                {
                    MessageBox.Show("Incorrct Details! Try Again! ");
                    txtStaffID.Clear();
                }
                sqlite_datareader.Close();
                sqlite_conn.Close();
            }
            else
            {
                MessageBox.Show("ID cant have special characters or letters");
            }

        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new MainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnManagementSystem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new ManagementAreaLogin();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void StaffandManagementLogin_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
                //MessageBox.Show("Database Open")
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string MakeStaffTable = "CREATE TABLE IF NOT EXISTS TblStaff(StaffForename VARCHAR(30), StaffSurname VARCHAR(30), StaffPosition VARCHAR(40), StaffItemsSold INT, StaffItemsSoldValue INT, StaffRandID INT)";
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = MakeStaffTable;
                sqlite_cmd.ExecuteNonQuery();
                //MessageBox.Show("Tables Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
