
namespace UI
{
    partial class Bill
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
            this.lvOrderedItems = new System.Windows.Forms.ListView();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOrderedItems
            // 
            this.lvOrderedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.Quantity,
            this.Price});
            this.lvOrderedItems.FullRowSelect = true;
            this.lvOrderedItems.HideSelection = false;
            this.lvOrderedItems.Location = new System.Drawing.Point(162, 70);
            this.lvOrderedItems.Name = "lvOrderedItems";
            this.lvOrderedItems.Size = new System.Drawing.Size(774, 323);
            this.lvOrderedItems.TabIndex = 0;
            this.lvOrderedItems.UseCompatibleStateImageBehavior = false;
            this.lvOrderedItems.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item Name";
            this.itemName.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 300;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 300;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(842, 424);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 826);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lvOrderedItems);
            this.Name = "Bill";
            this.Text = "Bill";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOrderedItems;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
    }
}