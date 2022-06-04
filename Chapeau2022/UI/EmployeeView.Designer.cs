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
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 216);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bttnAddEmployee
            // 
            this.bttnAddEmployee.Location = new System.Drawing.Point(436, 111);
            this.bttnAddEmployee.Name = "bttnAddEmployee";
            this.bttnAddEmployee.Size = new System.Drawing.Size(157, 29);
            this.bttnAddEmployee.TabIndex = 1;
            this.bttnAddEmployee.Text = "Add Employee";
            this.bttnAddEmployee.UseVisualStyleBackColor = true;
            this.bttnAddEmployee.Click += new System.EventHandler(this.bttnAddEmployee_Click);
            // 
            // bttnEditEmployee
            // 
            this.bttnEditEmployee.Location = new System.Drawing.Point(436, 164);
            this.bttnEditEmployee.Name = "bttnEditEmployee";
            this.bttnEditEmployee.Size = new System.Drawing.Size(157, 29);
            this.bttnEditEmployee.TabIndex = 2;
            this.bttnEditEmployee.Text = "Edit Employee";
            this.bttnEditEmployee.UseVisualStyleBackColor = true;
            this.bttnEditEmployee.Click += new System.EventHandler(this.bttnEditEmployee_Click);
            // 
            // bttnDeleteEmployee
            // 
            this.bttnDeleteEmployee.Location = new System.Drawing.Point(436, 218);
            this.bttnDeleteEmployee.Name = "bttnDeleteEmployee";
            this.bttnDeleteEmployee.Size = new System.Drawing.Size(157, 29);
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
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnDeleteEmployee);
            this.Controls.Add(this.bttnEditEmployee);
            this.Controls.Add(this.bttnAddEmployee);
            this.Controls.Add(this.listView1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bttnAddEmployee;
        private System.Windows.Forms.Button bttnEditEmployee;
        private System.Windows.Forms.Button bttnDeleteEmployee;
        private System.Windows.Forms.Label label1;
    }
}