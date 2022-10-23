
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
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lvOrderedItems = new System.Windows.Forms.ListView();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.lblStillToPay = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSubTotalName = new System.Windows.Forms.Label();
            this.lblHighVatName = new System.Windows.Forms.Label();
            this.lblHighVat = new System.Windows.Forms.Label();
            this.lblLowVatName = new System.Windows.Forms.Label();
            this.lblLowVat = new System.Windows.Forms.Label();
            this.lblEuro4 = new System.Windows.Forms.Label();
            this.btnTip = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCash.Location = new System.Drawing.Point(828, 709);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(74, 32);
            this.rbCash.TabIndex = 54;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbPin
            // 
            this.rbPin.AutoSize = true;
            this.rbPin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPin.Location = new System.Drawing.Point(766, 708);
            this.rbPin.Name = "rbPin";
            this.rbPin.Size = new System.Drawing.Size(60, 32);
            this.rbPin.TabIndex = 53;
            this.rbPin.TabStop = true;
            this.rbPin.Text = "Pin";
            this.rbPin.UseVisualStyleBackColor = true;
            // 
            // rbCreditcard
            // 
            this.rbCreditcard.AutoSize = true;
            this.rbCreditcard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCreditcard.Location = new System.Drawing.Point(644, 707);
            this.rbCreditcard.Name = "rbCreditcard";
            this.rbCreditcard.Size = new System.Drawing.Size(124, 32);
            this.rbCreditcard.TabIndex = 52;
            this.rbCreditcard.TabStop = true;
            this.rbCreditcard.Text = "Creditcard";
            this.rbCreditcard.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightCoral;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(805, 750);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 39);
            this.btnPay.TabIndex = 39;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 38);
            this.label6.TabIndex = 37;
            this.label6.Text = "BILL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(873, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------------------";
            // 
            // txtSplitBox
            // 
            this.txtSplitBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSplitBox.Location = new System.Drawing.Point(586, 618);
            this.txtSplitBox.Name = "txtSplitBox";
            this.txtSplitBox.Size = new System.Drawing.Size(125, 34);
            this.txtSplitBox.TabIndex = 89;
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(35, 115);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(125, 28);
            this.cmbTable.TabIndex = 88;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged_1);
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEuro1.Location = new System.Drawing.Point(819, 364);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(23, 25);
            this.lblEuro1.TabIndex = 87;
            this.lblEuro1.Text = "€";
            // 
            // lblEuro3
            // 
            this.lblEuro3.AutoSize = true;
            this.lblEuro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEuro3.Location = new System.Drawing.Point(820, 476);
            this.lblEuro3.Name = "lblEuro3";
            this.lblEuro3.Size = new System.Drawing.Size(23, 25);
            this.lblEuro3.TabIndex = 86;
            this.lblEuro3.Text = "€";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEuro2.Location = new System.Drawing.Point(819, 402);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(23, 25);
            this.lblEuro2.TabIndex = 85;
            this.lblEuro2.Text = "€";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(635, 666);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(252, 28);
            this.label17.TabIndex = 84;
            this.label17.Text = "Choose a payment method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(578, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Enter the amount you want to pay :";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComment.Location = new System.Drawing.Point(182, 583);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(310, 137);
            this.txtComment.TabIndex = 80;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTip.Location = new System.Drawing.Point(182, 409);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(131, 34);
            this.txtTip.TabIndex = 79;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(838, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 25);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(182, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 78;
            this.label5.Text = "Add comment:";
            // 
            // lblTotalName
            // 
            this.lblTotalName.AutoSize = true;
            this.lblTotalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalName.Location = new System.Drawing.Point(738, 477);
            this.lblTotalName.Name = "lblTotalName";
            this.lblTotalName.Size = new System.Drawing.Size(62, 25);
            this.lblTotalName.TabIndex = 77;
            this.lblTotalName.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(180, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 76;
            this.label8.Text = "Add tip:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(30, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 73;
            this.label11.Text = "Select a table:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(837, 364);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 25);
            this.lblSubTotal.TabIndex = 66;
            this.lblSubTotal.Text = "0.00";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(91, 129);
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
            this.lvOrderedItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvOrderedItems.FullRowSelect = true;
            this.lvOrderedItems.HideSelection = false;
            this.lvOrderedItems.Location = new System.Drawing.Point(181, 115);
            this.lvOrderedItems.Name = "lvOrderedItems";
            this.lvOrderedItems.Size = new System.Drawing.Size(717, 231);
            this.lvOrderedItems.TabIndex = 65;
            this.lvOrderedItems.UseCompatibleStateImageBehavior = false;
            this.lvOrderedItems.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item Name";
            this.itemName.Width = 250;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 250;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 213;
            // 
            // lblStillToPay
            // 
            this.lblStillToPay.AutoSize = true;
            this.lblStillToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStillToPay.Location = new System.Drawing.Point(654, 478);
            this.lblStillToPay.Name = "lblStillToPay";
            this.lblStillToPay.Size = new System.Drawing.Size(147, 25);
            this.lblStillToPay.TabIndex = 90;
            this.lblStillToPay.Text = "Still To be paid:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.Location = new System.Drawing.Point(862, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(37, 29);
            this.btnLogout.TabIndex = 92;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblSubTotalName
            // 
            this.lblSubTotalName.AutoSize = true;
            this.lblSubTotalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalName.Location = new System.Drawing.Point(692, 364);
            this.lblSubTotalName.Name = "lblSubTotalName";
            this.lblSubTotalName.Size = new System.Drawing.Size(108, 25);
            this.lblSubTotalName.TabIndex = 95;
            this.lblSubTotalName.Text = "Sub Total :";
            // 
            // lblHighVatName
            // 
            this.lblHighVatName.AutoSize = true;
            this.lblHighVatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighVatName.Location = new System.Drawing.Point(698, 400);
            this.lblHighVatName.Name = "lblHighVatName";
            this.lblHighVatName.Size = new System.Drawing.Size(103, 25);
            this.lblHighVatName.TabIndex = 97;
            this.lblHighVatName.Text = " High Vat :";
            // 
            // lblHighVat
            // 
            this.lblHighVat.AutoSize = true;
            this.lblHighVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighVat.Location = new System.Drawing.Point(840, 403);
            this.lblHighVat.Name = "lblHighVat";
            this.lblHighVat.Size = new System.Drawing.Size(50, 25);
            this.lblHighVat.TabIndex = 97;
            this.lblHighVat.Text = "0.00";
            // 
            // lblLowVatName
            // 
            this.lblLowVatName.AutoSize = true;
            this.lblLowVatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLowVatName.Location = new System.Drawing.Point(706, 436);
            this.lblLowVatName.Name = "lblLowVatName";
            this.lblLowVatName.Size = new System.Drawing.Size(94, 25);
            this.lblLowVatName.TabIndex = 97;
            this.lblLowVatName.Text = "Low Vat :";
            // 
            // lblLowVat
            // 
            this.lblLowVat.AutoSize = true;
            this.lblLowVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLowVat.Location = new System.Drawing.Point(839, 439);
            this.lblLowVat.Name = "lblLowVat";
            this.lblLowVat.Size = new System.Drawing.Size(50, 25);
            this.lblLowVat.TabIndex = 97;
            this.lblLowVat.Text = "0.00";
            // 
            // lblEuro4
            // 
            this.lblEuro4.AutoSize = true;
            this.lblEuro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEuro4.Location = new System.Drawing.Point(819, 438);
            this.lblEuro4.Name = "lblEuro4";
            this.lblEuro4.Size = new System.Drawing.Size(23, 25);
            this.lblEuro4.TabIndex = 85;
            this.lblEuro4.Text = "€";
            // 
            // btnTip
            // 
            this.btnTip.BackColor = System.Drawing.Color.LightCoral;
            this.btnTip.Location = new System.Drawing.Point(181, 465);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(94, 37);
            this.btnTip.TabIndex = 98;
            this.btnTip.Text = "Add";
            this.btnTip.UseVisualStyleBackColor = false;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.LightCoral;
            this.btnComment.Location = new System.Drawing.Point(182, 746);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(131, 42);
            this.btnComment.TabIndex = 99;
            this.btnComment.Text = "Add Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // BillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(928, 813);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnTip);
            this.Controls.Add(this.lblLowVat);
            this.Controls.Add(this.lblLowVatName);
            this.Controls.Add(this.lblHighVat);
            this.Controls.Add(this.lblHighVatName);
            this.Controls.Add(this.lblSubTotalName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblStillToPay);
            this.Controls.Add(this.txtSplitBox);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.lblEuro1);
            this.Controls.Add(this.lblEuro3);
            this.Controls.Add(this.lblEuro4);
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
            this.Location = new System.Drawing.Point(20, 120);
            this.Name = "BillUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ListView lvOrderedItems;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label lblStillToPay;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSubTotalName;
        private System.Windows.Forms.Label lblHighVatName;
        private System.Windows.Forms.Label lblHighVat;
        private System.Windows.Forms.Label lblLowVatName;
        private System.Windows.Forms.Label lblLowVat;
        private System.Windows.Forms.Label lblEuro4;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.Button btnComment;
    }
}