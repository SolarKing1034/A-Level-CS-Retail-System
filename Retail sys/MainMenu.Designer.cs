
namespace Retail_sys
{
    partial class MainMenu
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
            this.btnexitbuton = new System.Windows.Forms.Button();
            this.btnToStaff = new System.Windows.Forms.Button();
            this.btnToSustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitbuton
            // 
            this.btnexitbuton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexitbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitbuton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitbuton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnexitbuton.Location = new System.Drawing.Point(1064, 11);
            this.btnexitbuton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexitbuton.Name = "btnexitbuton";
            this.btnexitbuton.Size = new System.Drawing.Size(178, 340);
            this.btnexitbuton.TabIndex = 9;
            this.btnexitbuton.Text = "--> Exit System";
            this.btnexitbuton.UseVisualStyleBackColor = false;
            this.btnexitbuton.Click += new System.EventHandler(this.btnexitbuton_Click);
            // 
            // btnToStaff
            // 
            this.btnToStaff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStaff.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToStaff.Location = new System.Drawing.Point(537, 11);
            this.btnToStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToStaff.Name = "btnToStaff";
            this.btnToStaff.Size = new System.Drawing.Size(502, 340);
            this.btnToStaff.TabIndex = 8;
            this.btnToStaff.Text = "--> Staff + Management Area";
            this.btnToStaff.UseVisualStyleBackColor = false;
            this.btnToStaff.Click += new System.EventHandler(this.btnToStaff_Click);
            // 
            // btnToSustomer
            // 
            this.btnToSustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToSustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSustomer.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToSustomer.Location = new System.Drawing.Point(13, 11);
            this.btnToSustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToSustomer.Name = "btnToSustomer";
            this.btnToSustomer.Size = new System.Drawing.Size(502, 340);
            this.btnToSustomer.TabIndex = 7;
            this.btnToSustomer.Text = "--> Customer Area";
            this.btnToSustomer.UseVisualStyleBackColor = false;
            this.btnToSustomer.Click += new System.EventHandler(this.btnToSustomer_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1257, 363);
            this.Controls.Add(this.btnexitbuton);
            this.Controls.Add(this.btnToStaff);
            this.Controls.Add(this.btnToSustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitbuton;
        private System.Windows.Forms.Button btnToStaff;
        private System.Windows.Forms.Button btnToSustomer;
    }
}