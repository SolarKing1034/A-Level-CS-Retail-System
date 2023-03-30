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
    public partial class StaffViewStockForm : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public StaffViewStockForm()
        {
            InitializeComponent();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openmainmenu = new StaffMainMenu();
            openmainmenu.Closed += (s, args) => this.Close();
            openmainmenu.Show();
        }
        //Instead of a new database, store all stock information in the same database as customer info under a new table so that it
        //doesnt break the code if there are no stock items present when viewed on the customer side of the code.
        private void btnbegone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnShowallStock_Click(object sender, EventArgs e)
        {
            lBoxshowStock.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareadert;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblItemStock";
                sqlite_datareadert = sqlite_cmd.ExecuteReader();
                while (sqlite_datareadert.Read())
                {
                    string ITEMNAME = sqlite_datareadert.GetString(0);
                    int ITEMQUANTITY = sqlite_datareadert.GetInt32(1);
                    decimal ITEMPRICE = sqlite_datareadert.GetDecimal(2);
                    int ITEMIDCODE = sqlite_datareadert.GetInt32(3);
                    lBoxshowStock.Items.Add(ITEMNAME + ", " + ITEMQUANTITY + ", £" + ITEMPRICE + ", " + ITEMIDCODE);
                }
                sqlite_datareadert.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnNewItemCreation_Click(object sender, EventArgs e)
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
                string Makestoktable = "CREATE TABLE IF NOT EXISTS TblItemStock(ItemName VARCHAR(40), ItemQuantity INT, ItemPrice INT, ItemIDCode INT)";
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = Makestoktable;
                sqlite_cmd.ExecuteNonQuery();
                //MessageBox.Show("Tables Created");
                Random rnd = new Random();
                int RandomID;
                RandomID = rnd.Next(1000, 9999);
                //Validates enteries before they are entered to ensure data isnt repeated
                SQLiteDataReader sqlite_datareaderz;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblItemStock WHERE ItemName = @ItemName;";
                sqlite_cmd.Parameters.AddWithValue("@ItemName", TxtItemName.Text);
                sqlite_datareaderz = sqlite_cmd.ExecuteReader();
                while (sqlite_datareaderz.Read())
                {
                    string ITEMNAMECOMPARISON = sqlite_datareaderz.GetString(0);
                    int ITEMIDCODECOMPARISON = sqlite_datareaderz.GetInt32(3);

                    if (ITEMNAMECOMPARISON == TxtItemName.Text)
                    {
                        MessageBox.Show("Record Under the Same name already Exists, with the Item Code: " + ITEMIDCODECOMPARISON, ". Please enter a different name or edit the existing item");
                        TxtItemName.Clear();
                        TxtQuantity.Clear();
                        TxtPrice.Clear();
                        sqlite_conn.Close();

                    }
                }
                sqlite_datareaderz.Close();

                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO TblItemStock(ItemName, ItemQuantity, ItemPrice, ItemIDCode) VALUES(@ItemName, @ItemQuantity, @ItemPrice, @ItemIDCode); ";
                sqlite_cmd.Parameters.AddWithValue("@ItemName", TxtItemName.Text);
                sqlite_cmd.Parameters.AddWithValue("@ItemQuantity", TxtQuantity.Text);
                sqlite_cmd.Parameters.AddWithValue("@ItemPrice", TxtPrice.Text);
                sqlite_cmd.Parameters.AddWithValue("@ItemIDCode", RandomID);

                if (TxtItemName.Text == "")
                {
                    MessageBox.Show("Item Name has been left empty!");
                }
                if (TxtQuantity.Text == "")
                {
                    MessageBox.Show("Item Quantity has been left empty!");
                }
                if (TxtPrice.Text == "")
                {
                    MessageBox.Show("Item Price has been left empty!");
                }

                if (Regex.IsMatch(TxtItemName.Text, @"^[a-zA-Z\s]+$"))
                {
                    if (Regex.IsMatch(TxtQuantity.Text, @"^[0-9\s]+$"))
                    {
                        if (Regex.IsMatch(TxtPrice.Text, @"^[0-9\s\.]+$"))
                        {
                            SQLiteDataReader sqlite_datareader;
                            sqlite_datareader = sqlite_cmd.ExecuteReader();
                            MessageBox.Show("Item Added!");
                            TxtItemName.Clear();
                            TxtQuantity.Clear();
                            TxtPrice.Clear();
                            sqlite_conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Item's Price can not have letters or special characters other than '.'!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item's Quantity can not have letters or special characters");
                    }
                }
                else
                {
                    MessageBox.Show("Item's Name can not have numbers or special characters");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEditItemRecs_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareaders;

            try
            {
                int idlengthcheck = txteditstockid.Text.Length;
                if (idlengthcheck <= 3 || idlengthcheck >= 5)
                {
                    MessageBox.Show("ID does not meet the character requirement! Try Again!");
                }
                if (Regex.IsMatch(txteditstockid.Text, @"^[0-9\s]+$"))
                {
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    string itemidcheck = txteditstockid.Text;
                    sqlite_cmd.CommandText = "UPDATE TblItemStock SET ItemName = @ItemName ,ItemQuantity= @ItemQuantity ,ItemPrice= @ItemPrice WHERE ItemIDCode=@ItemIDCode; ";
                    sqlite_cmd.Parameters.AddWithValue("@ItemName", txtNewItemName.Text);
                    sqlite_cmd.Parameters.AddWithValue("@ItemQuantity", txtNewQuantity.Text);
                    sqlite_cmd.Parameters.AddWithValue("@ItemPrice", txtNewItemPrice.Text);
                    sqlite_cmd.Parameters.AddWithValue("@ItemIDCode", itemidcheck);
                    if (txtNewItemName.Text == "")
                    {
                        throw new ArgumentNullException("First Name has been left empty!");
                    }
                    if (txtNewQuantity.Text == "")
                    {
                        throw new ArgumentNullException("Surname has been left empty!");
                    }
                    if (txtNewItemPrice.Text == "")
                    {
                        throw new ArgumentNullException("Address has been left empty!");
                    }
                    if (Regex.IsMatch(txtNewItemName.Text, @"^[a-zA-Z\s]+$"))
                    {
                        if (Regex.IsMatch(txtNewQuantity.Text, @"^[0-9\s]+$"))
                        {
                            if (Regex.IsMatch(txtNewItemPrice.Text, @"^[0-9\s\.]+$"))
                            {

                                sqlite_datareaders = sqlite_cmd.ExecuteReader();
                                MessageBox.Show("Record Updated!");
                                txteditstockid.Refresh();
                                txtNewItemName.Clear();
                                txtNewQuantity.Clear();
                                txtNewItemPrice.Clear();
                                sqlite_conn.Close();
                                sqlite_datareaders.Close();

                            }
                            else
                            {
                                MessageBox.Show("Item's Price can not have letters or special characters other than '.'!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Item's Quantity can not have letters or special characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item's Name can not have numbers or special characters");
                    }
                }
                else
                {
                    MessageBox.Show("Customer's ID can not have letters or special characters");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDeletItemRec_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;

            try
            {
                int idlengthcheck = txtdeleteitemid.Text.Length;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM TblItemStock WHERE ItemIDCode = @ItemIDCode";
                sqlite_cmd.Parameters.AddWithValue("@ItemIDCode", txtdeleteitemid.Text);
                if (txtdeleteitemid.Text == "" || (idlengthcheck <= 3 || idlengthcheck >= 5))
                {
                    throw new ArgumentNullException("ID entered does not meet character requirements. Try again");
                }
                if (Regex.IsMatch(txtdeleteitemid.Text, @"^[0-9\s]+$"))
                {
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    sqlite_conn.Close();
                    MessageBox.Show("Record Deleted!");
                    lBoxshowStock.Refresh();
                    txtdeleteitemid.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Stock's ID can not have letters or special characters");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btneditquantity_Click(object sender, EventArgs e)
        {
            //sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            //SQLiteDataReader sqlite_datareader;

            //try
            //{
            //    sqlite_conn.Open();
            //    sqlite_cmd = sqlite_conn.CreateCommand();
            //    sqlite_cmd.CommandText = "SELECT * FROM TblItemStock";
            //    sqlite_datareader = sqlite_cmd.ExecuteReader();
            //    while (sqlite_datareader.Read())
            //    {
            //        int ITEMQUANTITY = sqlite_datareader.GetInt32(1);
            //        int QuantitytoAdd = Convert.ToInt32(txtNweQuantityLevel.Text);
            //        int totalnewquantityadd = ITEMQUANTITY + QuantitytoAdd;

            //        sqlite_cmd = sqlite_conn.CreateCommand();
            //        sqlite_cmd.CommandText = "UPDATE TblItemStock SET ItemQuantity= @ItemQuantity WHERE ItemIDCode = @ItemIDCode";
            //        sqlite_cmd.Parameters.AddWithValue("@ItemIDCode", txtStockChangeID.Text);
            //        sqlite_cmd.Parameters.AddWithValue("@ItemQuantity", totalnewquantityadd);
            //        if (txtNweQuantityLevel.Text == "")
            //        {
            //            throw new ArgumentNullException("Quantity has been left empty! ");
            //        }
            //        if (Regex.IsMatch(txtNweQuantityLevel.Text, @"^[0-9\s]+$"))
            //        {
            //            SQLiteDataReader sqlite_datareaders;

            //            sqlite_datareaders = sqlite_cmd.ExecuteReader();
            //            MessageBox.Show("Record Updated!");
            //            txtNweQuantityLevel.Clear();
            //            txtStockChangeID.Clear();
            //            sqlite_conn.Close();
            //            sqlite_datareaders.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Quantity to add can only be a number");
            //        }
            //    }
            //    sqlite_datareader.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void StaffViewStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
