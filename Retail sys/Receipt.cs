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
    public partial class Receipt : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        private static Guid FolderDownloads = new Guid("374DE290-123F-4565-9164-39C4925E467B");
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int SHGetKnownFolderPath(ref Guid id, int flags, IntPtr token, out IntPtr path);

        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
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
                string EMAIL = sqlite_datareader.GetString(3);
                txtdisplayloggedinuser.Text = UserInfo.CustomerID + ", " + FNAME + " " + SNAME;
                UserInfo.Email = EMAIL;
            }
            sqlite_datareader.Close();




            File.WriteAllText(@"reciept.txt", "");

            using (TextWriter tw = File.AppendText(@"Reciept.txt"))
            {
                tw.WriteLine("Items:");
                foreach (string i in Basket.ItemInformationFromItemsToBeAddedToBasket)
                {
                    tw.WriteLine(i);
                }
                tw.WriteLine("\nQuantities:");
                foreach (int r in Basket.ItemQuantity)
                {
                    tw.WriteLine(r);
                }
                tw.WriteLine("\nPrices:");
                foreach (int s in Basket.ItemPrices)
                {
                    tw.WriteLine("£" + s);
                }
                tw.WriteLine(string.Format("\nTotal Price: £{0} ", Basket.TotalPriceOfAllItemsPurchased.ToString()));
                DateTime now = DateTime.Now;

                tw.WriteLine(string.Format("Purchase made at: " + now));


            }

           
        }
        private void btnemailmereceipt_Click(object sender, EventArgs e)
        {

            string CustomeEmailToSendReceipt = txtEmailToSendReceipt.Text;
            new EmailAddressAttribute().IsValid(CustomeEmailToSendReceipt);




            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("automatedreceiptemail@gmail.com");
                mail.To.Add(CustomeEmailToSendReceipt);
                mail.Subject = "Customer Reciept";
                mail.IsBodyHtml = true;
                // send attatchment of reciept by converting db table to txt file
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment("reciept.txt");
                mail.Attachments.Add(attachment);

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("automatedreceiptemail@gmail.com", Key.keykey);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                MessageBox.Show("Email Sent - May take time recieve");
            }
        }

        private void btnMainmenurtrn_Click(object sender, EventArgs e)
        {

            UserInfo.Email = "";
            labelenteremail.Hide();
            txtEmailToSendReceipt.Clear();
            txtEmailToSendReceipt.Hide();
            btnemailmereceipt.Hide();
            this.Hide();
            var opencustform = new Checkout();
            opencustform.Closed += (s, args) => this.Close();
            opencustform.Show();
        }

        private void btnexitsys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUseEmailOnAcc_Click(object sender, EventArgs e)
        {
            string EmailToSendReciept = UserInfo.Email;

        }

        private void btnUseDifferentEmails_Click(object sender, EventArgs e)
        {
            labelenteremail.Show();
            txtEmailToSendReceipt.Show();
            btnemailmereceipt.Show();

        }

        private void txtEmailToSendReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
