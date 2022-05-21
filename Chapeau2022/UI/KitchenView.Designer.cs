namespace UI
{
    partial class KitchenView
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rdbtnFinishedOrders = new System.Windows.Forms.RadioButton();
            this.rdbtnRunningOrders = new System.Windows.Forms.RadioButton();
            this.btnReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitchen View";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(187, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 207);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // rdbtnFinishedOrders
            // 
            this.rdbtnFinishedOrders.AutoSize = true;
            this.rdbtnFinishedOrders.Location = new System.Drawing.Point(34, 126);
            this.rdbtnFinishedOrders.Name = "rdbtnFinishedOrders";
            this.rdbtnFinishedOrders.Size = new System.Drawing.Size(103, 19);
            this.rdbtnFinishedOrders.TabIndex = 7;
            this.rdbtnFinishedOrders.TabStop = true;
            this.rdbtnFinishedOrders.Text = "finished orders";
            this.rdbtnFinishedOrders.UseVisualStyleBackColor = true;
            // 
            // rdbtnRunningOrders
            // 
            this.rdbtnRunningOrders.AutoSize = true;
            this.rdbtnRunningOrders.Location = new System.Drawing.Point(34, 101);
            this.rdbtnRunningOrders.Name = "rdbtnRunningOrders";
            this.rdbtnRunningOrders.Size = new System.Drawing.Size(103, 19);
            this.rdbtnRunningOrders.TabIndex = 6;
            this.rdbtnRunningOrders.TabStop = true;
            this.rdbtnRunningOrders.Text = "running orders";
            this.rdbtnRunningOrders.UseVisualStyleBackColor = true;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(562, 397);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 23);
            this.btnReady.TabIndex = 8;
            this.btnReady.Text = "ready";
            this.btnReady.UseVisualStyleBackColor = true;
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.rdbtnFinishedOrders);
            this.Controls.Add(this.rdbtnRunningOrders);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "KitchenView";
            this.Text = "KitchenView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rdbtnFinishedOrders;
        private System.Windows.Forms.RadioButton rdbtnRunningOrders;
        private System.Windows.Forms.Button btnReady;
    }
}