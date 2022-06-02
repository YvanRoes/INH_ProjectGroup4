namespace UI
{
    partial class OrderOverview
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
            this.lvOrder = new System.Windows.Forms.ListView();
            this.lblOrder_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvOrder
            // 
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(12, 64);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(405, 374);
            this.lvOrder.TabIndex = 1;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // lblOrder_Id
            // 
            this.lblOrder_Id.AutoSize = true;
            this.lblOrder_Id.Location = new System.Drawing.Point(75, 31);
            this.lblOrder_Id.Name = "lblOrder_Id";
            this.lblOrder_Id.Size = new System.Drawing.Size(38, 15);
            this.lblOrder_Id.TabIndex = 2;
            this.lblOrder_Id.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Nr: ";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(423, 64);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(223, 53);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "View details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(423, 182);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(223, 53);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish order";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(423, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(223, 53);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear order items";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OrderOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 461);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder_Id);
            this.Controls.Add(this.lvOrder);
            this.Name = "OrderOverview";
            this.Text = "btnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.Label lblOrder_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnClear;
    }
}