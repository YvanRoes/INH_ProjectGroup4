namespace ChapeauTest
{
    partial class PopupAddToOrder
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
            this.lblMenuItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tBComments = new System.Windows.Forms.RichTextBox();
            this.cBComments = new System.Windows.Forms.CheckBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuItemName
            // 
            this.lblMenuItemName.AutoSize = true;
            this.lblMenuItemName.Location = new System.Drawing.Point(20, 32);
            this.lblMenuItemName.Name = "lblMenuItemName";
            this.lblMenuItemName.Size = new System.Drawing.Size(38, 15);
            this.lblMenuItemName.TabIndex = 0;
            this.lblMenuItemName.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 59);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "label1";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(59, 98);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 23);
            this.txtQty.TabIndex = 2;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(20, 98);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(33, 23);
            this.btnSubstract.TabIndex = 3;
            this.btnSubstract.Text = "-1";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(165, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tBComments
            // 
            this.tBComments.Enabled = false;
            this.tBComments.Location = new System.Drawing.Point(20, 165);
            this.tBComments.Name = "tBComments";
            this.tBComments.Size = new System.Drawing.Size(178, 69);
            this.tBComments.TabIndex = 6;
            this.tBComments.Text = "";
            // 
            // cBComments
            // 
            this.cBComments.AutoSize = true;
            this.cBComments.Location = new System.Drawing.Point(20, 140);
            this.cBComments.Name = "cBComments";
            this.cBComments.Size = new System.Drawing.Size(85, 19);
            this.cBComments.TabIndex = 7;
            this.cBComments.Text = "Comments";
            this.cBComments.UseVisualStyleBackColor = true;
            this.cBComments.CheckedChanged += new System.EventHandler(this.cBComments_CheckedChanged);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(84, 240);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(114, 23);
            this.btnAddToOrder.TabIndex = 8;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // PopupAddToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 268);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.cBComments);
            this.Controls.Add(this.tBComments);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMenuItemName);
            this.Name = "PopupAddToOrder";
            this.Text = "PopupAddToOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox tBComments;
        private System.Windows.Forms.CheckBox cBComments;
        private System.Windows.Forms.Button btnAddToOrder;
    }
}