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
    public partial class CustomerMainMenu : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public CustomerMainMenu()
        {
            InitializeComponent();
        }

        private void btnMainmenurtrn_Click(object sender, EventArgs e)
        {
            UserInfo.IsLoggedIn = false;
            UserInfo.CustomerID = "";
            ItemsToBeAddedToBasket.ItemNames.Clear();
            ItemsToBeAddedToBasket.IndividualItemPrices.Clear();
            ItemsToBeAddedToBasket.ItemindividualQuantities.Clear();
            ItemsToBeAddedToBasket.GrossPricePerItemList.Clear();
            ItemsToBeAddedToBasket.ItemTotalQuantities = 0;
            ItemsToBeAddedToBasket.NumberOfUniqueItemsPurchased = 0;
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

        private void btncusstockarea_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlite_datareadert;
            sqlite_cmd.CommandText = "DROP Table TblBasket";
            sqlite_datareadert = sqlite_cmd.ExecuteReader();
            sqlite_datareadert.Close();
            string MakeBsketTable = "CREATE TABLE IF NOT EXISTS TblBasket(BasketItemName VARCHAR(40), IndividualItemQuantity INT, IndividualItemPrice INT, TotalItemQuantity INT, TotalItemCost INT, GrossCost INT, CustID INT, DateOfPurchase VARCHAR(50))";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = MakeBsketTable;
            sqlite_cmd.ExecuteNonQuery();


            Basket.ItemInformationFromItemsToBeAddedToBasket.Clear();
            Basket.ItemQuantity.Clear();
            Basket.ItemPrices.Clear();
            Basket.TotalQuantityOfAllItemsPurchased = 0;
            Basket.TotalPriceOfAllItemsPurchased = 0;
            Basket.CustomersID = 0;
            ItemsToBeAddedToBasket.ItemNames.Clear();
            ItemsToBeAddedToBasket.IndividualItemPrices.Clear();
            ItemsToBeAddedToBasket.ItemindividualQuantities.Clear();
            ItemsToBeAddedToBasket.GrossPricePerItemList.Clear();
            ItemsToBeAddedToBasket.ItemTotalQuantities = 0;
            ItemsToBeAddedToBasket.NumberOfUniqueItemsPurchased = 0;
            this.Hide();
            var opencustform = new CustomerViewStockForm();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void CustomerMainMenu_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");

            sqlite_conn.Open();
            try
            {
                
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblCustomer WHERE CustRandID = @Randid ";
                sqlite_cmd.Parameters.AddWithValue("@Randid", UserInfo.CustomerID);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string FNAME = sqlite_datareader.GetString(0);
                    string SNAME = sqlite_datareader.GetString(1);
                    txtdisplayloggedinuser.Text = UserInfo.CustomerID + ", " + FNAME+" " + SNAME;

                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btntoorderingArea_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new OrderingItemsToHome();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }
        private void btnToItemReturns_Click(object sender, EventArgs e)
        {

        }

        private void txtdisplayloggedinuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
