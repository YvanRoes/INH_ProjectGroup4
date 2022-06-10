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
            this.label1 = new System.Windows.Forms.Label();
            this.lblReadyCourse = new System.Windows.Forms.Label();
            this.chbxAppetizer = new System.Windows.Forms.CheckBox();
            this.chbxMain = new System.Windows.Forms.CheckBox();
            this.chbxDessert = new System.Windows.Forms.CheckBox();
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
            this.lvOrders.Location = new System.Drawing.Point(43, 166);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(756, 248);
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
            this.btnReady.Location = new System.Drawing.Point(724, 122);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(74, 22);
            this.btnReady.TabIndex = 9;
            this.btnReady.Text = "ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblKitchenAndBar
            // 
            this.lblKitchenAndBar.AutoSize = true;
            this.lblKitchenAndBar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKitchenAndBar.Location = new System.Drawing.Point(43, 25);
            this.lblKitchenAndBar.Name = "lblKitchenAndBar";
            this.lblKitchenAndBar.Size = new System.Drawing.Size(281, 47);
            this.lblKitchenAndBar.TabIndex = 8;
            this.lblKitchenAndBar.Text = "Kitchen/Bar View";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(724, 45);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 22);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinished.Location = new System.Drawing.Point(136, 122);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(74, 22);
            this.btnFinished.TabIndex = 11;
            this.btnFinished.Text = "finished";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnRunning
            // 
            this.btnRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRunning.Location = new System.Drawing.Point(43, 122);
            this.btnRunning.Name = "btnRunning";
            this.btnRunning.Size = new System.Drawing.Size(74, 22);
            this.btnRunning.TabIndex = 12;
            this.btnRunning.Text = "running";
            this.btnRunning.UseVisualStyleBackColor = false;
            this.btnRunning.Click += new System.EventHandler(this.btnRunning_Click);
            // 
            // btnTabelNr
            // 
            this.btnTabelNr.AutoSize = true;
            this.btnTabelNr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabelNr.Location = new System.Drawing.Point(290, 104);
            this.btnTabelNr.Name = "btnTabelNr";
            this.btnTabelNr.Size = new System.Drawing.Size(140, 15);
            this.btnTabelNr.TabIndex = 13;
            this.btnTabelNr.Text = "Choose ready table No. :";
            // 
            // tbxTableNr
            // 
            this.tbxTableNr.Location = new System.Drawing.Point(415, 125);
            this.tbxTableNr.Name = "tbxTableNr";
            this.tbxTableNr.Size = new System.Drawing.Size(32, 23);
            this.tbxTableNr.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose displaying orders :";
            // 
            // lblReadyCourse
            // 
            this.lblReadyCourse.AutoSize = true;
            this.lblReadyCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReadyCourse.Location = new System.Drawing.Point(477, 104);
            this.lblReadyCourse.Name = "lblReadyCourse";
            this.lblReadyCourse.Size = new System.Drawing.Size(127, 15);
            this.lblReadyCourse.TabIndex = 19;
            this.lblReadyCourse.Text = "Choose ready course :";
            // 
            // chbxAppetizer
            // 
            this.chbxAppetizer.AutoSize = true;
            this.chbxAppetizer.Location = new System.Drawing.Point(477, 125);
            this.chbxAppetizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxAppetizer.Name = "chbxAppetizer";
            this.chbxAppetizer.Size = new System.Drawing.Size(76, 19);
            this.chbxAppetizer.TabIndex = 21;
            this.chbxAppetizer.Text = "Appetizer";
            this.chbxAppetizer.UseVisualStyleBackColor = true;
            // 
            // chbxMain
            // 
            this.chbxMain.AutoSize = true;
            this.chbxMain.Location = new System.Drawing.Point(566, 125);
            this.chbxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxMain.Name = "chbxMain";
            this.chbxMain.Size = new System.Drawing.Size(53, 19);
            this.chbxMain.TabIndex = 22;
            this.chbxMain.Text = "Main";
            this.chbxMain.UseVisualStyleBackColor = true;
            // 
            // chbxDessert
            // 
            this.chbxDessert.AutoSize = true;
            this.chbxDessert.Location = new System.Drawing.Point(627, 125);
            this.chbxDessert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxDessert.Name = "chbxDessert";
            this.chbxDessert.Size = new System.Drawing.Size(64, 19);
            this.chbxDessert.TabIndex = 23;
            this.chbxDessert.Text = "Dessert";
            this.chbxDessert.UseVisualStyleBackColor = true;
            // 
            // KitchenAndBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 441);
            this.Controls.Add(this.chbxDessert);
            this.Controls.Add(this.chbxMain);
            this.Controls.Add(this.chbxAppetizer);
            this.Controls.Add(this.lblReadyCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTableNr);
            this.Controls.Add(this.btnTabelNr);
            this.Controls.Add(this.btnRunning);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblKitchenAndBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReadyCourse;
        private System.Windows.Forms.CheckBox chbxAppetizer;
        private System.Windows.Forms.CheckBox chbxMain;
        private System.Windows.Forms.CheckBox chbxDessert;
    }
}