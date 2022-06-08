namespace UI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTableView = new System.Windows.Forms.Button();
            this.btnOrderView = new System.Windows.Forms.Button();
            this.btnKitchenView = new System.Windows.Forms.Button();
            this.btnBarView = new System.Windows.Forms.Button();
            this.btnStockView = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTableView
            // 
            this.btnTableView.Location = new System.Drawing.Point(23, 12);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(138, 23);
            this.btnTableView.TabIndex = 0;
            this.btnTableView.Text = "Table view";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnOrderView
            // 
            this.btnOrderView.Location = new System.Drawing.Point(23, 41);
            this.btnOrderView.Name = "btnOrderView";
            this.btnOrderView.Size = new System.Drawing.Size(138, 23);
            this.btnOrderView.TabIndex = 1;
            this.btnOrderView.Text = "Order view";
            this.btnOrderView.UseVisualStyleBackColor = true;
            this.btnOrderView.Click += new System.EventHandler(this.btnOrderView_Click);
            // 
            // btnKitchenView
            // 
            this.btnKitchenView.Location = new System.Drawing.Point(23, 70);
            this.btnKitchenView.Name = "btnKitchenView";
            this.btnKitchenView.Size = new System.Drawing.Size(138, 23);
            this.btnKitchenView.TabIndex = 2;
            this.btnKitchenView.Text = "Kitchen view";
            this.btnKitchenView.UseVisualStyleBackColor = true;
            this.btnKitchenView.Click += new System.EventHandler(this.btnKitchenView_Click);
            // 
            // btnBarView
            // 
            this.btnBarView.Location = new System.Drawing.Point(23, 99);
            this.btnBarView.Name = "btnBarView";
            this.btnBarView.Size = new System.Drawing.Size(138, 23);
            this.btnBarView.TabIndex = 3;
            this.btnBarView.Text = "Bar view";
            this.btnBarView.UseVisualStyleBackColor = true;
            this.btnBarView.Click += new System.EventHandler(this.btnBarView_Click);
            // 
            // btnStockView
            // 
            this.btnStockView.Location = new System.Drawing.Point(23, 128);
            this.btnStockView.Name = "btnStockView";
            this.btnStockView.Size = new System.Drawing.Size(138, 23);
            this.btnStockView.TabIndex = 4;
            this.btnStockView.Text = "Stock view";
            this.btnStockView.UseVisualStyleBackColor = true;
            this.btnStockView.Click += new System.EventHandler(this.btnStockView_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(23, 184);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(138, 23);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Employee View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(138, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 240);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnStockView);
            this.Controls.Add(this.btnBarView);
            this.Controls.Add(this.btnKitchenView);
            this.Controls.Add(this.btnOrderView);
            this.Controls.Add(this.btnTableView);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTableView;
        private System.Windows.Forms.Button btnOrderView;
        private System.Windows.Forms.Button btnKitchenView;
        private System.Windows.Forms.Button btnBarView;
        private System.Windows.Forms.Button btnStockView;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
    }
}
