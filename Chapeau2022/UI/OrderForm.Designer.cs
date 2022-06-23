namespace UI
{
    partial class OrderForm
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
            this.lVOrder = new System.Windows.Forms.ListView();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnAppetizers = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.gBLunchDinner = new System.Windows.Forms.GroupBox();
            this.rbDinner = new System.Windows.Forms.RadioButton();
            this.rbLunch = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrder_Id = new System.Windows.Forms.Label();
            this.lVOverview = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.gBLunchDinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVOrder
            // 
            this.lVOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lVOrder.HideSelection = false;
            this.lVOrder.Location = new System.Drawing.Point(12, 122);
            this.lVOrder.Name = "lVOrder";
            this.lVOrder.OwnerDraw = true;
            this.lVOrder.Size = new System.Drawing.Size(320, 300);
            this.lVOrder.TabIndex = 0;
            this.lVOrder.UseCompatibleStateImageBehavior = false;
            this.lVOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lVOrder_MouseDoubleClick);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.White;
            this.btnDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDrinks.Location = new System.Drawing.Point(12, 83);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.BackColor = System.Drawing.Color.White;
            this.btnAppetizers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAppetizers.Location = new System.Drawing.Point(95, 83);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(75, 23);
            this.btnAppetizers.TabIndex = 2;
            this.btnAppetizers.Text = "Appetizers";
            this.btnAppetizers.UseVisualStyleBackColor = false;
            this.btnAppetizers.Click += new System.EventHandler(this.btnAppetizers_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.White;
            this.btnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMain.Location = new System.Drawing.Point(176, 83);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Main course";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.White;
            this.btnDessert.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDessert.FlatAppearance.BorderSize = 5;
            this.btnDessert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDessert.Location = new System.Drawing.Point(257, 83);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(75, 23);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // gBLunchDinner
            // 
            this.gBLunchDinner.Controls.Add(this.rbDinner);
            this.gBLunchDinner.Controls.Add(this.rbLunch);
            this.gBLunchDinner.Location = new System.Drawing.Point(12, 12);
            this.gBLunchDinner.Name = "gBLunchDinner";
            this.gBLunchDinner.Size = new System.Drawing.Size(139, 46);
            this.gBLunchDinner.TabIndex = 8;
            this.gBLunchDinner.TabStop = false;
            this.gBLunchDinner.Text = "Menu";
            // 
            // rbDinner
            // 
            this.rbDinner.AutoSize = true;
            this.rbDinner.Location = new System.Drawing.Point(70, 21);
            this.rbDinner.Name = "rbDinner";
            this.rbDinner.Size = new System.Drawing.Size(60, 19);
            this.rbDinner.TabIndex = 1;
            this.rbDinner.TabStop = true;
            this.rbDinner.Text = "Dinner";
            this.rbDinner.UseVisualStyleBackColor = true;
            this.rbDinner.CheckedChanged += new System.EventHandler(this.rbDinner_CheckedChanged);
            // 
            // rbLunch
            // 
            this.rbLunch.AutoSize = true;
            this.rbLunch.Location = new System.Drawing.Point(6, 21);
            this.rbLunch.Name = "rbLunch";
            this.rbLunch.Size = new System.Drawing.Size(58, 19);
            this.rbLunch.TabIndex = 0;
            this.rbLunch.TabStop = true;
            this.rbLunch.Text = "Lunch";
            this.rbLunch.UseVisualStyleBackColor = true;
            this.rbLunch.CheckedChanged += new System.EventHandler(this.rbLunch_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(404, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 11;
            // 
            // btnLogout2
            // 
            this.btnLogout2.BackColor = System.Drawing.Color.Red;
            this.btnLogout2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout2.ForeColor = System.Drawing.Color.White;
            this.btnLogout2.Location = new System.Drawing.Point(631, 13);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(116, 39);
            this.btnLogout2.TabIndex = 13;
            this.btnLogout2.Text = "Logout";
            this.btnLogout2.UseVisualStyleBackColor = false;
            this.btnLogout2.Click += new System.EventHandler(this.Logout);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(382, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Abort order";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(592, 428);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(155, 32);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Finish order";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order Nr: ";
            // 
            // lblOrder_Id
            // 
            this.lblOrder_Id.AutoSize = true;
            this.lblOrder_Id.Location = new System.Drawing.Point(447, 87);
            this.lblOrder_Id.Name = "lblOrder_Id";
            this.lblOrder_Id.Size = new System.Drawing.Size(38, 15);
            this.lblOrder_Id.TabIndex = 8;
            this.lblOrder_Id.Text = "label1";
            // 
            // lVOverview
            // 
            this.lVOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lVOverview.HideSelection = false;
            this.lVOverview.Location = new System.Drawing.Point(382, 122);
            this.lVOverview.Name = "lVOverview";
            this.lVOverview.Size = new System.Drawing.Size(365, 300);
            this.lVOverview.TabIndex = 7;
            this.lVOverview.UseCompatibleStateImageBehavior = false;
            this.lVOverview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvOverview_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Table Nr:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(447, 61);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(38, 15);
            this.lblTable.TabIndex = 15;
            this.lblTable.Text = "label3";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 476);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout2);
            this.Controls.Add(this.gBLunchDinner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.lblOrder_Id);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lVOverview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAppetizers);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.lVOrder);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.gBLunchDinner.ResumeLayout(false);
            this.gBLunchDinner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lVOrder;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnAppetizers;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.GroupBox gBLunchDinner;
        private System.Windows.Forms.RadioButton rbDinner;
        private System.Windows.Forms.RadioButton rbLunch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrder_Id;
        private System.Windows.Forms.ListView lVOverview;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTable;
    }
}
