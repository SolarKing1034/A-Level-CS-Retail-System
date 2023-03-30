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

            sqlite_conn = new SQLiteConnection("Data Source=CustomerDatabase.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string Makecustomertable = "CREATE TABLE IF NOT EXISTS TblCustomer(CustForename VARCHAR(20), CustSurname VARCHAR(20), CustStreet VARCHAR(40), CustEmail VARCHAR(20), CustPassword VARCHAR(12), CustRandID INT)";
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = Makecustomertable;
                sqlite_cmd.ExecuteNonQuery();
                //MessageBox.Show("Tables Created");
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO TblCustomer(CustForename, CustSurname, CustStreet, CustEmail, CustPassword, CustRandID) VALUES(@CustForename, @CustSurname, @CustStreet, @CustEmail, @CustPassword, @CustRandID); ";
                sqlite_cmd.Parameters.AddWithValue("@CustForename", TxtFirstName.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustSurname", TxtSurName.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustStreet", TxtAddress.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustEmail", TxtEmail.Text);
                sqlite_cmd.Parameters.AddWithValue("@CustPassword", TxtPassword.Text);
                sqlite_cmd.ExecuteNonQuery();
                //MessageBox.Show("Record Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            bool isUnique = true;
            int RandomID;
            do
            {
                Random rnd = new Random();
                RandomID = rnd.Next(10000, 99999);
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd.CommandText = "SELECT * FROM TblCustomer WHERE CustRandID = @CustRandID";
                sqlite_cmd.Parameters.AddWithValue("@CustRandID", RandomID);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    isUnique = false;
                }
                sqlite_datareader.Close();
            }
            while (isUnique != true);
            string StringyID = RandomID.ToString();
            int passswordlengthvalidation = TxtPassword.Text.Length;
//Alternative validation 
/// if (String.IsNullOrEmpty(TxtFirstName.Text)|| String.IsNullOrEmpty(TxtSurName.Text)|| String.IsNullOrEmpty(TxtAddress.Text)|| String.IsNullOrEmpty(TxtEmail.Text)|| String.IsNullOrEmpty(TxtPassword.Text))

            if (TxtFirstName.Text == "")
            {
                throw new ArgumentNullException("TxtFirstName received a null argument!");
            }
            if (TxtSurName.Text == "")
            {
                throw new ArgumentNullException("TxtSurName received a null argument!");
            }
            if (TxtAddress.Text == "")
            {
                throw new ArgumentNullException("TxtAddres received a null argument!");
            }
            if (TxtEmail.Text == "")
            {
                throw new ArgumentNullException("TxtEmail received a null argument!");
            }
            if (TxtPassword.Text == "")
            {
                throw new ArgumentNullException("TxtPassword received a null argument!");
            }
            if (passswordlengthvalidation >= 13)
            {
                MessageBox.Show("Password can only be a maximum of 12 characters!");
                this.Hide();
                var spenmainmenu = new NewCustomerCreation();
                spenmainmenu.Closed += (s, args) => this.Close();
                spenmainmenu.Show();
            }
            else
            {
                MessageBox.Show("Your ID number is: " + StringyID);
                MessageBox.Show("Account Created! Returning to Login Area");
                this.Hide();
                var penmainmenu = new CustomerLogin();
                penmainmenu.Closed += (s, args) => this.Close();
                penmainmenu.Show();
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
    }
}

