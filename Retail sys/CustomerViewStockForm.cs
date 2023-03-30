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
using System.Collections;
using System.Data.SqlClient;

namespace Retail_sys
{

    public partial class CustomerViewStockForm : Form
    {

        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public CustomerViewStockForm()
        {
            InitializeComponent();
        }
        private void CustomerViewStockForm_Load(object sender, EventArgs e)
        {

            AllItemsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;

            AllItemsDataGridView.EnableHeadersVisualStyles = false;


            AllItemsDataGridView.AutoGenerateColumns = false;
  
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
                SQLiteCommand comm = new SQLiteCommand("Select ItemName, ItemQuantity, ItemPrice, ItemIDCode From TblItemStock", sqlite_conn);

                

                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        AllItemsDataGridView.Rows.Add(new object[]
                        {
                            read.GetValue(0),
                            read.GetValue(1),
                            read.GetValue(2),
                            read.GetValue(3),
                        }   );
                    }
                }

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
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnsystexits_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();
            Basket.ItemInformationFromItemsToBeAddedToBasket.Clear();
            Basket.ItemQuantity.Clear();
            Basket.ItemPrices.Clear();
            Basket.TotalQuantityOfAllItemsPurchased = 0;
            Basket.TotalPriceOfAllItemsPurchased = 0;
            Basket.CustomersID = 0;
            SQLiteDataReader sqlite_datareadert;
            sqlite_cmd.CommandText = "DROP Table TblBasket";
            sqlite_datareadert = sqlite_cmd.ExecuteReader();
            sqlite_datareadert.Close();
            ItemsToBeAddedToBasket.ItemNames.Clear();
            ItemsToBeAddedToBasket.IndividualItemPrices.Clear();
            ItemsToBeAddedToBasket.ItemindividualQuantities.Clear();
            ItemsToBeAddedToBasket.GrossPricePerItemList.Clear();
            ItemsToBeAddedToBasket.ItemTotalQuantities = 0;
            ItemsToBeAddedToBasket.NumberOfUniqueItemsPurchased = 0;
            string MakeBsketTable = "CREATE TABLE IF NOT EXISTS TblBasket(BasketItemName VARCHAR(40), IndividualItemQuantity INT, IndividualItemPrice INT, TotalItemQuantity INT, TotalItemCost INT, GrossCost INT, CustID INT, DateOfPurchase VARCHAR(50))";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = MakeBsketTable;
            sqlite_cmd.ExecuteNonQuery();
            Application.Exit();
        }
        private void btnbacktostaffmenus_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();
            Basket.ItemInformationFromItemsToBeAddedToBasket.Clear();
            Basket.ItemQuantity.Clear();
            Basket.ItemPrices.Clear();
            Basket.TotalQuantityOfAllItemsPurchased = 0;
            Basket.TotalPriceOfAllItemsPurchased = 0;
            Basket.CustomersID = 0;
            SQLiteDataReader sqlite_datareadert;
            sqlite_cmd.CommandText = "DROP Table TblBasket";
            sqlite_datareadert = sqlite_cmd.ExecuteReader();
            sqlite_datareadert.Close();
            ItemsToBeAddedToBasket.ItemNames.Clear();
            ItemsToBeAddedToBasket.IndividualItemPrices.Clear();
            ItemsToBeAddedToBasket.ItemindividualQuantities.Clear();
            ItemsToBeAddedToBasket.GrossPricePerItemList.Clear();
            ItemsToBeAddedToBasket.ItemTotalQuantities = 0;
            ItemsToBeAddedToBasket.NumberOfUniqueItemsPurchased = 0;
            string MakeBsketTable = "CREATE TABLE IF NOT EXISTS TblBasket(BasketItemName VARCHAR(40), IndividualItemQuantity INT, IndividualItemPrice INT, TotalItemQuantity INT, TotalItemCost INT, GrossCost INT, CustID INT, DateOfPurchase VARCHAR(50))";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = MakeBsketTable;
            sqlite_cmd.ExecuteNonQuery();
            this.Hide();
            var opencustform = new CustomerMainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }
        private void BtnAddToBasket_Click(object sender, EventArgs e) 
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
                foreach (DataGridViewRow row in AllItemsDataGridView.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[4].Value))
                    {
                        string ItemQuantityComparisons = row.Cells["ItemQuantity"].Value.ToString();
                        string ItemOrderedComparison = row.Cells["QuantityToAdd"].Value.ToString();
                        int ItemQuantityComparisonstoint = Int32.Parse(ItemQuantityComparisons);
                        int ItemOrderedComparisontoint = Int32.Parse(ItemOrderedComparison);

                        if (ItemQuantityComparisonstoint > ItemOrderedComparisontoint)
                        {
                            string Purchaseditemname = row.Cells["ItemName"].Value.ToString();
                            var Purchaseditemindividualprice = row.Cells["ItemPrice"].Value.ToString();
                            var Purchaseditemindividualquantity = row.Cells["QuantityToAdd"].Value.ToString();
                            decimal Purchaseditemindividualpricetoint = Int32.Parse(Purchaseditemindividualprice);
                            int Purchaseditemindividualquantitytoint = Int32.Parse(Purchaseditemindividualquantity);
                            decimal PurchaseditemGrossPricePerItemList = Purchaseditemindividualpricetoint * Purchaseditemindividualquantitytoint;

                            ItemsToBeAddedToBasket.ItemNames.Add(Purchaseditemname);
                            ItemsToBeAddedToBasket.IndividualItemPrices.Add(Purchaseditemindividualpricetoint);
                            ItemsToBeAddedToBasket.ItemindividualQuantities.Add(Purchaseditemindividualquantitytoint);
                            ItemsToBeAddedToBasket.GrossPricePerItemList.Add(PurchaseditemGrossPricePerItemList);


                            decimal GrossSalesCost = ItemsToBeAddedToBasket.GrossPricePerItemList.Sum(x => Convert.ToInt32(x));
                            int totalitemspurchasedsofar = ItemsToBeAddedToBasket.ItemindividualQuantities.Sum(x => Convert.ToInt32(x));

                            sqlite_cmd = sqlite_conn.CreateCommand();
                            sqlite_cmd.CommandText = "INSERT INTO TblBasket(BasketItemName, IndividualItemQuantity, IndividualItemPrice, TotalItemQuantity, TotalItemCost, GrossCost, CustID, DateOfPurchase) VALUES(@BasketItemName, @IndividualItemQuantity, @IndividualItemPrice, @TotalItemQuantity, @TotalItemCost, @GrossCost, @ID, @Date); ";
                            foreach (var a in ItemsToBeAddedToBasket.ItemNames)
                            {
                                sqlite_cmd.Parameters.AddWithValue("@BasketItemName", a);
                            }
                            foreach (var b in ItemsToBeAddedToBasket.ItemindividualQuantities)
                            {
                                sqlite_cmd.Parameters.AddWithValue("@IndividualItemQuantity", b);
                            }
                            foreach (var c in ItemsToBeAddedToBasket.IndividualItemPrices)
                            {
                                sqlite_cmd.Parameters.AddWithValue("@IndividualItemPrice", c);
                            }
                            sqlite_cmd.Parameters.AddWithValue("@TotalItemQuantity", totalitemspurchasedsofar);
                            foreach (var i in ItemsToBeAddedToBasket.GrossPricePerItemList)
                            {
                                sqlite_cmd.Parameters.AddWithValue("@TotalItemCost", i);
                            }
                            sqlite_cmd.Parameters.AddWithValue("@GrossCost", GrossSalesCost);
                            sqlite_cmd.Parameters.AddWithValue("@ID", UserInfo.CustomerID);
                            sqlite_cmd.Parameters.AddWithValue("@Date", DateTime.Now);


                            SQLiteDataReader sqlite_datareader;
                            sqlite_datareader = sqlite_cmd.ExecuteReader();
                            sqlite_datareader.Close();
                            //deleting quantity of items added to basket from item stock table
                            //SQLiteDataReader sqlite_datareaderz;
                            //sqlite_cmd = sqlite_conn.CreateCommand();
                            //sqlite_cmd.CommandText = "SELECT * FROM TblItemStock WHERE ItemName = @ItemName;";
                            //sqlite_cmd.Parameters.AddWithValue("@ItemName", ItemsToBeAddedToBasket.ItemNames);
                            //sqlite_datareaderz = sqlite_cmd.ExecuteReader();
                            //while (sqlite_datareaderz.Read())
                            //{
                            //    int ItemQuanittyfromtbl = sqlite_datareaderz.GetInt32(1);
                            //    sqlite_cmd = sqlite_conn.CreateCommand();
                            //    sqlite_cmd.CommandText = "UPDATE TblItemStock SET ItemStock = @ItemStock WHERE ItemName=@ItemName; ";
                            //    int newquantity = ItemQuanittyfromtbl - Purchaseditemindividualquantitytoint;
                            //    sqlite_cmd.Parameters.AddWithValue("@ItemName", ItemsToBeAddedToBasket.ItemNames);
                            //    sqlite_cmd.Parameters.AddWithValue("@ItemStock", newquantity);
                            //    SQLiteDataReader sqlite_datareaderq;
                            //    sqlite_datareaderq = sqlite_cmd.ExecuteReader();
                            //    sqlite_datareaderq.Close();

                            //}
                            //sqlite_datareaderz.Close();
                            MessageBox.Show("Item Added");

                            DataGridViewCheckBoxCell checkchecboxischecked = (DataGridViewCheckBoxCell)row.Cells[4];
                            if (checkchecboxischecked.Value == checkchecboxischecked.TrueValue)
                            {
                                checkchecboxischecked.Value = checkchecboxischecked.FalseValue;
                            }
                            else
                            {
                                checkchecboxischecked.Value = checkchecboxischecked.TrueValue;
                            }
                            DataGridViewComboBoxCell ClearQuantity = (DataGridViewComboBoxCell)row.Cells[5];
                            if (ClearQuantity.ToString() != "")
                            {
                                ClearQuantity.Value = "";
                            }
                            
                            AllItemsDataGridView.Refresh();
                        }
                    }     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnViewBasket_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            LBoxCurrentBasket.Items.Clear();
            try
            {
                sqlite_conn.Open();
                SQLiteDataReader sqlite_datareadert;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblBasket";
                sqlite_datareadert = sqlite_cmd.ExecuteReader();
                while (sqlite_datareadert.Read())
                {
                    string ITEMNAME = sqlite_datareadert.GetString(0);
                    int INDIVIDUALITEMQUANTITY = sqlite_datareadert.GetInt32(1);
                    decimal INDIVIDUALITEMPRICE = sqlite_datareadert.GetDecimal(2);
                    int TOTALITEMQUANTITY = sqlite_datareadert.GetInt32(3);
                    decimal TOTALITEMCOST = sqlite_datareadert.GetDecimal(4);
                    decimal GROSSCOST = sqlite_datareadert.GetDecimal(5);
                    LBoxCurrentBasket.Items.Add("Item: " + ITEMNAME + ", Quantity: " + INDIVIDUALITEMQUANTITY + ", Price: £" + INDIVIDUALITEMPRICE + ", Item Overall Total: £" + TOTALITEMCOST + ", Gross Total: £" + GROSSCOST);
                }
                sqlite_datareadert.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btntocheckout_Click(object sender, EventArgs e)
        {
            ItemsToBeAddedToBasket.ItemNames.Clear();
            ItemsToBeAddedToBasket.IndividualItemPrices.Clear();
            ItemsToBeAddedToBasket.ItemindividualQuantities.Clear();
            ItemsToBeAddedToBasket.GrossPricePerItemList.Clear();
            ItemsToBeAddedToBasket.ItemTotalQuantities = 0;
            ItemsToBeAddedToBasket.NumberOfUniqueItemsPurchased = 0;
 
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();
            SQLiteDataReader sqlite_datareadert;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM TblBasket";
            sqlite_datareadert = sqlite_cmd.ExecuteReader();
            while (sqlite_datareadert.Read())
            {
                string ITEMNAME = sqlite_datareadert.GetString(0);
                int INDIVIDUALITEMQUANTITY = sqlite_datareadert.GetInt32(1);
                decimal INDIVIDUALITEMPRICE = sqlite_datareadert.GetDecimal(2);
                int TOTALITEMQUANTITY = sqlite_datareadert.GetInt32(3);
                decimal TOTALITEMCOST = sqlite_datareadert.GetDecimal(4);
                decimal GROSSCOST = sqlite_datareadert.GetDecimal(5);           
                Basket.ItemInformationFromItemsToBeAddedToBasket.Add(ITEMNAME);
                Basket.ItemQuantity.Add(INDIVIDUALITEMQUANTITY);
                Basket.ItemPrices.Add(TOTALITEMCOST);
                Basket.TotalQuantityOfAllItemsPurchased = TOTALITEMQUANTITY;
                Basket.TotalPriceOfAllItemsPurchased = GROSSCOST;
                Basket.CustomersID = Convert.ToInt32(UserInfo.CustomerID);
            }
            sqlite_datareadert.Close();
            this.Hide();
            var opencustform = new Checkout();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            string mboxmessage = "Are You Sure?";
            string mboxtitle = "Clear Basket";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult Answer = MessageBox.Show(mboxmessage, mboxtitle, buttons);
            if (Answer == DialogResult.Yes)
            {

                Basket.ItemInformationFromItemsToBeAddedToBasket.Clear();
                Basket.ItemQuantity.Clear();
                Basket.ItemPrices.Clear();
                Basket.TotalQuantityOfAllItemsPurchased = 0;
                Basket.TotalPriceOfAllItemsPurchased = 0;
                Basket.CustomersID = 0;
                SQLiteDataReader sqlite_datareadert;
                sqlite_cmd.CommandText = "DROP Table TblBasket";
                sqlite_datareadert =  sqlite_cmd.ExecuteReader();
                sqlite_datareadert.Close();
                ItemsToBeAddedToBasket.ItemNames.Clear();
                ItemsToBeAddedToBasket.IndividualItemPrices.Clear();
                ItemsToBeAddedToBasket.ItemindividualQuantities.Clear();
                ItemsToBeAddedToBasket.GrossPricePerItemList.Clear();
                ItemsToBeAddedToBasket.ItemTotalQuantities = 0;
                ItemsToBeAddedToBasket.NumberOfUniqueItemsPurchased = 0;
                string MakeBsketTable = "CREATE TABLE IF NOT EXISTS TblBasket(BasketItemName VARCHAR(40), IndividualItemQuantity INT, IndividualItemPrice INT, TotalItemQuantity INT, TotalItemCost INT, GrossCost INT, CustID INT, DateOfPurchase VARCHAR(50))";
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = MakeBsketTable;
                sqlite_cmd.ExecuteNonQuery();

                LBoxCurrentBasket.Items.Clear();
                
            }
            else
            {
                LBoxCurrentBasket.Refresh();
                AllItemsDataGridView.Refresh();
            }      
        }
        private void btnDeleteItemFromBasket_Click_1(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();
            try
            {
                for (int i = 0; i < LBoxCurrentBasket.SelectedItems.Count; i++)
                {
                    LBoxCurrentBasket.Items.Remove(LBoxCurrentBasket.SelectedItems[i]);
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    SQLiteCommand sqlitec = new SQLiteCommand("DELETE FROM TblBasket WHERE BasketItemName = " + LBoxCurrentBasket.SelectedItems + "", sqlite_conn);
                    sqlite_cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted!");
                    LBoxCurrentBasket.Refresh();
                    sqlite_conn.Close();
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());      
            }

        }

        private void AllItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
