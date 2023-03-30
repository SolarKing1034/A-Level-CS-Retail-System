
namespace Retail_sys
{
    partial class StaffandManagementLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btngoback = new System.Windows.Forms.Button();
            this.btnManagementSystem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(67, 48);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 56);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "--> Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btngoback
            // 
            this.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngoback.Location = new System.Drawing.Point(66, 113);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(230, 27);
            this.btngoback.TabIndex = 14;
            this.btngoback.Text = "--> Return to Main Menu";
            this.btngoback.UseVisualStyleBackColor = true;
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // btnManagementSystem
            // 
            this.btnManagementSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManagementSystem.Location = new System.Drawing.Point(66, 148);
            this.btnManagementSystem.Name = "btnManagementSystem";
            this.btnManagementSystem.Size = new System.Drawing.Size(231, 56);
            this.btnManagementSystem.TabIndex = 15;
            this.btnManagementSystem.Text = "--> Management Area";
            this.btnManagementSystem.UseVisualStyleBackColor = true;
            this.btnManagementSystem.Click += new System.EventHandler(this.btnManagementSystem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(119, 22);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(177, 20);
            this.txtStaffID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Staff ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Staff Accounts must be registered in Management Area";
            // 
            // StaffandManagementLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(365, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.btnManagementSystem);
            this.Controls.Add(this.btngoback);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "StaffandManagementLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffandManagementLogin";
            this.Load += new System.EventHandler(this.StaffandManagementLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btngoback;
        private System.Windows.Forms.Button btnManagementSystem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}