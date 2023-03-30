using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Retail_sys
{
    public partial class StaffInformation : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;

        public StaffInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new ManagementArea();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaddstaff_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            Random stofrndiD = new Random();
            int RandomID;
            RandomID = stofrndiD.Next(10000, 99999);
            SQLiteDataReader sqlite_datareader;
            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO TblStaff(StaffForename, StaffSurname, StaffPosition, StaffRandID) VALUES(@StaffForename, @StaffSurname, @StaffPosition, @StaffRandID); ";
            sqlite_cmd.Parameters.AddWithValue("@StaffForename", txtforenamecreation.Text);
            sqlite_cmd.Parameters.AddWithValue("@StaffSurname", txtsurnamecreation.Text);
            sqlite_cmd.Parameters.AddWithValue("@StaffPosition", txtpositioncreation.Text);
            sqlite_cmd.Parameters.AddWithValue("@StaffRandID", RandomID);
            string IDTOSTRING = RandomID.ToString();

            if (txtforenamecreation.Text == "")
            {
                throw new ArgumentNullException("First Name has been left empty!");
            }
            if (txtsurnamecreation.Text == "")
            {
                throw new ArgumentNullException("Surname has been left empty!");
            }
            if (txtpositioncreation.Text == "")
            {
                throw new ArgumentNullException("Position has been left empty!");
            }
            if (Regex.IsMatch(txtforenamecreation.Text, @"^[a-zA-Z\s]+$"))
            {
                if (Regex.IsMatch(txtsurnamecreation.Text, @"^[a-zA-Z\s]+$"))
                {
                    if (Regex.IsMatch(txtpositioncreation.Text, @"^[a-zA-Z \s]+$"))
                    {
                        sqlite_datareader = sqlite_cmd.ExecuteReader();
                        MessageBox.Show("Acount Created! Your ID number is: " + IDTOSTRING);
                        txtforenamecreation.Clear();
                        txtsurnamecreation.Clear();
                        sqlite_datareader.Close();
                        sqlite_conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Staff's position can not have numbers or special characters");
                    }
                }
                else
                {
                    MessageBox.Show("Staff's Surname can not have numbers or special characters");
                }
            }
            else
            {
                MessageBox.Show("Staff's Forename can not have numbers or special characters");
            }
            sqlite_conn.Close();

        }
        private void btnShowallStaff_Click(object sender, EventArgs e)
        {
            lBoxallcstaff.Items.Clear();
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM TblStaff";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string FORENAME = sqlite_datareader.GetString(0);
                    string SURNAME = sqlite_datareader.GetString(1);
                    string POSITION = sqlite_datareader.GetString(2);
                    int UNIQUEID = sqlite_datareader.GetInt32(5);
                    lBoxallcstaff.Items.Add(FORENAME + ", " + SURNAME + ", " + POSITION + ", " + UNIQUEID);
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditstaffRecs_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteDataReader sqlite_datareader;
                int idlengthcheck = txteditid.Text.Length;
                if (idlengthcheck <= 4 || idlengthcheck >= 6)
                {
                    throw new ArgumentNullException("ID does not meet the character requirement! Try Again!");
                }
                else
                {
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    string IDCustCheck = txteditid.Text;
                    sqlite_cmd.CommandText = "UPDATE TblStaff SET StaffForename = @NewCustForename ,StaffSurname= @NewCustSurname ,StaffPosition= @NewCustStreet WHERE StaffRandID=@StaffIdCheck; ";
                    sqlite_cmd.Parameters.AddWithValue("@NewCustForename", txtNewforename.Text);
                    sqlite_cmd.Parameters.AddWithValue("@NewCustSurname", txtNewsurname.Text);
                    sqlite_cmd.Parameters.AddWithValue("@NewCustStreet", txtNewStaffRole.Text);
                    sqlite_cmd.Parameters.AddWithValue("@StaffIdCheck", IDCustCheck);
                    if (txtNewforename.Text == "")
                    {
                        throw new ArgumentNullException("First Name has been left empty!");
                    }
                    if (txtNewsurname.Text == "")
                    {
                        throw new ArgumentNullException("Surname has been left empty!");
                    }
                    if (txtNewStaffRole.Text == "")
                    {
                        throw new ArgumentNullException("Staff Role has been left empty!");
                    }

                    if (Regex.IsMatch(txtNewforename.Text, @"^[a-zA-Z \s]+$"))
                    {
                        if (Regex.IsMatch(txtNewsurname.Text, @"^[a-zA-Z \s]+$"))
                        {
                            if (Regex.IsMatch(txtNewStaffRole.Text, @"^[a-zA-Z \s]+$"))
                            {
                                sqlite_datareader = sqlite_cmd.ExecuteReader();
                                MessageBox.Show("Record Updated!");
                                lBoxallcstaff.Refresh();
                                txtNewforename.Clear();
                                txtNewsurname.Clear();

                                sqlite_datareader.Close();
                            }
                            else
                            {
                               MessageBox.Show("Staff's New Position can not have numbers or special characters");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Staff's New Surname can not have numbers or special characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Staff's New Forename can not have numbers or special characters");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndeletestaff_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
            try
            {
                int idlengthcheck = txtdeleteid.Text.Length;
                sqlite_conn.Open();
                SQLiteDataReader sqlite_datareader;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM TblStaff WHERE StaffRandID = @StaffRandID";
                sqlite_cmd.Parameters.AddWithValue("@StaffRandID", txtdeleteid.Text);
                if (txtdeleteid.Text == "" || (idlengthcheck <= 4 || idlengthcheck >= 6))
                {
                    throw new ArgumentNullException("ID entered does not meet character requirements. Try again");
                }
                if (Regex.IsMatch(txtdeleteid.Text, @"^[0-9\s]+$"))
                {
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    MessageBox.Show("Record Deleted!");
                    lBoxallcstaff.Refresh();
                    txtdeleteid.Clear();
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
    }
}
