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
            this.tableIdHeader = new System.Windows.Forms.ColumnHeader();
            this.placedHeader = new System.Windows.Forms.ColumnHeader();
            this.quantityHeader = new System.Windows.Forms.ColumnHeader();
            this.orderHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblKitchenAndBar = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableIdHeader,
            this.placedHeader,
            this.quantityHeader,
            this.orderHeader,
            this.statusHeader});
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(250, 163);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(407, 178);
            this.lvOrders.TabIndex = 5;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
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
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 68;
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
            this.btnReady.Location = new System.Drawing.Point(582, 364);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 23);
            this.btnReady.TabIndex = 9;
            this.btnReady.Text = "ready";
            this.btnReady.UseVisualStyleBackColor = true;
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
            this.btnLogout.Location = new System.Drawing.Point(679, 46);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(43, 88);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // KitchenAndBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 441);
            this.Controls.Add(this.comboBox1);
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