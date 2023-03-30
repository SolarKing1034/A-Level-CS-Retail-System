namespace Retail_sys
{
    partial class ManagementReport
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
            this.lBoxShowCusReport = new System.Windows.Forms.ListBox();
            this.btnShowallRecs = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTextFileRprt = new System.Windows.Forms.Button();
            this.btngoback = new System.Windows.Forms.Button();
            this.btnexitsys = new System.Windows.Forms.Button();
            this.textcustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBoxShowCusReport
            // 
            this.lBoxShowCusReport.BackColor = System.Drawing.Color.Black;
            this.lBoxShowCusReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxShowCusReport.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxShowCusReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lBoxShowCusReport.FormattingEnabled = true;
            this.lBoxShowCusReport.HorizontalScrollbar = true;
            this.lBoxShowCusReport.ItemHeight = 15;
            this.lBoxShowCusReport.Location = new System.Drawing.Point(251, 32);
            this.lBoxShowCusReport.Name = "lBoxShowCusReport";
            this.lBoxShowCusReport.Size = new System.Drawing.Size(814, 302);
            this.lBoxShowCusReport.TabIndex = 75;
            // 
            // btnShowallRecs
            // 
            this.btnShowallRecs.BackColor = System.Drawing.Color.Black;
            this.btnShowallRecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowallRecs.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowallRecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowallRecs.Location = new System.Drawing.Point(7, 98);
            this.btnShowallRecs.Name = "btnShowallRecs";
            this.btnShowallRecs.Size = new System.Drawing.Size(230, 68);
            this.btnShowallRecs.TabIndex = 77;
            this.btnShowallRecs.Text = "Show in listbox";
            this.btnShowallRecs.UseVisualStyleBackColor = false;
            this.btnShowallRecs.Click += new System.EventHandler(this.btnShowallStaff_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(7, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 30);
            this.label16.TabIndex = 76;
            this.label16.Text = "Management Reports";
            // 
            // btnTextFileRprt
            // 
            this.btnTextFileRprt.BackColor = System.Drawing.Color.Black;
            this.btnTextFileRprt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextFileRprt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextFileRprt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTextFileRprt.Location = new System.Drawing.Point(7, 173);
            this.btnTextFileRprt.Name = "btnTextFileRprt";
            this.btnTextFileRprt.Size = new System.Drawing.Size(230, 68);
            this.btnTextFileRprt.TabIndex = 78;
            this.btnTextFileRprt.Text = "View as Text File";
            this.btnTextFileRprt.UseVisualStyleBackColor = false;
            this.btnTextFileRprt.Click += new System.EventHandler(this.btnTextFileRprt_Click);
            // 
            // btngoback
            // 
            this.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngoback.Location = new System.Drawing.Point(7, 255);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(230, 27);
            this.btngoback.TabIndex = 79;
            this.btngoback.Text = "--> Go Back";
            this.btngoback.UseVisualStyleBackColor = true;
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // btnexitsys
            // 
            this.btnexitsys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitsys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnexitsys.Location = new System.Drawing.Point(7, 298);
            this.btnexitsys.Name = "btnexitsys";
            this.btnexitsys.Size = new System.Drawing.Size(230, 27);
            this.btnexitsys.TabIndex = 80;
            this.btnexitsys.Text = "--> Exit System";
            this.btnexitsys.UseVisualStyleBackColor = true;
            this.btnexitsys.Click += new System.EventHandler(this.btnexitsys_Click);
            // 
            // textcustID
            // 
            this.textcustID.BackColor = System.Drawing.SystemColors.InfoText;
            this.textcustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcustID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textcustID.Location = new System.Drawing.Point(7, 59);
            this.textcustID.Margin = new System.Windows.Forms.Padding(2);
            this.textcustID.Name = "textcustID";
            this.textcustID.Size = new System.Drawing.Size(229, 20);
            this.textcustID.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "Enter Cust ID to view their purchase history";
            // 
            // ManagementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcustID);
            this.Controls.Add(this.btnexitsys);
            this.Controls.Add(this.btngoback);
            this.Controls.Add(this.btnTextFileRprt);
            this.Controls.Add(this.btnShowallRecs);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lBoxShowCusReport);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementReport";
            this.Load += new System.EventHandler(this.ManagementReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxShowCusReport;
        private System.Windows.Forms.Button btnShowallRecs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTextFileRprt;
        private System.Windows.Forms.Button btngoback;
        private System.Windows.Forms.Button btnexitsys;
        private System.Windows.Forms.TextBox textcustID;
        private System.Windows.Forms.Label label1;
    }
}