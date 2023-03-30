
namespace Retail_sys
{
    partial class CustomerMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncusstockarea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdisplayloggedinuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnexitsys
            // 
            this.btnexitsys.BackColor = System.Drawing.Color.Black;
            this.btnexitsys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitsys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnexitsys.Location = new System.Drawing.Point(12, 380);
            this.btnexitsys.Name = "btnexitsys";
            this.btnexitsys.Size = new System.Drawing.Size(259, 28);
            this.btnexitsys.TabIndex = 14;
            this.btnexitsys.Text = "--> Exit System";
            this.btnexitsys.UseVisualStyleBackColor = false;
            this.btnexitsys.Click += new System.EventHandler(this.btnexitsys_Click);
            // 
            // btnMainmenurtrn
            // 
            this.btnMainmenurtrn.BackColor = System.Drawing.Color.Black;
            this.btnMainmenurtrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainmenurtrn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMainmenurtrn.Location = new System.Drawing.Point(12, 345);
            this.btnMainmenurtrn.Name = "btnMainmenurtrn";
            this.btnMainmenurtrn.Size = new System.Drawing.Size(259, 29);
            this.btnMainmenurtrn.TabIndex = 13;
            this.btnMainmenurtrn.Text = "--> Log Out";
            this.btnMainmenurtrn.UseVisualStyleBackColor = false;
            this.btnMainmenurtrn.Click += new System.EventHandler(this.btnMainmenurtrn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Area";
            // 
            // btncusstockarea
            // 
            this.btncusstockarea.BackColor = System.Drawing.Color.Black;
            this.btncusstockarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncusstockarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncusstockarea.Location = new System.Drawing.Point(9, 138);
            this.btncusstockarea.Name = "btncusstockarea";
            this.btncusstockarea.Size = new System.Drawing.Size(259, 110);
            this.btncusstockarea.TabIndex = 10;
            this.btncusstockarea.Text = "Item Catalouge and Basket";
            this.btncusstockarea.UseVisualStyleBackColor = false;
            this.btncusstockarea.Click += new System.EventHandler(this.btncusstockarea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Currently Logged In as: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdisplayloggedinuser
            // 
            this.txtdisplayloggedinuser.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtdisplayloggedinuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplayloggedinuser.ForeColor = System.Drawing.Color.Yellow;
            this.txtdisplayloggedinuser.Location = new System.Drawing.Point(128, 6);
            this.txtdisplayloggedinuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdisplayloggedinuser.Name = "txtdisplayloggedinuser";
            this.txtdisplayloggedinuser.Size = new System.Drawing.Size(141, 20);
            this.txtdisplayloggedinuser.TabIndex = 16;
            this.txtdisplayloggedinuser.TextChanged += new System.EventHandler(this.txtdisplayloggedinuser_TextChanged);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(280, 419);
            this.Controls.Add(this.txtdisplayloggedinuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexitsys);
            this.Controls.Add(this.btnMainmenurtrn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncusstockarea);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "CustomerMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.CustomerMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexitsys;
        private System.Windows.Forms.Button btnMainmenurtrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncusstockarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdisplayloggedinuser;
    }
}