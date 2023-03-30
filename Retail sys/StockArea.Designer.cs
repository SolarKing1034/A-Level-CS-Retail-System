
namespace Retail_sys
{
    partial class StockArea
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
            this.btnexits = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbacktostaffmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexits
            // 
            this.btnexits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexits.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexits.Location = new System.Drawing.Point(12, 386);
            this.btnexits.Name = "btnexits";
            this.btnexits.Size = new System.Drawing.Size(776, 43);
            this.btnexits.TabIndex = 5;
            this.btnexits.Text = "--> Exit System";
            this.btnexits.UseVisualStyleBackColor = true;
            this.btnexits.Click += new System.EventHandler(this.btnexits_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "https://codezips.com/csharp/inventory-management-system-using-c-with-source-code/" +
    "#google_vignette";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbacktostaffmenu
            // 
            this.btnbacktostaffmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbacktostaffmenu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacktostaffmenu.Location = new System.Drawing.Point(12, 337);
            this.btnbacktostaffmenu.Name = "btnbacktostaffmenu";
            this.btnbacktostaffmenu.Size = new System.Drawing.Size(776, 43);
            this.btnbacktostaffmenu.TabIndex = 3;
            this.btnbacktostaffmenu.Text = "--> Main Menu";
            this.btnbacktostaffmenu.UseVisualStyleBackColor = true;
            this.btnbacktostaffmenu.Click += new System.EventHandler(this.btnbacktostaffmenu_Click);
            // 
            // StockArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexits);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbacktostaffmenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "StockArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexits;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbacktostaffmenu;
    }
}