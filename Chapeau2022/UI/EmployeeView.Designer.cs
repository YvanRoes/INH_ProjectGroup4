namespace UI
{
    partial class EmployeeView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.bttnAddEmployee = new System.Windows.Forms.Button();
            this.bttnEditEmployee = new System.Windows.Forms.Button();
            this.bttnDeleteEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 307);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bttnAddEmployee
            // 
            this.bttnAddEmployee.Location = new System.Drawing.Point(476, 281);
            this.bttnAddEmployee.Name = "bttnAddEmployee";
            this.bttnAddEmployee.Size = new System.Drawing.Size(187, 29);
            this.bttnAddEmployee.TabIndex = 1;
            this.bttnAddEmployee.Text = "Add Employee";
            this.bttnAddEmployee.UseVisualStyleBackColor = true;
            this.bttnAddEmployee.Click += new System.EventHandler(this.bttnAddEmployee_Click);
            // 
            // bttnEditEmployee
            // 
            this.bttnEditEmployee.Location = new System.Drawing.Point(476, 334);
            this.bttnEditEmployee.Name = "bttnEditEmployee";
            this.bttnEditEmployee.Size = new System.Drawing.Size(187, 29);
            this.bttnEditEmployee.TabIndex = 2;
            this.bttnEditEmployee.Text = "Edit Employee";
            this.bttnEditEmployee.UseVisualStyleBackColor = true;
            this.bttnEditEmployee.Click += new System.EventHandler(this.bttnEditEmployee_Click);
            // 
            // bttnDeleteEmployee
            // 
            this.bttnDeleteEmployee.Location = new System.Drawing.Point(476, 388);
            this.bttnDeleteEmployee.Name = "bttnDeleteEmployee";
            this.bttnDeleteEmployee.Size = new System.Drawing.Size(187, 29);
            this.bttnDeleteEmployee.TabIndex = 3;
            this.bttnDeleteEmployee.Text = "Delete Employee";
            this.bttnDeleteEmployee.UseVisualStyleBackColor = true;
            this.bttnDeleteEmployee.Click += new System.EventHandler(this.bttnDeleteEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Management";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Id Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(476, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Staff Role";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Name";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnDeleteEmployee);
            this.Controls.Add(this.bttnEditEmployee);
            this.Controls.Add(this.bttnAddEmployee);
            this.Controls.Add(this.listView1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bttnAddEmployee;
        private System.Windows.Forms.Button bttnEditEmployee;
        private System.Windows.Forms.Button bttnDeleteEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}