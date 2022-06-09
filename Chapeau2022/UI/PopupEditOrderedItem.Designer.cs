namespace UI
{
    partial class PopupEditOrderedItem
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cBComments = new System.Windows.Forms.CheckBox();
            this.tBComments = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMenuItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(113, 233);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 23);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cBComments
            // 
            this.cBComments.AutoSize = true;
            this.cBComments.Location = new System.Drawing.Point(30, 135);
            this.cBComments.Name = "cBComments";
            this.cBComments.Size = new System.Drawing.Size(85, 19);
            this.cBComments.TabIndex = 15;
            this.cBComments.Text = "Comments";
            this.cBComments.UseVisualStyleBackColor = true;
            this.cBComments.Click += new System.EventHandler(this.cBComments_CheckedChanged);
            // 
            // tBComments
            // 
            this.tBComments.Enabled = false;
            this.tBComments.Location = new System.Drawing.Point(30, 160);
            this.tBComments.Name = "tBComments";
            this.tBComments.Size = new System.Drawing.Size(178, 69);
            this.tBComments.TabIndex = 14;
            this.tBComments.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(30, 93);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(33, 23);
            this.btnSubstract.TabIndex = 12;
            this.btnSubstract.Text = "-1";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(69, 93);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 23);
            this.txtQty.TabIndex = 11;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 54);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 15);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "label1";
            // 
            // lblMenuItemName
            // 
            this.lblMenuItemName.AutoSize = true;
            this.lblMenuItemName.Location = new System.Drawing.Point(30, 27);
            this.lblMenuItemName.Name = "lblMenuItemName";
            this.lblMenuItemName.Size = new System.Drawing.Size(38, 15);
            this.lblMenuItemName.TabIndex = 9;
            this.lblMenuItemName.Text = "label1";
            // 
            // PopupEditOrderedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 268);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cBComments);
            this.Controls.Add(this.tBComments);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMenuItemName);
            this.Name = "PopupEditOrderedItem";
            this.Text = "PopupEditOrderedItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox cBComments;
        private System.Windows.Forms.RichTextBox tBComments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMenuItemName;
    }
}