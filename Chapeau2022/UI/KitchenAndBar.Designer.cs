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
            this.qtyHeader = new System.Windows.Forms.ColumnHeader();
            this.orderTypeHeader = new System.Windows.Forms.ColumnHeader();
            this.orderItemNameHeader = new System.Windows.Forms.ColumnHeader();
            this.commentHeader = new System.Windows.Forms.ColumnHeader();
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
            this.qtyHeader,
            this.orderTypeHeader,
            this.orderItemNameHeader,
            this.commentHeader,
            this.statusHeader});
            this.lvOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(12, 135);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(1120, 404);
            this.lvOrders.TabIndex = 5;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            // 
            // tableNrHeader
            // 
            this.tableNrHeader.Text = "Table No.";
            this.tableNrHeader.Width = 76;
            // 
            // placedHeader
            // 
            this.placedHeader.Text = "Placed";
            this.placedHeader.Width = 156;
            // 
            // qtyHeader
            // 
            this.qtyHeader.Text = "Qty";
            this.qtyHeader.Width = 41;
            // 
            // orderTypeHeader
            // 
            this.orderTypeHeader.Text = "Order Type";
            this.orderTypeHeader.Width = 110;
            // 
            // orderItemNameHeader
            // 
            this.orderItemNameHeader.Text = "Ordered Item Name";
            this.orderItemNameHeader.Width = 400;
            // 
            // commentHeader
            // 
            this.commentHeader.Text = "Comment";
            this.commentHeader.Width = 252;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.Width = 80;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReady.Location = new System.Drawing.Point(1032, 89);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(100, 40);
            this.btnReady.TabIndex = 9;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblKitchenAndBar
            // 
            this.lblKitchenAndBar.AutoSize = true;
            this.lblKitchenAndBar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitchenAndBar.Location = new System.Drawing.Point(12, 0);
            this.lblKitchenAndBar.Name = "lblKitchenAndBar";
            this.lblKitchenAndBar.Size = new System.Drawing.Size(306, 47);
            this.lblKitchenAndBar.TabIndex = 8;
            this.lblKitchenAndBar.Text = "Kitchen/Bar View";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1032, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinished.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinished.Location = new System.Drawing.Point(122, 89);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(100, 40);
            this.btnFinished.TabIndex = 11;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // btnRunning
            // 
            this.btnRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRunning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunning.Location = new System.Drawing.Point(12, 89);
            this.btnRunning.Name = "btnRunning";
            this.btnRunning.Size = new System.Drawing.Size(100, 40);
            this.btnRunning.TabIndex = 12;
            this.btnRunning.Text = "Running";
            this.btnRunning.UseVisualStyleBackColor = false;
            this.btnRunning.Click += new System.EventHandler(this.btnRunning_Click);
            // 
            // btnTabelNr
            // 
            this.btnTabelNr.AutoSize = true;
            this.btnTabelNr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabelNr.Location = new System.Drawing.Point(457, 65);
            this.btnTabelNr.Name = "btnTabelNr";
            this.btnTabelNr.Size = new System.Drawing.Size(195, 21);
            this.btnTabelNr.TabIndex = 13;
            this.btnTabelNr.Text = "Choose ready table No. :";
            // 
            // tbxTableNr
            // 
            this.tbxTableNr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxTableNr.Location = new System.Drawing.Point(638, 96);
            this.tbxTableNr.Name = "tbxTableNr";
            this.tbxTableNr.Size = new System.Drawing.Size(32, 29);
            this.tbxTableNr.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose displaying orders :";
            // 
            // lblReadyCourse
            // 
            this.lblReadyCourse.AutoSize = true;
            this.lblReadyCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReadyCourse.Location = new System.Drawing.Point(710, 65);
            this.lblReadyCourse.Name = "lblReadyCourse";
            this.lblReadyCourse.Size = new System.Drawing.Size(175, 21);
            this.lblReadyCourse.TabIndex = 19;
            this.lblReadyCourse.Text = "Choose ready course :";
            // 
            // chbxAppetizer
            // 
            this.chbxAppetizer.AutoSize = true;
            this.chbxAppetizer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbxAppetizer.Location = new System.Drawing.Point(710, 98);
            this.chbxAppetizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxAppetizer.Name = "chbxAppetizer";
            this.chbxAppetizer.Size = new System.Drawing.Size(103, 25);
            this.chbxAppetizer.TabIndex = 21;
            this.chbxAppetizer.Text = "Appetizer";
            this.chbxAppetizer.UseVisualStyleBackColor = true;
            // 
            // chbxMain
            // 
            this.chbxMain.AutoSize = true;
            this.chbxMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbxMain.Location = new System.Drawing.Point(818, 98);
            this.chbxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxMain.Name = "chbxMain";
            this.chbxMain.Size = new System.Drawing.Size(68, 25);
            this.chbxMain.TabIndex = 22;
            this.chbxMain.Text = "Main";
            this.chbxMain.UseVisualStyleBackColor = true;
            // 
            // chbxDessert
            // 
            this.chbxDessert.AutoSize = true;
            this.chbxDessert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbxDessert.Location = new System.Drawing.Point(892, 98);
            this.chbxDessert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxDessert.Name = "chbxDessert";
            this.chbxDessert.Size = new System.Drawing.Size(85, 25);
            this.chbxDessert.TabIndex = 23;
            this.chbxDessert.Text = "Dessert";
            this.chbxDessert.UseVisualStyleBackColor = true;
            // 
            // KitchenAndBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 551);
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
        private System.Windows.Forms.ColumnHeader orderItemNameHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblKitchenAndBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ColumnHeader qtyHeader;
        private System.Windows.Forms.ColumnHeader orderTypeHeader;
        private System.Windows.Forms.ColumnHeader commentHeader;
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