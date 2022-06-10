namespace UI
{
    partial class AddItem
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBoxAlcoholContent = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblDrinkName = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.groupBoxCourse = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAmountNeeded = new System.Windows.Forms.TextBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.cbDinner = new System.Windows.Forms.CheckBox();
            this.cbLunch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxAlcoholContent.SuspendLayout();
            this.groupBoxCourse.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 20);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Drink Item";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 42);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Food Item";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Create New Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(10, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(130, 71);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Item Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 20);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Alcoholic";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlcoholContent
            // 
            this.groupBoxAlcoholContent.Controls.Add(this.radioButton5);
            this.groupBoxAlcoholContent.Controls.Add(this.radioButton4);
            this.groupBoxAlcoholContent.Location = new System.Drawing.Point(194, 198);
            this.groupBoxAlcoholContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAlcoholContent.Name = "groupBoxAlcoholContent";
            this.groupBoxAlcoholContent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAlcoholContent.Size = new System.Drawing.Size(150, 71);
            this.groupBoxAlcoholContent.TabIndex = 31;
            this.groupBoxAlcoholContent.TabStop = false;
            this.groupBoxAlcoholContent.Text = "Alcohol Content";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 42);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Non-Alcoholic";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(16, 252);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(119, 23);
            this.textBoxQuantity.TabIndex = 29;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(16, 198);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(119, 23);
            this.textBoxPrice.TabIndex = 27;
            // 
            // lblDrinkName
            // 
            this.lblDrinkName.AutoSize = true;
            this.lblDrinkName.Location = new System.Drawing.Point(16, 132);
            this.lblDrinkName.Name = "lblDrinkName";
            this.lblDrinkName.Size = new System.Drawing.Size(70, 15);
            this.lblDrinkName.TabIndex = 26;
            this.lblDrinkName.Text = "Drink Name";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(16, 149);
            this.textBoxItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(330, 23);
            this.textBoxItemName.TabIndex = 25;
            // 
            // groupBoxCourse
            // 
            this.groupBoxCourse.Controls.Add(this.radioButton7);
            this.groupBoxCourse.Controls.Add(this.radioButton8);
            this.groupBoxCourse.Controls.Add(this.radioButton9);
            this.groupBoxCourse.Location = new System.Drawing.Point(194, 198);
            this.groupBoxCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCourse.Name = "groupBoxCourse";
            this.groupBoxCourse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCourse.Size = new System.Drawing.Size(150, 92);
            this.groupBoxCourse.TabIndex = 32;
            this.groupBoxCourse.TabStop = false;
            this.groupBoxCourse.Text = "Course";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(5, 64);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(58, 19);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Desert";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(5, 42);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(52, 19);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Main";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(5, 20);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(68, 19);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Apetizer";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(16, 132);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(69, 15);
            this.lblFoodName.TabIndex = 34;
            this.lblFoodName.Text = "Food Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(16, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 22);
            this.button1.TabIndex = 35;
            this.button1.Text = "Create Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 22);
            this.button2.TabIndex = 36;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Amount Needed";
            // 
            // textBoxAmountNeeded
            // 
            this.textBoxAmountNeeded.Location = new System.Drawing.Point(16, 310);
            this.textBoxAmountNeeded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmountNeeded.Name = "textBoxAmountNeeded";
            this.textBoxAmountNeeded.Size = new System.Drawing.Size(119, 23);
            this.textBoxAmountNeeded.TabIndex = 37;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.cbDinner);
            this.groupBoxMenu.Controls.Add(this.cbLunch);
            this.groupBoxMenu.Location = new System.Drawing.Point(194, 302);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMenu.Size = new System.Drawing.Size(150, 71);
            this.groupBoxMenu.TabIndex = 33;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // cbDinner
            // 
            this.cbDinner.AutoSize = true;
            this.cbDinner.Location = new System.Drawing.Point(69, 42);
            this.cbDinner.Name = "cbDinner";
            this.cbDinner.Size = new System.Drawing.Size(61, 19);
            this.cbDinner.TabIndex = 3;
            this.cbDinner.Text = "Dinner";
            this.cbDinner.UseVisualStyleBackColor = true;
            // 
            // cbLunch
            // 
            this.cbLunch.AutoSize = true;
            this.cbLunch.Location = new System.Drawing.Point(69, 21);
            this.cbLunch.Name = "cbLunch";
            this.cbLunch.Size = new System.Drawing.Size(59, 19);
            this.cbLunch.TabIndex = 2;
            this.cbLunch.Text = "Lunch";
            this.cbLunch.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAmountNeeded);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxCourse);
            this.Controls.Add(this.groupBoxAlcoholContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblDrinkName);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAlcoholContent.ResumeLayout(false);
            this.groupBoxAlcoholContent.PerformLayout();
            this.groupBoxCourse.ResumeLayout(false);
            this.groupBoxCourse.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBoxAlcoholContent;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label lblDrinkName;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.GroupBox groupBoxCourse;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAmountNeeded;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.CheckBox cbDinner;
        private System.Windows.Forms.CheckBox cbLunch;
    }
}