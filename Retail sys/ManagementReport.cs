using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Retail_sys
{
    public partial class ManagementReport : Form
    {
        string outputto = "{0,-15}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}";
        string outbutto = "{0,-15}\t{1,-15}\t{2,-20}\t{3,-20}\t{4,-20}\t{5,-15}";


        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        public ManagementReport()
        {
            InitializeComponent();
        }

        private void btnTextFileRprt_Click(object sender, EventArgs e)
        {
            Process.Start("ManagementReport.txt");
        }

        private void btnexitsys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            var opencustform = new ManagementArea();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnShowallStaff_Click(object sender, EventArgs e)
        {
            int charlengthusername = textcustID.Text.Length;

            if (textcustID.Text == "")
            {
                MessageBox.Show("No entered ID to search records for ");
                textcustID.Clear();
                lBoxShowCusReport.Refresh();
            }
            else if (charlengthusername <= 4 || charlengthusername >= 6)
            {
                MessageBox.Show("Details Entered Don't Meet The Expected Character Length Requirements. Try Again.");
                textcustID.Clear(); lBoxShowCusReport.Refresh();

            }
            if (Regex.IsMatch(textcustID.Text, @"^[0-9 \s]+$"))
            {
                sqlite_conn = new SQLiteConnection("Data Source=RetailSystem.db; Version = 3; New = True; Compress = True;");
                try
                {
                    SQLiteDataReader sqlite_datareader;
                    sqlite_conn.Open();
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM TblBasketArchive WHERE CustID = @CustID";
                    sqlite_cmd.Parameters.AddWithValue("@CustID", textcustID.Text);

                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    while (sqlite_datareader.Read())
                    {
                        int ID = sqlite_datareader.GetInt32(0);
                        string ITEMNAME = sqlite_datareader.GetString(1);
                        int QUANTITY = sqlite_datareader.GetInt32(2);
                        int PRICE = sqlite_datareader.GetInt32(3);
                        int GROSSCOST = sqlite_datareader.GetInt32(4);
                        string DATE = sqlite_datareader.GetString(5);

                        lBoxShowCusReport.Items.Add(string.Format(outbutto, ID, ITEMNAME, QUANTITY, PRICE, GROSSCOST, DATE));
                        textcustID.Clear();

                    }
                    sqlite_datareader.Close();
                    sqlite_conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("ID cant have special characters or letters");
            }
        }



        

        private void ManagementReport_Load(object sender, EventArgs e)
        {
            lBoxShowCusReport.Items.Add(string.Format(outputto, "Cust ID", "Item Name", "Quantity", "Price", "Gross Cost", "Date Of Purchase"));

        }
    }
}
