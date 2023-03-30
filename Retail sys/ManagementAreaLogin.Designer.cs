
namespace Retail_sys
{
    partial class ManagementAreaLogin
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
            this.txtmanagercheck = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnMainMenuRtrn = new System.Windows.Forms.Button();
            this.btnExitSys = new System.Windows.Forms.Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmanagercheck
            // 
            this.txtmanagercheck.BackColor = System.Drawing.Color.Black;
            this.txtmanagercheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanagercheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtmanagercheck.Location = new System.Drawing.Point(31, 38);
            this.txtmanagercheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmanagercheck.Name = "txtmanagercheck";
            this.txtmanagercheck.Size = new System.Drawing.Size(144, 20);
            this.txtmanagercheck.TabIndex = 1;
            this.txtmanagercheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEnter.Location = new System.Drawing.Point(28, 12);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(147, 18);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Enter A Manager\'s ID";
            // 
            // btnMainMenuRtrn
            // 
            this.btnMainMenuRtrn.BackColor = System.Drawing.Color.Black;
            this.btnMainMenuRtrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuRtrn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMainMenuRtrn.Location = new System.Drawing.Point(9, 116);
            this.btnMainMenuRtrn.Name = "btnMainMenuRtrn";
            this.btnMainMenuRtrn.Size = new System.Drawing.Size(83, 27);
            this.btnMainMenuRtrn.TabIndex = 31;
            this.btnMainMenuRtrn.Text = "--> Go Back";
            this.btnMainMenuRtrn.UseVisualStyleBackColor = false;
            this.btnMainMenuRtrn.Click += new System.EventHandler(this.btnMainMenuRtrn_Click);
            // 
            // btnExitSys
            // 
            this.btnExitSys.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExitSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExitSys.Location = new System.Drawing.Point(107, 116);
            this.btnExitSys.Name = "btnExitSys";
            this.btnExitSys.Size = new System.Drawing.Size(86, 27);
            this.btnExitSys.TabIndex = 32;
            this.btnExitSys.Text = "--> Exit";
            this.btnExitSys.UseVisualStyleBackColor = false;
            this.btnExitSys.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblManager.Location = new System.Drawing.Point(35, 153);
            this.lblManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(133, 13);
            this.lblManager.TabIndex = 33;
            this.lblManager.Text = "(Existing Manager : 69210)";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(9, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 35);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManagementAreaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(205, 181);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btnExitSys);
            this.Controls.Add(this.btnMainMenuRtrn);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtmanagercheck);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagementAreaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementAreaLogin";
            this.Load += new System.EventHandler(this.ManagementAreaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmanagercheck;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnMainMenuRtrn;
        private System.Windows.Forms.Button btnExitSys;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblManager;
    }
}