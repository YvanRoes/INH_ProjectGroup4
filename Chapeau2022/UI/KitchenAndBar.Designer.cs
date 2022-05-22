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
            this.listView1 = new System.Windows.Forms.ListView();
            this.orderIdHeader = new System.Windows.Forms.ColumnHeader();
            this.tableIdHeader = new System.Windows.Forms.ColumnHeader();
            this.placedHeader = new System.Windows.Forms.ColumnHeader();
            this.orderHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblKitchenAndBar = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.quantityHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderIdHeader,
            this.tableIdHeader,
            this.placedHeader,
            this.quantityHeader,
            this.orderHeader,
            this.statusHeader});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(286, 217);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(465, 236);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // orderIdHeader
            // 
            this.orderIdHeader.Text = "Order No.";
            this.orderIdHeader.Width = 78;
            // 
            // tableIdHeader
            // 
            this.tableIdHeader.Text = "Table No.";
            this.tableIdHeader.Width = 78;
            // 
            // placedHeader
            // 
            this.placedHeader.Text = "Placed";
            this.placedHeader.Width = 57;
            // 
            // orderHeader
            // 
            this.orderHeader.Text = "Order";
            this.orderHeader.Width = 130;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(665, 486);
            this.btnReady.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(86, 31);
            this.btnReady.TabIndex = 9;
            this.btnReady.Text = "ready";
            this.btnReady.UseVisualStyleBackColor = true;
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
            this.lblKitchenAndBar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(776, 61);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "running orders",
            "finished orders"});
            this.comboBox1.Location = new System.Drawing.Point(49, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 68;
            // 
            // KitchenAndBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 588);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblKitchenAndBar);
            this.Name = "KitchenAndBar";
            this.Text = "KitchenAndBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader orderIdHeader;
        private System.Windows.Forms.ColumnHeader tableIdHeader;
        private System.Windows.Forms.ColumnHeader placedHeader;
        private System.Windows.Forms.ColumnHeader orderHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblKitchenAndBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader quantityHeader;
    }
}