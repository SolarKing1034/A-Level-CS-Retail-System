
namespace Retail_sys
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnexitsys = new System.Windows.Forms.Button();
            this.btnMainmenurtrn = new System.Windows.Forms.Button();
            this.btnemailmereceipt = new System.Windows.Forms.Button();
            this.txtdisplayloggedinuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailToSendReceipt = new System.Windows.Forms.TextBox();
            this.labelenteremail = new System.Windows.Forms.Label();
            this.btnUseDifferentEmails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitsys
            // 
            this.btnexitsys.BackColor = System.Drawing.Color.Black;
            this.btnexitsys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitsys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnexitsys.Location = new System.Drawing.Point(123, 256);
            this.btnexitsys.Name = "btnexitsys";
            this.btnexitsys.Size = new System.Drawing.Size(102, 28);
            this.btnexitsys.TabIndex = 11;
            this.btnexitsys.Text = "--> Exit System";
            this.btnexitsys.UseVisualStyleBackColor = false;
            this.btnexitsys.Click += new System.EventHandler(this.btnexitsys_Click);
            // 
            // btnMainmenurtrn
            // 
            this.btnMainmenurtrn.BackColor = System.Drawing.Color.Black;
            this.btnMainmenurtrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainmenurtrn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMainmenurtrn.Location = new System.Drawing.Point(11, 256);
            this.btnMainmenurtrn.Name = "btnMainmenurtrn";
            this.btnMainmenurtrn.Size = new System.Drawing.Size(100, 28);
            this.btnMainmenurtrn.TabIndex = 10;
            this.btnMainmenurtrn.Text = "--> Go Back";
            this.btnMainmenurtrn.UseVisualStyleBackColor = false;
            this.btnMainmenurtrn.Click += new System.EventHandler(this.btnMainmenurtrn_Click);
            // 
            // btnemailmereceipt
            // 
            this.btnemailmereceipt.BackColor = System.Drawing.Color.Black;
            this.btnemailmereceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemailmereceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnemailmereceipt.Location = new System.Drawing.Point(19, 194);
            this.btnemailmereceipt.Name = "btnemailmereceipt";
            this.btnemailmereceipt.Size = new System.Drawing.Size(199, 29);
            this.btnemailmereceipt.TabIndex = 12;
            this.btnemailmereceipt.Text = "--> Email Me A Reciept";
            this.btnemailmereceipt.UseVisualStyleBackColor = false;
            this.btnemailmereceipt.Visible = false;
            this.btnemailmereceipt.Click += new System.EventHandler(this.btnemailmereceipt_Click);
            // 
            // txtdisplayloggedinuser
            // 
            this.txtdisplayloggedinuser.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtdisplayloggedinuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplayloggedinuser.ForeColor = System.Drawing.Color.Yellow;
            this.txtdisplayloggedinuser.Location = new System.Drawing.Point(111, 7);
            this.txtdisplayloggedinuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtdisplayloggedinuser.Name = "txtdisplayloggedinuser";
            this.txtdisplayloggedinuser.Size = new System.Drawing.Size(108, 18);
            this.txtdisplayloggedinuser.TabIndex = 31;
            this.txtdisplayloggedinuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 9);
            this.label2.TabIndex = 30;
            this.label2.Text = "Currently Logged In as: ";
            // 
            // txtEmailToSendReceipt
            // 
            this.txtEmailToSendReceipt.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtEmailToSendReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailToSendReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEmailToSendReceipt.Location = new System.Drawing.Point(19, 151);
            this.txtEmailToSendReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailToSendReceipt.Name = "txtEmailToSendReceipt";
            this.txtEmailToSendReceipt.Size = new System.Drawing.Size(200, 20);
            this.txtEmailToSendReceipt.TabIndex = 34;
            this.txtEmailToSendReceipt.Visible = false;
            this.txtEmailToSendReceipt.TextChanged += new System.EventHandler(this.txtEmailToSendReceipt_TextChanged);
            // 
            // labelenteremail
            // 
            this.labelenteremail.AutoSize = true;
            this.labelenteremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenteremail.Location = new System.Drawing.Point(35, 136);
            this.labelenteremail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelenteremail.Name = "labelenteremail";
            this.labelenteremail.Size = new System.Drawing.Size(166, 13);
            this.labelenteremail.TabIndex = 35;
            this.labelenteremail.Text = "Enter Email To Send Receipt To: ";
            this.labelenteremail.Visible = false;
            // 
            // btnUseDifferentEmails
            // 
            this.btnUseDifferentEmails.BackColor = System.Drawing.Color.Black;
            this.btnUseDifferentEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseDifferentEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseDifferentEmails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUseDifferentEmails.Location = new System.Drawing.Point(19, 63);
            this.btnUseDifferentEmails.Name = "btnUseDifferentEmails";
            this.btnUseDifferentEmails.Size = new System.Drawing.Size(198, 48);
            this.btnUseDifferentEmails.TabIndex = 37;
            this.btnUseDifferentEmails.Text = "Enter an Email";
            this.btnUseDifferentEmails.UseVisualStyleBackColor = false;
            this.btnUseDifferentEmails.Click += new System.EventHandler(this.btnUseDifferentEmails_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(236, 294);
            this.Controls.Add(this.btnUseDifferentEmails);
            this.Controls.Add(this.labelenteremail);
            this.Controls.Add(this.txtEmailToSendReceipt);
            this.Controls.Add(this.txtdisplayloggedinuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnemailmereceipt);
            this.Controls.Add(this.btnexitsys);
            this.Controls.Add(this.btnMainmenurtrn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexitsys;
        private System.Windows.Forms.Button btnMainmenurtrn;
        private System.Windows.Forms.Button btnemailmereceipt;
        private System.Windows.Forms.TextBox txtdisplayloggedinuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailToSendReceipt;
        private System.Windows.Forms.Label labelenteremail;
        private System.Windows.Forms.Button btnUseDifferentEmails;
    }
}