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
using System.Net;
using System.Net.Mail;


namespace Retail_sys
{
    public partial class Receipt : Form
    {

        public Receipt()
        {
            InitializeComponent();
        }
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
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
        }

        private void btnemailmereceipt_Click(object sender, EventArgs e)
        {
            string CustomeEmailToSendReceipt = txtEmailToSendReceipt.Text;
            // @todo: Validate email and throw error
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("16patu@gmail.com");
                mail.To.Add(CustomeEmailToSendReceipt);
                mail.Subject = "Hello World";
                mail.Body = "<h1>Hello</h1>";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("16patu@gmail.com", "oumgipnmpwlondnh");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                MessageBox.Show("Email Sent!");
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

        private void btnUseDifferentEmails_Click(object sender, EventArgs e)
        {
            labelenteremail.Show();
            txtEmailToSendReceipt.Show();
            btnemailmereceipt.Show();

        }
    }
}
