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
    public partial class StaffMainMenu : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public StaffMainMenu()
        {
            InitializeComponent();
        }

        private void btnMainmenurtrn_Click(object sender, EventArgs e)
        {
            StaffLoginInfo.IsLoggedIn = false;
            StaffLoginInfo.StaffID = "";
            this.Hide();
            var opencustform = new MainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnexitsys_Click(object sender, EventArgs e)
        {
            UserInfo.IsLoggedIn = false;
            UserInfo.CustomerID = "";
            Application.Exit();
        }



        private void btnStockarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffViewStockForm();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnviewcustrecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffviewCustomerRecords();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void StaffMainMenu_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblStaff WHERE StaffRandID = @Randid ";
                sqlite_cmd.Parameters.AddWithValue("@Randid", StaffLoginInfo.StaffID);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string FNAME = sqlite_datareader.GetString(0);
                    string SNAME = sqlite_datareader.GetString(1);
                    txtdisplayloggedinuser.Text = StaffLoginInfo.StaffID + ", " + FNAME + " " + SNAME;

                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
