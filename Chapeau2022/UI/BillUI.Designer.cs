
namespace UI
{
    partial class BillUI
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
            this.btnPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cbComment = new System.Windows.Forms.CheckBox();
            this.rbCreditcard = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalVat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
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
            this.lvOrderedItems.Location = new System.Drawing.Point(37, 69);
            this.lvOrderedItems.Name = "lvOrderedItems";
            this.lvOrderedItems.Size = new System.Drawing.Size(465, 323);
            this.lvOrderedItems.TabIndex = 0;
            this.lvOrderedItems.UseCompatibleStateImageBehavior = false;
            this.lvOrderedItems.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item Name";
            this.itemName.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 150;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(41, 817);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 29);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sub Total:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(450, 420);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(48, 20);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "€ 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add tip";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(38, 605);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(125, 27);
            this.txtTip.TabIndex = 6;
            // 
            // cbTip
            // 
            this.cbTip.AutoSize = true;
            this.cbTip.Location = new System.Drawing.Point(41, 574);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(18, 17);
            this.cbTip.TabIndex = 7;
            this.cbTip.UseVisualStyleBackColor = true;
            this.cbTip.CheckedChanged += new System.EventHandler(this.cbTip_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 645);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(39, 713);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(125, 27);
            this.txtComment.TabIndex = 6;
            // 
            // cbComment
            // 
            this.cbComment.AutoSize = true;
            this.cbComment.Location = new System.Drawing.Point(42, 682);
            this.cbComment.Name = "cbComment";
            this.cbComment.Size = new System.Drawing.Size(18, 17);
            this.cbComment.TabIndex = 7;
            this.cbComment.UseVisualStyleBackColor = true;
            this.cbComment.CheckedChanged += new System.EventHandler(this.cbComment_CheckedChanged);
            // 
            // rbCreditcard
            // 
            this.rbCreditcard.AutoSize = true;
            this.rbCreditcard.Location = new System.Drawing.Point(39, 766);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(99, 24);
            this.rbCreditcard.TabIndex = 8;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            // 
            // rbPin
            // 
            this.rbPin.AutoSize = true;
            this.rbPin.Location = new System.Drawing.Point(148, 768);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(50, 24);
            this.rbPin.TabIndex = 8;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin";
            this.rbPin.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(210, 770);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(61, 24);
            this.rbCash.TabIndex = 8;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Vat:";
            // 
            // lblTotalVat
            // 
            this.lblTotalVat.AutoSize = true;
            this.lblTotalVat.Location = new System.Drawing.Point(451, 454);
            this.lblTotalVat.Name = "lblTotalVat";
            this.lblTotalVat.Size = new System.Drawing.Size(48, 20);
            this.lblTotalVat.TabIndex = 5;
            this.lblTotalVat.Text = "€ 0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(451, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "€ 0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Table Nr:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(124, 28);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 20);
            this.lblTable.TabIndex = 5;
            // 
            // BillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(561, 887);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.rbPin);
            this.Controls.Add(this.rbCreditcard);
            this.Controls.Add(this.cbComment);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalVat);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lvOrderedItems);
            this.Name = "BillUI";
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOrderedItems;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.CheckBox cbTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.CheckBox cbComment;
        private System.Windows.Forms.RadioButton rbCreditcard;
        private System.Windows.Forms.RadioButton rbPin;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalVat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTable;
    }
}