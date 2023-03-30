
namespace Retail_sys
{
    partial class ManagementArea
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
            this.btngoback = new System.Windows.Forms.Button();
            this.btntoeditstaffinfo = new System.Windows.Forms.Button();
            this.btntosalesrecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngoback
            // 
            this.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btngoback.Location = new System.Drawing.Point(18, 362);
            this.btngoback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(345, 42);
            this.btngoback.TabIndex = 15;
            this.btngoback.Text = "--> Return to Login Area";
            this.btngoback.UseVisualStyleBackColor = true;
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // btntoeditstaffinfo
            // 
            this.btntoeditstaffinfo.BackColor = System.Drawing.Color.Black;
            this.btntoeditstaffinfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btntoeditstaffinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoeditstaffinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntoeditstaffinfo.Location = new System.Drawing.Point(18, 50);
            this.btntoeditstaffinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntoeditstaffinfo.Name = "btntoeditstaffinfo";
            this.btntoeditstaffinfo.Size = new System.Drawing.Size(345, 86);
            this.btntoeditstaffinfo.TabIndex = 17;
            this.btntoeditstaffinfo.Text = "--> Staff Management";
            this.btntoeditstaffinfo.UseVisualStyleBackColor = false;
            this.btntoeditstaffinfo.Click += new System.EventHandler(this.btntoeditstaffinfo_Click);
            // 
            // btntosalesrecords
            // 
            this.btntosalesrecords.BackColor = System.Drawing.Color.Black;
            this.btntosalesrecords.Cursor = System.Windows.Forms.Cursors.Default;
            this.btntosalesrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntosalesrecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntosalesrecords.Location = new System.Drawing.Point(18, 157);
            this.btntosalesrecords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntosalesrecords.Name = "btntosalesrecords";
            this.btntosalesrecords.Size = new System.Drawing.Size(345, 86);
            this.btntosalesrecords.TabIndex = 18;
            this.btntosalesrecords.Text = "--> View Sales Records";
            this.btntosalesrecords.UseVisualStyleBackColor = false;
            this.btntosalesrecords.Click += new System.EventHandler(this.btntosalesrecords_Click);
            // 
            // ManagementArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 429);
            this.Controls.Add(this.btntosalesrecords);
            this.Controls.Add(this.btntoeditstaffinfo);
            this.Controls.Add(this.btngoback);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagementArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementArea";
            this.Load += new System.EventHandler(this.ManagementArea_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btngoback;
        private System.Windows.Forms.Button btntoeditstaffinfo;
        private System.Windows.Forms.Button btntosalesrecords;
    }
}