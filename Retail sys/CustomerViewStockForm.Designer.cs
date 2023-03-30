
namespace Retail_sys
{
    partial class CustomerViewStockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsystexits = new System.Windows.Forms.Button();
            this.btnbacktostaffmenus = new System.Windows.Forms.Button();
            this.AllItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemIDCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItemToBasket = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuantityToAdd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BtnAddToBasket = new System.Windows.Forms.Button();
            this.btnViewBasket = new System.Windows.Forms.Button();
            this.LBoxCurrentBasket = new System.Windows.Forms.ListBox();
            this.btntocheckout = new System.Windows.Forms.Button();
            this.txtdisplayloggedinuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearBasket = new System.Windows.Forms.Button();
            this.btnDeleteItemFromBasket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsystexits
            // 
            this.btnsystexits.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsystexits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsystexits.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsystexits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsystexits.Location = new System.Drawing.Point(544, 338);
            this.btnsystexits.Name = "btnsystexits";
            this.btnsystexits.Size = new System.Drawing.Size(317, 32);
            this.btnsystexits.TabIndex = 20;
            this.btnsystexits.Text = "--> Exit System";
            this.btnsystexits.UseVisualStyleBackColor = false;
            this.btnsystexits.Click += new System.EventHandler(this.btnsystexits_Click);
            // 
            // btnbacktostaffmenus
            // 
            this.btnbacktostaffmenus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbacktostaffmenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbacktostaffmenus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacktostaffmenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbacktostaffmenus.Location = new System.Drawing.Point(544, 296);
            this.btnbacktostaffmenus.Name = "btnbacktostaffmenus";
            this.btnbacktostaffmenus.Size = new System.Drawing.Size(317, 32);
            this.btnbacktostaffmenus.TabIndex = 19;
            this.btnbacktostaffmenus.Text = "--> Main Menu";
            this.btnbacktostaffmenus.UseVisualStyleBackColor = false;
            this.btnbacktostaffmenus.Click += new System.EventHandler(this.btnbacktostaffmenus_Click);
            // 
            // AllItemsDataGridView
            // 
            this.AllItemsDataGridView.AllowUserToAddRows = false;
            this.AllItemsDataGridView.AllowUserToDeleteRows = false;
            this.AllItemsDataGridView.AllowUserToResizeColumns = false;
            this.AllItemsDataGridView.AllowUserToResizeRows = false;
            this.AllItemsDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.AllItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllItemsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemQuantity,
            this.ItemPrice,
            this.ItemIDCode,
            this.AddItemToBasket,
            this.QuantityToAdd});
            this.AllItemsDataGridView.GridColor = System.Drawing.Color.Black;
            this.AllItemsDataGridView.Location = new System.Drawing.Point(11, 32);
            this.AllItemsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AllItemsDataGridView.Name = "AllItemsDataGridView";
            this.AllItemsDataGridView.RowHeadersWidth = 62;
            this.AllItemsDataGridView.RowTemplate.Height = 28;
            this.AllItemsDataGridView.Size = new System.Drawing.Size(514, 309);
            this.AllItemsDataGridView.TabIndex = 21;
            this.AllItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllItemsDataGridView_CellContentClick);
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 8;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 79;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemQuantity.HeaderText = "Item Quantity";
            this.ItemQuantity.MinimumWidth = 8;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            this.ItemQuantity.Width = 91;
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.MinimumWidth = 8;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 76;
            // 
            // ItemIDCode
            // 
            this.ItemIDCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemIDCode.HeaderText = "Item ID";
            this.ItemIDCode.MinimumWidth = 8;
            this.ItemIDCode.Name = "ItemIDCode";
            this.ItemIDCode.ReadOnly = true;
            this.ItemIDCode.Width = 63;
            // 
            // AddItemToBasket
            // 
            this.AddItemToBasket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AddItemToBasket.HeaderText = "Add To Basket";
            this.AddItemToBasket.MinimumWidth = 8;
            this.AddItemToBasket.Name = "AddItemToBasket";
            this.AddItemToBasket.Width = 76;
            // 
            // QuantityToAdd
            // 
            this.QuantityToAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QuantityToAdd.HeaderText = "Quantity To Add";
            this.QuantityToAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.QuantityToAdd.MinimumWidth = 8;
            this.QuantityToAdd.Name = "QuantityToAdd";
            this.QuantityToAdd.Width = 65;
            // 
            // BtnAddToBasket
            // 
            this.BtnAddToBasket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddToBasket.Location = new System.Drawing.Point(8, 343);
            this.BtnAddToBasket.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddToBasket.Name = "BtnAddToBasket";
            this.BtnAddToBasket.Size = new System.Drawing.Size(517, 32);
            this.BtnAddToBasket.TabIndex = 22;
            this.BtnAddToBasket.Text = "Add Items To Basket";
            this.BtnAddToBasket.UseVisualStyleBackColor = false;
            this.BtnAddToBasket.Click += new System.EventHandler(this.BtnAddToBasket_Click);
            // 
            // btnViewBasket
            // 
            this.btnViewBasket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewBasket.Location = new System.Drawing.Point(544, 11);
            this.btnViewBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewBasket.Name = "btnViewBasket";
            this.btnViewBasket.Size = new System.Drawing.Size(92, 37);
            this.btnViewBasket.TabIndex = 23;
            this.btnViewBasket.Text = "View Current Basket";
            this.btnViewBasket.UseVisualStyleBackColor = false;
            this.btnViewBasket.Click += new System.EventHandler(this.btnViewBasket_Click);
            // 
            // LBoxCurrentBasket
            // 
            this.LBoxCurrentBasket.BackColor = System.Drawing.Color.Black;
            this.LBoxCurrentBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBoxCurrentBasket.FormattingEnabled = true;
            this.LBoxCurrentBasket.HorizontalScrollbar = true;
            this.LBoxCurrentBasket.Location = new System.Drawing.Point(544, 52);
            this.LBoxCurrentBasket.Margin = new System.Windows.Forms.Padding(2);
            this.LBoxCurrentBasket.Name = "LBoxCurrentBasket";
            this.LBoxCurrentBasket.ScrollAlwaysVisible = true;
            this.LBoxCurrentBasket.Size = new System.Drawing.Size(318, 199);
            this.LBoxCurrentBasket.TabIndex = 24;
            // 
            // btntocheckout
            // 
            this.btntocheckout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntocheckout.Location = new System.Drawing.Point(544, 254);
            this.btntocheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btntocheckout.Name = "btntocheckout";
            this.btntocheckout.Size = new System.Drawing.Size(318, 37);
            this.btntocheckout.TabIndex = 25;
            this.btntocheckout.Text = "Proceed To Checkout";
            this.btntocheckout.UseVisualStyleBackColor = false;
            this.btntocheckout.Click += new System.EventHandler(this.btntocheckout_Click);
            // 
            // txtdisplayloggedinuser
            // 
            this.txtdisplayloggedinuser.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtdisplayloggedinuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplayloggedinuser.ForeColor = System.Drawing.Color.Yellow;
            this.txtdisplayloggedinuser.Location = new System.Drawing.Point(135, 8);
            this.txtdisplayloggedinuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtdisplayloggedinuser.Name = "txtdisplayloggedinuser";
            this.txtdisplayloggedinuser.Size = new System.Drawing.Size(134, 20);
            this.txtdisplayloggedinuser.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Currently Logged In as: ";
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearBasket.Location = new System.Drawing.Point(772, 11);
            this.btnClearBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.Size = new System.Drawing.Size(90, 37);
            this.btnClearBasket.TabIndex = 28;
            this.btnClearBasket.Text = "Clear Basket";
            this.btnClearBasket.UseVisualStyleBackColor = false;
            this.btnClearBasket.Click += new System.EventHandler(this.btnClearBasket_Click);
            // 
            // btnDeleteItemFromBasket
            // 
            this.btnDeleteItemFromBasket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteItemFromBasket.Location = new System.Drawing.Point(659, 11);
            this.btnDeleteItemFromBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteItemFromBasket.Name = "btnDeleteItemFromBasket";
            this.btnDeleteItemFromBasket.Size = new System.Drawing.Size(90, 37);
            this.btnDeleteItemFromBasket.TabIndex = 29;
            this.btnDeleteItemFromBasket.Text = "Delete Selected Item";
            this.btnDeleteItemFromBasket.UseVisualStyleBackColor = false;
            this.btnDeleteItemFromBasket.Click += new System.EventHandler(this.btnDeleteItemFromBasket_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 9);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select an Item In the Listbox To Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Leaving this window will clear the basket";
            // 
            // CustomerViewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(873, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteItemFromBasket);
            this.Controls.Add(this.btnClearBasket);
            this.Controls.Add(this.txtdisplayloggedinuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btntocheckout);
            this.Controls.Add(this.LBoxCurrentBasket);
            this.Controls.Add(this.btnViewBasket);
            this.Controls.Add(this.BtnAddToBasket);
            this.Controls.Add(this.AllItemsDataGridView);
            this.Controls.Add(this.btnsystexits);
            this.Controls.Add(this.btnbacktostaffmenus);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerViewStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.Load += new System.EventHandler(this.CustomerViewStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsystexits;
        private System.Windows.Forms.Button btnbacktostaffmenus;
        private System.Windows.Forms.DataGridView AllItemsDataGridView;
        private System.Windows.Forms.Button BtnAddToBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddItemToBasket;
        private System.Windows.Forms.DataGridViewComboBoxColumn QuantityToAdd;
        private System.Windows.Forms.Button btnViewBasket;
        private System.Windows.Forms.ListBox LBoxCurrentBasket;
        private System.Windows.Forms.Button btntocheckout;
        private System.Windows.Forms.TextBox txtdisplayloggedinuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearBasket;
        private System.Windows.Forms.Button btnDeleteItemFromBasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}