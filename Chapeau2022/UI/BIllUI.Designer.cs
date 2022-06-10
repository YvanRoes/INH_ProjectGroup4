
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillUI));
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbCreditcard = new System.Windows.Forms.RadioButton();
            this.cbComment = new System.Windows.Forms.CheckBox();
            this.cbTip = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalVat = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvOrderedItems = new System.Windows.Forms.ListView();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(203, 838);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(61, 24);
            this.rbCash.TabIndex = 54;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbPin
            // 
            this.rbPin.AutoSize = true;
            this.rbPin.Location = new System.Drawing.Point(141, 837);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(50, 24);
            this.rbPin.TabIndex = 53;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin";
            this.rbPin.UseVisualStyleBackColor = true;
            // 
            // rbCreditcard
            // 
            this.rbCreditcard.AutoSize = true;
            this.rbCreditcard.Location = new System.Drawing.Point(32, 835);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(99, 24);
            this.rbCreditcard.TabIndex = 52;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            // 
            // cbComment
            // 
            this.cbComment.AutoSize = true;
            this.cbComment.Location = new System.Drawing.Point(35, 751);
            this.cbComment.Name = "cbComment";
            this.cbComment.Size = new System.Drawing.Size(18, 17);
            this.cbComment.TabIndex = 51;
            this.cbComment.UseVisualStyleBackColor = true;
            this.cbComment.CheckedChanged += new System.EventHandler(this.cbComment_CheckedChanged);
            // 
            // cbTip
            // 
            this.cbTip.AutoSize = true;
            this.cbTip.Location = new System.Drawing.Point(34, 643);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(18, 17);
            this.cbTip.TabIndex = 50;
            this.cbTip.UseVisualStyleBackColor = true;
            this.cbTip.CheckedChanged += new System.EventHandler(this.cbTip_CheckedChanged);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(32, 782);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(125, 27);
            this.txtComment.TabIndex = 49;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(31, 674);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(125, 27);
            this.txtTip.TabIndex = 48;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(440, 552);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "€ 0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 714);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Add comment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Add tip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Total Vat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Table Nr:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Sub Total:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Salmon;
            this.btnPay.Location = new System.Drawing.Point(33, 886);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 39);
            this.btnPay.TabIndex = 39;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // lblTotalVat
            // 
            this.lblTotalVat.AutoSize = true;
            this.lblTotalVat.Location = new System.Drawing.Point(440, 509);
            this.lblTotalVat.Name = "lblTotalVat";
            this.lblTotalVat.Size = new System.Drawing.Size(48, 20);
            this.lblTotalVat.TabIndex = 33;
            this.lblTotalVat.Text = "€ 0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(439, 475);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(48, 20);
            this.lblSubTotal.TabIndex = 34;
            this.lblSubTotal.Text = "€ 0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total Vat:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(111, 105);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 20);
            this.lblTable.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sub Total:";
            // 
            // lvOrderedItems
            // 
            this.lvOrderedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.Quantity,
            this.Price});
            this.lvOrderedItems.FullRowSelect = true;
            this.lvOrderedItems.HideSelection = false;
            this.lvOrderedItems.Location = new System.Drawing.Point(26, 138);
            this.lvOrderedItems.Name = "lvOrderedItems";
            this.lvOrderedItems.Size = new System.Drawing.Size(465, 323);
            this.lvOrderedItems.TabIndex = 32;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 38);
            this.label6.TabIndex = 37;
            this.label6.Text = "BIll";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(456, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 29);
            this.btnBack.TabIndex = 55;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "----------------------------------------------------------------------------";
            // 
            // BillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(536, 928);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.rbPin);
            this.Controls.Add(this.rbCreditcard);
            this.Controls.Add(this.cbComment);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalVat);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvOrderedItems);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BillUI";
            this.Text = "BIllUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbPin;
        private System.Windows.Forms.RadioButton rbCreditcard;
        private System.Windows.Forms.CheckBox cbComment;
        private System.Windows.Forms.CheckBox cbTip;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalVat;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvOrderedItems;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
    }
}