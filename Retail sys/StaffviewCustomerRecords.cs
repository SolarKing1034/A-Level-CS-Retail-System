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
    public partial class StaffviewCustomerRecords : Form
    {
        string outputto = "{0,-10}\t{1,-10}\t{2,-10}\t{3,-20}\t{4,-30}\t{5,-15}";
        string outbutto = "{0,-10}\t{1,-15}\t{2,-5}\t{3,-20}\t{4,-20}\t{5,-15}";

        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public StaffviewCustomerRecords()
        {
            InitializeComponent();
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new StaffMainMenu();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnbegone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDeletCustRec_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            SQLiteDataReader sqlite_datareader;

            try
            {
                int idlengthcheck = txtdeletecusid.Text.Length;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM TblCustomer WHERE CustRandID = @CustRandID";
                sqlite_cmd.Parameters.AddWithValue("@CustRandID", txtdeletecusid.Text);
                if (txtdeletecusid.Text == ""|| (idlengthcheck <= 4 || idlengthcheck >= 6))
                {
                    throw new ArgumentNullException("ID entered does not meet character requirements. Try again");
                }
                if (Regex.IsMatch(txtdeletecusid.Text, @"^[0-9\s]+$"))
                {
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted!");
                    lBoxallcustomers.Refresh();
                    txtdeletecusid.Clear();
                    sqlite_datareader.Close();

                }
                else
                {
                    MessageBox.Show("Customer's ID can not have letters or special characters");
                }
                sqlite_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEditCustRecs_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");

            SQLiteDataReader sqlite_datareader;
            try
            {
                int idlengthcheck = txteditcustid.Text.Length;
                int passlengthcheck = txtNewpassword.Text.Length;
                if (idlengthcheck <= 4 || idlengthcheck >= 6)
                {
                    throw new ArgumentNullException("ID does not meet the character requirement! Try Again!");
                }
                
                else
                {
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    string IDCustCheck = txteditcustid.Text;
                    Sha256 sha256 = new Sha256();

                    string pass = txtNewpassword.Text;
                    string shapass = sha256.SHA256(pass);
                    sqlite_cmd.CommandText = "UPDATE TblCustomer SET CustForename = @NewCustForename ,CustSurname= @NewCustSurname ,CustStreet= @NewCustStreet ,CustEmail= @NewCustEmail ,CustPassword= @NewCustPassword WHERE CustRandID=@CustIdCheck; ";
                    sqlite_cmd.Parameters.AddWithValue("@NewCustForename", txtNewforename.Text);
                    sqlite_cmd.Parameters.AddWithValue("@NewCustSurname", txtNewsurname.Text);
                    sqlite_cmd.Parameters.AddWithValue("@NewCustStreet", txtNewstreet.Text);
                    sqlite_cmd.Parameters.AddWithValue("@NewCustEmail", txtNewemail.Text);
                    sqlite_cmd.Parameters.AddWithValue("@NewCustPassword", shapass);
                    sqlite_cmd.Parameters.AddWithValue("@CustIdCheck", IDCustCheck);
                    if (txtNewforename.Text == "")
                    {
                        throw new ArgumentNullException("First Name has been left empty!");
                    }
                    if (txtNewsurname.Text == "")
                    {
                        throw new ArgumentNullException("Surname has been left empty!");
                    }
                    if (txtNewstreet.Text == "")
                    {
                        throw new ArgumentNullException("Address has been left empty!");
                    }
                    if (txtNewemail.Text == "")
                    {
                        throw new ArgumentNullException("Email has been left empty!");
                    }
                    if (txtNewpassword.Text == "")
                    {
                        throw new ArgumentNullException("Password has been left empty!");
                    }
                    if (passlengthcheck >= 13)
                    {
                        throw new ArgumentNullException("Password can only be a maximum of 12 characters!");
                    }

                    if (Regex.IsMatch(txteditcustid.Text, @"^[0-9\s]+$"))
                    {
                        if (Regex.IsMatch(txtNewforename.Text, @"^[a-zA-Z\s]+$"))
                        {
                            if (Regex.IsMatch(txtNewsurname.Text, @"^[a-zA-Z\s]+$"))
                            {
                                if (Regex.IsMatch(txtNewstreet.Text, @"^[0-9a-zA-Z \s]+$"))
                                {
                                    if (Regex.IsMatch(txtNewemail.Text, @"^[0-9a-zA-Z\s\@\.]+$"))
                                    {
                                        
                                        sqlite_datareader = sqlite_cmd.ExecuteReader();
                                        MessageBox.Show("Record Updated!");
                                        lBoxallcustomers.Refresh();
                                        txteditcustid.Clear();
                                        txtNewforename.Clear();
                                        txtNewsurname.Clear();
                                        txtNewstreet.Clear();
                                        txtNewemail.Clear();
                                        txtNewpassword.Clear();
                                        sqlite_datareader.Close();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Customer's New Email can not have special characters other that '@' and '.'!");

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Customer's New Street can not have numbers or special characters");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Customer's New Surname can not have numbers or special characters");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Customer's New Forename can not have numbers or special characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Customer's ID can not have letters or special characters");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnShowallSus_Click(object sender, EventArgs e)
        {
            lBoxallcustomers.Items.Clear();

            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblCustomer";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string FNAME = sqlite_datareader.GetString(0);
                    string SNAME = sqlite_datareader.GetString(1);
                    string STREET = sqlite_datareader.GetString(2);
                    string EMAIL = sqlite_datareader.GetString(3);
                    string PASSWORD = sqlite_datareader.GetString(4);
                    int UNIQUEID = sqlite_datareader.GetInt32(5);
                    lBoxallcustomers.Items.Add("ID:" + UNIQUEID + ", Forename: " +FNAME+", Surname: " + SNAME+", Street: "+ STREET+", Email: " + EMAIL +", Encrypted Password: " +PASSWORD);
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new NewCustomerCreation();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }
        private void StaffviewCustomerRecords_Load(object sender, EventArgs e)
        {

        }
    }
}