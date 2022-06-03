namespace UI
{
    partial class KitchenAndBar
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
            this.lvOrders = new System.Windows.Forms.ListView();
            this.tableNrHeader = new System.Windows.Forms.ColumnHeader();
            this.placedHeader = new System.Windows.Forms.ColumnHeader();
            this.quantityHeader = new System.Windows.Forms.ColumnHeader();
            this.typeHeader = new System.Windows.Forms.ColumnHeader();
            this.orderHeader = new System.Windows.Forms.ColumnHeader();
            this.descriptionHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblKitchenAndBar = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnRunning = new System.Windows.Forms.Button();
            this.btnTabelNr = new System.Windows.Forms.Label();
            this.tbxTableNr = new System.Windows.Forms.TextBox();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReadyCourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableNrHeader,
            this.placedHeader,
            this.quantityHeader,
            this.typeHeader,
            this.orderHeader,
            this.descriptionHeader,
            this.statusHeader});
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(49, 221);
            this.lvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(821, 267);
            this.lvOrders.TabIndex = 5;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            // 
            // tableNrHeader
            // 
            this.tableNrHeader.Text = "Table No.";
            this.tableNrHeader.Width = 58;
            // 
            // placedHeader
            // 
            this.placedHeader.Text = "Placed";
            this.placedHeader.Width = 110;
            // 
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 62;
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "Type";
            this.typeHeader.Width = 100;
            // 
            // orderHeader
            // 
            this.orderHeader.Text = "Order";
            this.orderHeader.Width = 250;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Comment";
            this.descriptionHeader.Width = 200;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 80;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReady.Location = new System.Drawing.Point(784, 497);
            this.btnReady.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(86, 31);
            this.btnReady.TabIndex = 9;
            this.btnReady.Text = "ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblKitchenAndBar
            // 
            this.lblKitchenAndBar.AutoSize = true;
            this.lblKitchenAndBar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKitchenAndBar.Location = new System.Drawing.Point(49, 33);
            this.lblKitchenAndBar.Name = "lblKitchenAndBar";
            this.lblKitchenAndBar.Size = new System.Drawing.Size(354, 60);
            this.lblKitchenAndBar.TabIndex = 8;
            this.lblKitchenAndBar.Text = "Kitchen/Bar View";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(776, 61);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 35);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinished.Location = new System.Drawing.Point(143, 159);
            this.btnFinished.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(77, 31);
            this.btnFinished.TabIndex = 11;
            this.btnFinished.Text = "finished";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnRunning
            // 
            this.btnRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRunning.Location = new System.Drawing.Point(49, 159);
            this.btnRunning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunning.Name = "btnRunning";
            this.btnRunning.Size = new System.Drawing.Size(77, 31);
            this.btnRunning.TabIndex = 12;
            this.btnRunning.Text = "running";
            this.btnRunning.UseVisualStyleBackColor = false;
            this.btnRunning.Click += new System.EventHandler(this.btnRunning_Click);
            // 
            // btnTabelNr
            // 
            this.btnTabelNr.AutoSize = true;
            this.btnTabelNr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabelNr.Location = new System.Drawing.Point(314, 131);
            this.btnTabelNr.Name = "btnTabelNr";
            this.btnTabelNr.Size = new System.Drawing.Size(179, 20);
            this.btnTabelNr.TabIndex = 13;
            this.btnTabelNr.Text = "Choose ready table No. :";
            // 
            // tbxTableNr
            // 
            this.tbxTableNr.Location = new System.Drawing.Point(433, 159);
            this.tbxTableNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTableNr.Name = "tbxTableNr";
            this.tbxTableNr.Size = new System.Drawing.Size(36, 27);
            this.tbxTableNr.TabIndex = 14;
            this.tbxTableNr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.Location = new System.Drawing.Point(504, 159);
            this.btnAppetizer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Size = new System.Drawing.Size(86, 31);
            this.btnAppetizer.TabIndex = 15;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(597, 159);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(86, 31);
            this.btnMain.TabIndex = 16;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(689, 159);
            this.btnDessert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(86, 31);
            this.btnDessert.TabIndex = 17;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose displaying orders :";
            // 
            // lblReadyCourse
            // 
            this.lblReadyCourse.AutoSize = true;
            this.lblReadyCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReadyCourse.Location = new System.Drawing.Point(504, 131);
            this.lblReadyCourse.Name = "lblReadyCourse";
            this.lblReadyCourse.Size = new System.Drawing.Size(161, 20);
            this.lblReadyCourse.TabIndex = 19;
            this.lblReadyCourse.Text = "Choose ready course :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // KitchenAndBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReadyCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAppetizer);
            this.Controls.Add(this.tbxTableNr);
            this.Controls.Add(this.btnTabelNr);
            this.Controls.Add(this.btnRunning);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblKitchenAndBar);
            this.Name = "KitchenAndBar";
            this.Text = "KitchenAndBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader placedHeader;
        private System.Windows.Forms.ColumnHeader orderHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblKitchenAndBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ColumnHeader quantityHeader;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnRunning;
        private System.Windows.Forms.ColumnHeader tableNrHeader;
        private System.Windows.Forms.Label btnTabelNr;
        private System.Windows.Forms.TextBox tbxTableNr;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReadyCourse;
        private System.Windows.Forms.Label label2;
    }
}