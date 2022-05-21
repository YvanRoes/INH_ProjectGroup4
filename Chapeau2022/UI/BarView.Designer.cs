namespace UI
{
    partial class BarView
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
            this.drinkOrderHeader = new System.Windows.Forms.ColumnHeader();
            this.statusHeader = new System.Windows.Forms.ColumnHeader();
            this.rdbtnRunningOrders = new System.Windows.Forms.RadioButton();
            this.rdbtnFinishedOrders = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderIdHeader,
            this.tableIdHeader,
            this.placedHeader,
            this.drinkOrderHeader,
            this.statusHeader});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(247, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 179);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // orderIdHeader
            // 
            this.orderIdHeader.Text = "Order No.";
            this.orderIdHeader.Width = 65;
            // 
            // tableIdHeader
            // 
            this.tableIdHeader.Text = "Table No.";
            this.tableIdHeader.Width = 64;
            // 
            // placedHeader
            // 
            this.placedHeader.Text = "Placed";
            this.placedHeader.Width = 50;
            // 
            // drinkOrderHeader
            // 
            this.drinkOrderHeader.Text = "Drink order";
            this.drinkOrderHeader.Width = 130;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            // 
            // rdbtnRunningOrders
            // 
            this.rdbtnRunningOrders.AutoSize = true;
            this.rdbtnRunningOrders.Location = new System.Drawing.Point(47, 100);
            this.rdbtnRunningOrders.Name = "rdbtnRunningOrders";
            this.rdbtnRunningOrders.Size = new System.Drawing.Size(103, 19);
            this.rdbtnRunningOrders.TabIndex = 1;
            this.rdbtnRunningOrders.TabStop = true;
            this.rdbtnRunningOrders.Text = "running orders";
            this.rdbtnRunningOrders.UseVisualStyleBackColor = true;
            // 
            // rdbtnFinishedOrders
            // 
            this.rdbtnFinishedOrders.AutoSize = true;
            this.rdbtnFinishedOrders.Location = new System.Drawing.Point(47, 125);
            this.rdbtnFinishedOrders.Name = "rdbtnFinishedOrders";
            this.rdbtnFinishedOrders.Size = new System.Drawing.Size(103, 19);
            this.rdbtnFinishedOrders.TabIndex = 2;
            this.rdbtnFinishedOrders.TabStop = true;
            this.rdbtnFinishedOrders.Text = "finished orders";
            this.rdbtnFinishedOrders.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bar View";
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(545, 378);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 23);
            this.btnReady.TabIndex = 4;
            this.btnReady.Text = "ready";
            this.btnReady.UseVisualStyleBackColor = true;
            // 
            // BarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtnFinishedOrders);
            this.Controls.Add(this.rdbtnRunningOrders);
            this.Controls.Add(this.listView1);
            this.Name = "BarView";
            this.Text = "BarView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader orderIdHeader;
        private System.Windows.Forms.ColumnHeader tableIdHeader;
        private System.Windows.Forms.ColumnHeader placedHeader;
        private System.Windows.Forms.ColumnHeader drinkOrderHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.RadioButton rdbtnRunningOrders;
        private System.Windows.Forms.RadioButton rdbtnFinishedOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReady;
    }
}