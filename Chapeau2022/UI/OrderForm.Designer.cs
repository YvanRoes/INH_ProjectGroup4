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
            this.lVItems = new System.Windows.Forms.ListView();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnAppetizers = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.gBLunchDinner = new System.Windows.Forms.GroupBox();
            this.rbDinner = new System.Windows.Forms.RadioButton();
            this.rbLunch = new System.Windows.Forms.RadioButton();
            this.gBLunchDinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVItems
            // 
            this.lVItems.BackColor = System.Drawing.Color.White;
            this.lVItems.HideSelection = false;
            this.lVItems.Location = new System.Drawing.Point(12, 64);
            this.lVItems.Name = "lVItems";
            this.lVItems.Size = new System.Drawing.Size(318, 299);
            this.lVItems.TabIndex = 0;
            this.lVItems.UseCompatibleStateImageBehavior = false;
            this.lVItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lVItems_MouseDoubleClick);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(12, 369);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnAppetizers
            // 
            this.btnAppetizers.Location = new System.Drawing.Point(93, 369);
            this.btnAppetizers.Name = "btnAppetizers";
            this.btnAppetizers.Size = new System.Drawing.Size(75, 23);
            this.btnAppetizers.TabIndex = 2;
            this.btnAppetizers.Text = "Appetizers";
            this.btnAppetizers.UseVisualStyleBackColor = true;
            this.btnAppetizers.Click += new System.EventHandler(this.btnAppetizers_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(174, 369);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Main course";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(255, 369);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(75, 23);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(12, 398);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(318, 51);
            this.btnOverview.TabIndex = 5;
            this.btnOverview.Text = "Order Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // gBLunchDinner
            // 
            this.gBLunchDinner.Controls.Add(this.rbDinner);
            this.gBLunchDinner.Controls.Add(this.rbLunch);
            this.gBLunchDinner.Location = new System.Drawing.Point(12, 12);
            this.gBLunchDinner.Name = "gBLunchDinner";
            this.gBLunchDinner.Size = new System.Drawing.Size(156, 46);
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 461);
            this.Controls.Add(this.gBLunchDinner);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAppetizers);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.lVItems);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.gBLunchDinner.ResumeLayout(false);
            this.gBLunchDinner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVItems;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnAppetizers;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.GroupBox gBLunchDinner;
        private System.Windows.Forms.RadioButton rbDinner;
        private System.Windows.Forms.RadioButton rbLunch;
    }
}
