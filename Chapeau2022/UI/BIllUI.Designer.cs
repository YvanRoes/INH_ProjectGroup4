
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
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbPin = new System.Windows.Forms.RadioButton();
            this.rbCreditcard = new System.Windows.Forms.RadioButton();
            this.btnPay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSplitBox = new System.Windows.Forms.TextBox();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.lblEuro3 = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalVat = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lvOrderedItems = new System.Windows.Forms.ListView();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.lblStillToPay = new System.Windows.Forms.Label();
            this.cbSplitAmount = new System.Windows.Forms.CheckBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbTip = new System.Windows.Forms.CheckBox();
            this.cbAddComment = new System.Windows.Forms.CheckBox();
            this.lblSubTotalName = new System.Windows.Forms.Label();
            this.lblTotalVatNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(180, 901);
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
            this.rbPin.Location = new System.Drawing.Point(118, 900);
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
            this.rbCreditcard.Location = new System.Drawing.Point(14, 898);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(99, 24);
            this.rbCreditcard.TabIndex = 52;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Salmon;
            this.btnPay.Location = new System.Drawing.Point(9, 937);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 39);
            this.btnPay.TabIndex = 39;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(-1, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 38);
            this.label6.TabIndex = 37;
            this.label6.Text = "BILL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "------------------------------------------------------------";
            // 
            // txtSplitBox
            // 
            this.txtSplitBox.Location = new System.Drawing.Point(16, 808);
            this.txtSplitBox.Name = "txtSplitBox";
            this.txtSplitBox.Size = new System.Drawing.Size(125, 27);
            this.txtSplitBox.TabIndex = 89;
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(10, 126);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(53, 28);
            this.cmbTable.TabIndex = 88;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged_1);
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(313, 404);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(17, 20);
            this.lblEuro1.TabIndex = 87;
            this.lblEuro1.Text = "€";
            // 
            // lblEuro3
            // 
            this.lblEuro3.AutoSize = true;
            this.lblEuro3.Location = new System.Drawing.Point(313, 475);
            this.lblEuro3.Name = "lblEuro3";
            this.lblEuro3.Size = new System.Drawing.Size(17, 20);
            this.lblEuro3.TabIndex = 86;
            this.lblEuro3.Text = "€";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(313, 436);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(17, 20);
            this.lblEuro2.TabIndex = 85;
            this.lblEuro2.Text = "€";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 859);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 20);
            this.label17.TabIndex = 84;
            this.label17.Text = "Choose a payment method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 743);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "Enter split amount:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(13, 703);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(125, 27);
            this.txtComment.TabIndex = 80;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(16, 588);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(125, 27);
            this.txtTip.TabIndex = 79;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(333, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 20);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Add comment:";
            // 
            // lblTotalName
            // 
            this.lblTotalName.AutoSize = true;
            this.lblTotalName.Location = new System.Drawing.Point(263, 476);
            this.lblTotalName.Name = "lblTotalName";
            this.lblTotalName.Size = new System.Drawing.Size(45, 20);
            this.lblTotalName.TabIndex = 77;
            this.lblTotalName.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Add tip:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 73;
            this.label11.Text = "Select a table:";
            // 
            // lblTotalVat
            // 
            this.lblTotalVat.AutoSize = true;
            this.lblTotalVat.Location = new System.Drawing.Point(333, 436);
            this.lblTotalVat.Name = "lblTotalVat";
            this.lblTotalVat.Size = new System.Drawing.Size(36, 20);
            this.lblTotalVat.TabIndex = 67;
            this.lblTotalVat.Text = "0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(332, 404);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(36, 20);
            this.lblSubTotal.TabIndex = 66;
            this.lblSubTotal.Text = "0.00";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(65, 138);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 20);
            this.lblTable.TabIndex = 70;
            // 
            // lvOrderedItems
            // 
            this.lvOrderedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.Quantity,
            this.Price});
            this.lvOrderedItems.FullRowSelect = true;
            this.lvOrderedItems.HideSelection = false;
            this.lvOrderedItems.Location = new System.Drawing.Point(70, 126);
            this.lvOrderedItems.Name = "lvOrderedItems";
            this.lvOrderedItems.Size = new System.Drawing.Size(299, 230);
            this.lvOrderedItems.TabIndex = 65;
            this.lvOrderedItems.UseCompatibleStateImageBehavior = false;
            this.lvOrderedItems.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item Name";
            this.itemName.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 70;
            // 
            // Price
            // 
            this.Price.Text = "Price(Exc vat)";
            this.Price.Width = 130;
            // 
            // lblStillToPay
            // 
            this.lblStillToPay.AutoSize = true;
            this.lblStillToPay.Location = new System.Drawing.Point(198, 474);
            this.lblStillToPay.Name = "lblStillToPay";
            this.lblStillToPay.Size = new System.Drawing.Size(110, 20);
            this.lblStillToPay.TabIndex = 90;
            this.lblStillToPay.Text = "Still to be paid:";
            // 
            // cbSplitAmount
            // 
            this.cbSplitAmount.AutoSize = true;
            this.cbSplitAmount.Location = new System.Drawing.Point(16, 777);
            this.cbSplitAmount.Name = "cbSplitAmount";
            this.cbSplitAmount.Size = new System.Drawing.Size(18, 17);
            this.cbSplitAmount.TabIndex = 91;
            this.cbSplitAmount.UseVisualStyleBackColor = true;
            this.cbSplitAmount.CheckedChanged += new System.EventHandler(this.cbSplitAmount_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Location = new System.Drawing.Point(277, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 35);
            this.btnLogout.TabIndex = 92;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbTip
            // 
            this.cbTip.AutoSize = true;
            this.cbTip.Location = new System.Drawing.Point(15, 557);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(18, 17);
            this.cbTip.TabIndex = 93;
            this.cbTip.UseVisualStyleBackColor = true;
            this.cbTip.CheckedChanged += new System.EventHandler(this.cbTip_CheckedChanged_1);
            // 
            // cbAddComment
            // 
            this.cbAddComment.AutoSize = true;
            this.cbAddComment.Location = new System.Drawing.Point(16, 673);
            this.cbAddComment.Name = "cbAddComment";
            this.cbAddComment.Size = new System.Drawing.Size(18, 17);
            this.cbAddComment.TabIndex = 94;
            this.cbAddComment.UseVisualStyleBackColor = true;
            this.cbAddComment.CheckedChanged += new System.EventHandler(this.cbAddComment_CheckedChanged);
            // 
            // lblSubTotalName
            // 
            this.lblSubTotalName.AutoSize = true;
            this.lblSubTotalName.Location = new System.Drawing.Point(232, 404);
            this.lblSubTotalName.Name = "lblSubTotalName";
            this.lblSubTotalName.Size = new System.Drawing.Size(74, 20);
            this.lblSubTotalName.TabIndex = 95;
            this.lblSubTotalName.Text = "Sub Total:";
            // 
            // lblTotalVatNaam
            // 
            this.lblTotalVatNaam.AutoSize = true;
            this.lblTotalVatNaam.Location = new System.Drawing.Point(119, 436);
            this.lblTotalVatNaam.Name = "lblTotalVatNaam";
            this.lblTotalVatNaam.Size = new System.Drawing.Size(185, 20);
            this.lblTotalVatNaam.TabIndex = 96;
            this.lblTotalVatNaam.Text = "Total vat(alc 21%, rest 6%):";
            // 
            // BillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(396, 689);
            this.Controls.Add(this.lblTotalVatNaam);
            this.Controls.Add(this.lblSubTotalName);
            this.Controls.Add(this.cbAddComment);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.cbSplitAmount);
            this.Controls.Add(this.lblStillToPay);
            this.Controls.Add(this.txtSplitBox);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.lblEuro3);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalVat);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lvOrderedItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.rbPin);
            this.Controls.Add(this.rbCreditcard);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSplitBox;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label lblEuro1;
        private System.Windows.Forms.Label lblEuro3;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalVatName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalVat;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ListView lvOrderedItems;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label lblStillToPay;
        private System.Windows.Forms.CheckBox cbSplitAmount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.CheckBox cbTip;
        private System.Windows.Forms.CheckBox cbAddComment;
        private System.Windows.Forms.Label lblSubTotalName;
        private System.Windows.Forms.Label lblTotalVatNaam;
    }
}