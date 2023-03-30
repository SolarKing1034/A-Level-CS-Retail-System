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
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;


namespace Retail_sys
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
            lBoxOrderedItemsInfo.Items.Clear();
            lBoxOrderedItemsPrice.Items.Clear();
            lBoxQuantitys.Items.Clear();
        }
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        private void Checkout_Load(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();
            SQLiteDataReader sqlite_datareader;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM TblCustomer WHERE CustRandID = @Randid ";
            sqlite_cmd.Parameters.AddWithValue("@Randid", UserInfo.CustomerID);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string FNAME = sqlite_datareader.GetString(0);
                string SNAME = sqlite_datareader.GetString(1);
                txtdisplayloggedinuser.Text = UserInfo.CustomerID + ", " + FNAME + " " + SNAME;
                txtdisplayloggedinuser.Enabled = false;
                txtdisplayloggedinuser.ForeColor = Color.Yellow;
                lBoxOrderedItemsInfo.Items.Clear();
                lBoxOrderedItemsPrice.Items.Clear();
                lBoxQuantitys.Items.Clear();


                foreach (var i in Basket.ItemInformationFromItemsToBeAddedToBasket)
                {
                    lBoxOrderedItemsInfo.Items.Add(i);
                }
                foreach (var y in Basket.ItemQuantity)
                {
                    lBoxQuantitys.Items.Add("x " + y);
                }

                foreach (var x in Basket.ItemPrices)
                {
                    lBoxOrderedItemsPrice.Items.Add(x);
                }
                string PriceAsString = Basket.TotalPriceOfAllItemsPurchased.ToString();
                txtTotalCost.Text = "£" + PriceAsString;
            }
            sqlite_datareader.Close();
        }

        private void btnbacktostaffmenus_Click(object sender, EventArgs e)
        {

            lBoxOrderedItemsInfo.Items.Clear();
            lBoxOrderedItemsPrice.Items.Clear();
            txtTotalCost.Clear();
            this.Hide();
            var opencustform = new CustomerViewStockForm();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btncompletetransaction_Click(object sender, EventArgs e)
        {
            using (TextWriter sw = File.AppendText(@"ManagementReport.txt"))
            {
                sw.WriteLine("Customer: ");
                sw.WriteLine("ID: " + Basket.CustomersID.ToString());
                sw.WriteLine("Items:");
                foreach (string i in Basket.ItemInformationFromItemsToBeAddedToBasket)
                {
                    sw.WriteLine(i);
                }
                sw.WriteLine("Quantities:");
                foreach (int r in Basket.ItemQuantity)
                {
                    sw.WriteLine(r);
                }
                sw.WriteLine("Prices:");
                foreach (int s in Basket.ItemPrices)
                {
                    sw.WriteLine(s);
                }
                sw.WriteLine(string.Format("Total Price {0} \n", Basket.TotalPriceOfAllItemsPurchased.ToString()));
                DateTime now = DateTime.Now;

                sw.WriteLine(string.Format("Purchase made at: " + now));

            }

            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            SQLiteDataReader SQLiteDataReader;
            string MakeManagementBasketTbl = "CREATE TABLE IF NOT EXISTS TblBasketArchive(CustID INT, BasketItemName VARCHAR(40), ItemQuantity INT, ItemPrice INT,  GrossCost INT, DateOfPurchase VARCHAR (50))";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = MakeManagementBasketTbl;
            sqlite_cmd.ExecuteNonQuery();
            DateTime noww = DateTime.Now;

            string InsertIntoCMD = "INSERT INTO TblBasketArchive (CustID, BasketItemName,ItemQuantity,ItemPrice,GrossCost, DateOfPurchase) SELECT CustID, BasketItemName, IndividualItemQuantity, IndividualItemPrice, TotalItemQuantity, DateOfPurchase FROM TblBasket";
            sqlite_cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            sqlite_cmd.Parameters.AddWithValue("@CustID", UserInfo.CustomerID);

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = InsertIntoCMD;
            SQLiteDataReader = sqlite_cmd.ExecuteReader();

            //string InsertIntoCMD2 = "INSERT INTO TblBasketArchive (CustID, DateOfPurchase) VALUES(@CustID, @Date)";
            //sqlite_cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            //sqlite_cmd.Parameters.AddWithValue("@CustID", UserInfo.CustomerID);

            //sqlite_cmd = sqlite_conn.CreateCommand();
            //sqlite_cmd.CommandText = InsertIntoCMD2;


            if (lBoxOrderedItemsInfo.Items.Count != 0)
            { 
                
                MessageBox.Show("Items Purchased!");
                string LogoutMessage = "Would You Like A Receipt웃 Selecting No Will Return To Main Menu The System";
                string title = "Purchase Successful";
                MessageBoxButtons CustomeButtons = MessageBoxButtons.YesNo;
                DialogResult mboxconstruction = MessageBox.Show(LogoutMessage, title, CustomeButtons);
                if (mboxconstruction == DialogResult.Yes)
                {
                    this.Hide();
                    var opencustform = new Receipt();
                    opencustform.Closed += (s, args) => this.Close();
                    opencustform.Show();
                }
                else
                {
                    sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
                    sqlite_conn.Open();

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
                    var opencustform = new MainMenu();
                    opencustform.Closed += (s, args) => this.Close();
                    opencustform.Show();
                }
            }
            else
            {       
                MessageBox.Show("No Items in Basket. Add Items in the Item Catalouge?");
                string mboxmessage = "Go Back To Catalogue?";
                string mboxtitle = "Basket Empty";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult Answer = MessageBox.Show(mboxmessage, mboxtitle, buttons);
                if (Answer == DialogResult.Yes)
                {
                    this.Hide();
                    var opencustform = new CustomerViewStockForm();
                    opencustform.Closed += (s, args) => this.Close();
                    opencustform.Show();
                }
                if (Answer == DialogResult.No)
                {
                    this.Hide();
                    var opencustform = new Checkout();
                    opencustform.Closed += (s, args) => this.Close();
                    opencustform.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new OrderingItemsToHome();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void lBoxOrderedItemsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
