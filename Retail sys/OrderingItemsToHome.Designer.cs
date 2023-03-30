
namespace Retail_sys
{
    partial class OrderingItemsToHome
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetRoute = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.btnDistance = new System.Windows.Forms.Button();
            this.btnMapReset = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitsys
            // 
            this.btnexitsys.BackColor = System.Drawing.Color.Black;
            this.btnexitsys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitsys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnexitsys.Location = new System.Drawing.Point(769, 429);
            this.btnexitsys.Name = "btnexitsys";
            this.btnexitsys.Size = new System.Drawing.Size(347, 45);
            this.btnexitsys.TabIndex = 16;
            this.btnexitsys.Text = "--> Exit System";
            this.btnexitsys.UseVisualStyleBackColor = false;
            this.btnexitsys.Click += new System.EventHandler(this.btnexitsys_Click);
            // 
            // btnMainmenurtrn
            // 
            this.btnMainmenurtrn.BackColor = System.Drawing.Color.Black;
            this.btnMainmenurtrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainmenurtrn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMainmenurtrn.Location = new System.Drawing.Point(769, 378);
            this.btnMainmenurtrn.Name = "btnMainmenurtrn";
            this.btnMainmenurtrn.Size = new System.Drawing.Size(347, 45);
            this.btnMainmenurtrn.TabIndex = 15;
            this.btnMainmenurtrn.Text = "--> Go Back";
            this.btnMainmenurtrn.UseVisualStyleBackColor = false;
            this.btnMainmenurtrn.Click += new System.EventHandler(this.btnMainmenurtrn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1169, -14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Longitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1167, -81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Latitude";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.Location = new System.Drawing.Point(765, 43);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(348, 24);
            this.lblPostCode.TabIndex = 30;
            this.lblPostCode.Text = "Select a location on the map to deliver to";
            this.lblPostCode.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1313, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 31;
            // 
            // btnGetRoute
            // 
            this.btnGetRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRoute.Location = new System.Drawing.Point(454, 229);
            this.btnGetRoute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetRoute.Name = "btnGetRoute";
            this.btnGetRoute.Size = new System.Drawing.Size(56, 19);
            this.btnGetRoute.TabIndex = 40;
            this.btnGetRoute.Text = "Get route";
            this.btnGetRoute.UseVisualStyleBackColor = true;
            // 
            // btnClearList
            // 
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.Location = new System.Drawing.Point(454, 261);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(56, 19);
            this.btnClearList.TabIndex = 39;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Location = new System.Drawing.Point(454, 155);
            this.btnAddPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(56, 19);
            this.btnAddPoint.TabIndex = 38;
            this.btnAddPoint.Text = "Add point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 19);
            this.button1.TabIndex = 37;
            this.button1.Text = "Load Maps";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtLong
            // 
            this.txtLong.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtLong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtLong.Location = new System.Drawing.Point(338, 237);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(76, 20);
            this.txtLong.TabIndex = 36;
            // 
            // txtLat
            // 
            this.txtLat.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtLat.Location = new System.Drawing.Point(338, 170);
            this.txtLat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(76, 20);
            this.txtLat.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Longitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Latitude";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(8, 8);
            this.map.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(739, 466);
            this.map.TabIndex = 18;
            this.map.Zoom = 13D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // btnDistance
            // 
            this.btnDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistance.Location = new System.Drawing.Point(769, 80);
            this.btnDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(347, 41);
            this.btnDistance.TabIndex = 42;
            this.btnDistance.Text = "Show Route From Store";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // btnMapReset
            // 
            this.btnMapReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapReset.Location = new System.Drawing.Point(769, 159);
            this.btnMapReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMapReset.Name = "btnMapReset";
            this.btnMapReset.Size = new System.Drawing.Size(347, 41);
            this.btnMapReset.TabIndex = 43;
            this.btnMapReset.Text = "Reset Map";
            this.btnMapReset.UseVisualStyleBackColor = true;
            this.btnMapReset.Click += new System.EventHandler(this.btnMapReset_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Location = new System.Drawing.Point(769, 239);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(347, 41);
            this.btnReceipt.TabIndex = 44;
            this.btnReceipt.Text = "Get A Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // OrderingItemsToHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1129, 492);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnMapReset);
            this.Controls.Add(this.btnDistance);
            this.Controls.Add(this.map);
            this.Controls.Add(this.btnGetRoute);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexitsys);
            this.Controls.Add(this.btnMainmenurtrn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderingItemsToHome";
            this.Text = "OrderingItemsToHome";
            this.Load += new System.EventHandler(this.OrderingItemsToHome_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexitsys;
        private System.Windows.Forms.Button btnMainmenurtrn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetRoute;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.Button btnMapReset;
        private System.Windows.Forms.Button btnReceipt;
    }
}