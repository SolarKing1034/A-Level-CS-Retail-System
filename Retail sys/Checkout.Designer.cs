
namespace Retail_sys
{
    partial class Checkout
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
            this.txtdisplayloggedinuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxOrderedItemsInfo = new System.Windows.Forms.ListBox();
            this.lBoxOrderedItemsPrice = new System.Windows.Forms.ListBox();
            this.btnbacktostaffmenus = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbTotals = new System.Windows.Forms.Label();
            this.lBoxQuantitys = new System.Windows.Forms.ListBox();
            this.lblQuan = new System.Windows.Forms.Label();
            this.btncompletetransaction = new System.Windows.Forms.Button();
            this.btnOrderToHom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdisplayloggedinuser
            // 
            this.txtdisplayloggedinuser.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtdisplayloggedinuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplayloggedinuser.ForeColor = System.Drawing.Color.Yellow;
            this.txtdisplayloggedinuser.Location = new System.Drawing.Point(101, 8);
            this.txtdisplayloggedinuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdisplayloggedinuser.Name = "txtdisplayloggedinuser";
            this.txtdisplayloggedinuser.ReadOnly = true;
            this.txtdisplayloggedinuser.Size = new System.Drawing.Size(108, 18);
            this.txtdisplayloggedinuser.TabIndex = 29;
            this.txtdisplayloggedinuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 9);
            this.label2.TabIndex = 28;
            this.label2.Text = "Currently Logged In as: ";
            // 
            // lBoxOrderedItemsInfo
            // 
            this.lBoxOrderedItemsInfo.BackColor = System.Drawing.Color.Black;
            this.lBoxOrderedItemsInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lBoxOrderedItemsInfo.FormattingEnabled = true;
            this.lBoxOrderedItemsInfo.Location = new System.Drawing.Point(9, 57);
            this.lBoxOrderedItemsInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBoxOrderedItemsInfo.Name = "lBoxOrderedItemsInfo";
            this.lBoxOrderedItemsInfo.Size = new System.Drawing.Size(65, 173);
            this.lBoxOrderedItemsInfo.TabIndex = 30;
            this.lBoxOrderedItemsInfo.SelectedIndexChanged += new System.EventHandler(this.lBoxOrderedItemsInfo_SelectedIndexChanged);
            // 
            // lBoxOrderedItemsPrice
            // 
            this.lBoxOrderedItemsPrice.BackColor = System.Drawing.Color.Black;
            this.lBoxOrderedItemsPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lBoxOrderedItemsPrice.FormattingEnabled = true;
            this.lBoxOrderedItemsPrice.Location = new System.Drawing.Point(145, 57);
            this.lBoxOrderedItemsPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBoxOrderedItemsPrice.Name = "lBoxOrderedItemsPrice";
            this.lBoxOrderedItemsPrice.Size = new System.Drawing.Size(63, 173);
            this.lBoxOrderedItemsPrice.TabIndex = 31;
            // 
            // btnbacktostaffmenus
            // 
            this.btnbacktostaffmenus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbacktostaffmenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbacktostaffmenus.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacktostaffmenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbacktostaffmenus.Location = new System.Drawing.Point(9, 335);
            this.btnbacktostaffmenus.Name = "btnbacktostaffmenus";
            this.btnbacktostaffmenus.Size = new System.Drawing.Size(198, 36);
            this.btnbacktostaffmenus.TabIndex = 34;
            this.btnbacktostaffmenus.Text = "--> Go Back";
            this.btnbacktostaffmenus.UseVisualStyleBackColor = false;
            this.btnbacktostaffmenus.Click += new System.EventHandler(this.btnbacktostaffmenus_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTotalCost.Location = new System.Drawing.Point(145, 244);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(63, 20);
            this.txtTotalCost.TabIndex = 36;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalCost.TextChanged += new System.EventHandler(this.txtTotalCost_TextChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(27, 34);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(32, 13);
            this.lblItem.TabIndex = 37;
            this.lblItem.Text = "Items";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(71, 246);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "Total Price";
            // 
            // lbTotals
            // 
            this.lbTotals.AutoSize = true;
            this.lbTotals.Location = new System.Drawing.Point(153, 34);
            this.lbTotals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotals.Name = "lbTotals";
            this.lbTotals.Size = new System.Drawing.Size(46, 13);
            this.lbTotals.TabIndex = 40;
            this.lbTotals.Text = "Total (£)";
            // 
            // lBoxQuantitys
            // 
            this.lBoxQuantitys.BackColor = System.Drawing.Color.Black;
            this.lBoxQuantitys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lBoxQuantitys.FormattingEnabled = true;
            this.lBoxQuantitys.Location = new System.Drawing.Point(78, 57);
            this.lBoxQuantitys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBoxQuantitys.Name = "lBoxQuantitys";
            this.lBoxQuantitys.Size = new System.Drawing.Size(65, 173);
            this.lBoxQuantitys.TabIndex = 41;
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(87, 34);
            this.lblQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(46, 13);
            this.lblQuan.TabIndex = 42;
            this.lblQuan.Text = "Quantity";
            // 
            // btncompletetransaction
            // 
            this.btncompletetransaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncompletetransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompletetransaction.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompletetransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncompletetransaction.Location = new System.Drawing.Point(9, 269);
            this.btncompletetransaction.Name = "btncompletetransaction";
            this.btncompletetransaction.Size = new System.Drawing.Size(198, 27);
            this.btncompletetransaction.TabIndex = 43;
            this.btncompletetransaction.Text = "--> Pay Now";
            this.btncompletetransaction.UseVisualStyleBackColor = false;
            this.btncompletetransaction.Click += new System.EventHandler(this.btncompletetransaction_Click);
            // 
            // btnOrderToHom
            // 
            this.btnOrderToHom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrderToHom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderToHom.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderToHom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderToHom.Location = new System.Drawing.Point(9, 302);
            this.btnOrderToHom.Name = "btnOrderToHom";
            this.btnOrderToHom.Size = new System.Drawing.Size(198, 27);
            this.btnOrderToHom.TabIndex = 44;
            this.btnOrderToHom.Text = "--> Order To Home";
            this.btnOrderToHom.UseVisualStyleBackColor = false;
            this.btnOrderToHom.Click += new System.EventHandler(this.button1_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(216, 380);
            this.Controls.Add(this.btnOrderToHom);
            this.Controls.Add(this.btncompletetransaction);
            this.Controls.Add(this.lblQuan);
            this.Controls.Add(this.lBoxQuantitys);
            this.Controls.Add(this.lbTotals);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.btnbacktostaffmenus);
            this.Controls.Add(this.lBoxOrderedItemsPrice);
            this.Controls.Add(this.lBoxOrderedItemsInfo);
            this.Controls.Add(this.txtdisplayloggedinuser);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplayloggedinuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxOrderedItemsInfo;
        private System.Windows.Forms.ListBox lBoxOrderedItemsPrice;
        private System.Windows.Forms.Button btnbacktostaffmenus;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbTotals;
        private System.Windows.Forms.ListBox lBoxQuantitys;
        private System.Windows.Forms.Label lblQuan;
        private System.Windows.Forms.Button btncompletetransaction;
        private System.Windows.Forms.Button btnOrderToHom;
    }
}