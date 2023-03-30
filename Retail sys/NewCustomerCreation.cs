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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace Retail_sys
{
    public partial class NewCustomerCreation : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public NewCustomerCreation()
        {
            InitializeComponent();
        }
        private void NewCustomerCreation_Load(object sender, EventArgs e)
        {

        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Opening a connection to the database
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
                //MessageBox.Show("Database Open")
                //close database after used
            }
            catch (Exception ex)
            {
                //will show an error if not able to connect
                MessageBox.Show(ex.ToString());
            }
            try
            {
                //Creates a customer table to store all neccesary customer info (primarily ID and Password to login to customer area)
                string Makecustomertable = "CREATE TABLE IF NOT EXISTS TblCustomer(CustForename VARCHAR(30), CustSurname VARCHAR(30), CustStreet VARCHAR(40), CustEmail VARCHAR(30), CustPassword VARCHAR(13), CustRandID INT)";
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = Makecustomertable;
                sqlite_cmd.ExecuteNonQuery();
                Sha256 sha256 = new Sha256();

                //MessageBox.Show("Tables Created");
                //Generates a random 5 digit ID for customers
                Random rnd = new Random();
                int RandomID;
                RandomID = rnd.Next(10000, 99999);
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd = sqlite_conn.CreateCommand();
                string pass = TxtPassword.Text;
                string shapass = sha256.SHA256(pass);
                // Stores all the values written in the text boxes and the random ID once executed. Executed after validation check that boxes arent left empty and match the correct character requirements
                sqlite_cmd.CommandText = "INSERT INTO TblCustomer(CustForename, CustSurname, CustStreet, CustEmail, CustPassword, CustRandID) VALUES(@CustForename, @CustSurname, @CustStreet, @CustEmail, @CustPassword, @CustRandID); ";
                sqlite_cmd.Parameters.AddWithValue("@CustForename", TxtFirstName.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustSurname", TxtSurName.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustStreet", TxtAddress.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustEmail", TxtEmail.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustPassword", shapass);
                sqlite_cmd.Parameters.AddWithValue("@CustRandID", RandomID);

                // Converts ID to a string to validate it
                string StringyID = RandomID.ToString();
                int passswordlengthvalidation = TxtPassword.Text.Length;
                //Alternative validation statement
                //if (String.IsNullOrEmpty(TxtFirstName.Text)|| String.IsNullOrEmpty(TxtSurName.Text)|| String.IsNullOrEmpty(TxtAddress.Text)|| String.IsNullOrEmpty(TxtEmail.Text)|| String.IsNullOrEmpty(TxtPassword.Text))
                //Code above will detect if text boxes are empty and would reset the current screen with the code that sends user to another form
                //ArgumentNullException will display an error box and will not allow the data to be stored in the table until all texboxes are filled. 
                if (TxtFirstName.Text == "")
                {
                    throw new ArgumentNullException("First Name has been left empty!");
                }
                if (TxtSurName.Text == "")
                {
                    throw new ArgumentNullException("Surname has been left empty!");
                }
                if (TxtAddress.Text == "")
                {
                    throw new ArgumentNullException("Address has been left empty!");
                }
                if (TxtEmail.Text == "")
                {
                    throw new ArgumentNullException("Email has been left empty!");
                }
                if (TxtPassword.Text == "")
                {
                    throw new ArgumentNullException("Password has been left empty!");
                }
                //Password validation to ensure it remains under 13 characters
                if (passswordlengthvalidation >= 13)
                {
                    throw new ArgumentNullException("Password can only be a maximum of 12 characters!");
                }

                if (Regex.IsMatch(TxtFirstName.Text, @"^[a-zA-Z\s]+$"))
                {
                    if (Regex.IsMatch(TxtSurName.Text, @"^[a-zA-Z\s]+$"))
                    {
                        if (Regex.IsMatch(TxtAddress.Text, @"^[0-9a-zA-Z \s]+$"))
                        {
                            if (Regex.IsMatch(TxtEmail.Text, @"^[0-9a-zA-Z\s\@\.]+$"))
                            {
                                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                                    MessageBox.Show("Your ID number is: " + StringyID);
                                    MessageBox.Show("Account Created! Returning to Login Area");
                                    this.Hide();
                                    var penmainmenu = new CustomerLogin();
                                    penmainmenu.Closed += (s, args) => this.Close();
                                    penmainmenu.Show();
                                    sqlite_datareader.Close();
                            }
                            else
                            {
                                MessageBox.Show("Customer's Email can not have special characters other that '@' and '.'!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Customer's Address can not have numbers or special characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer's Surname can not have numbers or special characters");
                    }
                }
                else
                {
                    MessageBox.Show("Customer's Forename can not have letters or special characters");
                }
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }  
        private void btnMainMenuRtrn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new CustomerLogin();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }
        private void btnexits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewCustomerCreation_Load_1(object sender, EventArgs e)
        {

        }
    }
}
