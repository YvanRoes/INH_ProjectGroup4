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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Order = new System.Windows.Forms.ToolStripMenuItem();
            this.Overview = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrder_Id = new System.Windows.Forms.Label();
            this.lVOverview = new System.Windows.Forms.ListView();
            this.gBLunchDinner.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVOrder
            // 
            this.lVOrder.BackColor = System.Drawing.Color.White;
            this.lVOrder.HideSelection = false;
            this.lVOrder.Location = new System.Drawing.Point(18, 83);
            this.lVOrder.Name = "lVOrder";
            this.lVOrder.Size = new System.Drawing.Size(320, 300);
            this.lVOrder.TabIndex = 0;
            this.lVOrder.UseCompatibleStateImageBehavior = false;
            this.lVOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lVOrder_MouseDoubleClick);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(18, 388);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.Location = new System.Drawing.Point(101, 388);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(75, 23);
            this.btnAppetizers.TabIndex = 2;
            this.btnAppetizers.Text = "Appetizers";
            this.btnAppetizers.UseVisualStyleBackColor = true;
            this.btnAppetizers.Click += new System.EventHandler(this.btnAppetizers_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(182, 388);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Main course";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(263, 388);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(75, 23);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
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
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.btnLogout);
            this.pnlOrder.Controls.Add(this.gBLunchDinner);
            this.pnlOrder.Controls.Add(this.lVOrder);
            this.pnlOrder.Controls.Add(this.btnDrinks);
            this.pnlOrder.Controls.Add(this.btnDessert);
            this.pnlOrder.Controls.Add(this.btnAppetizers);
            this.pnlOrder.Controls.Add(this.btnMain);
            this.pnlOrder.Location = new System.Drawing.Point(12, 27);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(360, 425);
            this.pnlOrder.TabIndex = 9;
            this.pnlOrder.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(263, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Order,
            this.Overview});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Order
            // 
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(101, 20);
            this.Order.Text = "Make the Order";
            this.Order.Click += new System.EventHandler(this.makeTheOrderToolStripMenuItem_Click);
            // 
            // Overview
            // 
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(101, 20);
            this.Overview.Text = "Order Overview";
            this.Overview.Click += new System.EventHandler(this.orderOverviewToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(404, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 11;
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.btnLogout2);
            this.pnlOverview.Controls.Add(this.btnClear);
            this.pnlOverview.Controls.Add(this.btnFinish);
            this.pnlOverview.Controls.Add(this.label1);
            this.pnlOverview.Controls.Add(this.lblOrder_Id);
            this.pnlOverview.Controls.Add(this.lVOverview);
            this.pnlOverview.Location = new System.Drawing.Point(378, 27);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(406, 514);
            this.pnlOverview.TabIndex = 12;
            this.pnlOverview.Visible = false;
            // 
            // btnLogout2
            // 
            this.btnLogout2.Location = new System.Drawing.Point(309, 13);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(75, 23);
            this.btnLogout2.TabIndex = 13;
            this.btnLogout2.Text = "Logout";
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.Logout);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(19, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(365, 53);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear order items";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(19, 448);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(365, 53);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Finish order";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order Nr: ";
            // 
            // lblOrder_Id
            // 
            this.lblOrder_Id.AutoSize = true;
            this.lblOrder_Id.Location = new System.Drawing.Point(84, 52);
            this.lblOrder_Id.Name = "lblOrder_Id";
            this.lblOrder_Id.Size = new System.Drawing.Size(38, 15);
            this.lblOrder_Id.TabIndex = 8;
            this.lblOrder_Id.Text = "label1";
            // 
            // lVOverview
            // 
            this.lVOverview.HideSelection = false;
            this.lVOverview.Location = new System.Drawing.Point(19, 83);
            this.lVOverview.Name = "lVOverview";
            this.lVOverview.Size = new System.Drawing.Size(365, 300);
            this.lVOverview.TabIndex = 7;
            this.lVOverview.UseCompatibleStateImageBehavior = false;
            this.lVOverview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvOverview_MouseDoubleClick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 628);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Order";
            this.gBLunchDinner.ResumeLayout(false);
            this.gBLunchDinner.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
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
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Order;
        private System.Windows.Forms.ToolStripMenuItem Overview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrder_Id;
        private System.Windows.Forms.ListView lVOverview;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogout2;
    }
}
