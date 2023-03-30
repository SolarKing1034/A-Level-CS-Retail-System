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
    public partial class MainMenu : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnToSustomer_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            string MakeBsketTable = "CREATE TABLE IF NOT EXISTS TblBasket(BasketItemName VARCHAR(40), IndividualItemQuantity INT, IndividualItemPrice INT, TotalItemQuantity INT, TotalItemCost INT, GrossCost INT, CustID INT, DateOfPurchase VARCHAR(50))";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = MakeBsketTable;
            sqlite_cmd.ExecuteNonQuery();

            //Create another table or use basket table to store all the basket's items and information. Then serialize this information into a single unique ID and when needed (i.e. for returning goods and managment reports)
            // The random ID can be used to deserialize the data to be displayed
            this.Hide();
            var opencustform = new CustomerLogin();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnToStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffandManagementLogin();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnexitbuton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
