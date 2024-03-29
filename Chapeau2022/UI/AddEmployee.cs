﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class AddEmployee : Form
    {
        EmployeeService employeeService;
        EmployeeView employeeView;
        public AddEmployee(EmployeeView employeeView)
        {
            employeeService = new EmployeeService();
            this.employeeView = employeeView;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmployeeName.Text) || string.IsNullOrEmpty(textBoxEmployeeName.Text))
            {
                MessageBox.Show("Item name cannot be empty.");
                return;
            }
            if (int.TryParse(textBoxEmployeeName.Text, out int b) || Tools.hasSpecialChar(textBoxEmployeeName.Text))
            {
                MessageBox.Show("Name cannot contain integers or special characters.");
                return;
            }
            if (Tools.hasSpecialChar(textBoxEmployeeName.Text))
            {
                MessageBox.Show("The PIN cannot contain special characters.");
                return;
            }
            //if the user doesnt provide a PIN they are assigned a default one 
            if (string.IsNullOrWhiteSpace(textBoxPIN.Text) || string.IsNullOrEmpty(textBoxPIN.Text))
                textBoxPIN.Text = "1234";
            if (string.IsNullOrWhiteSpace(textBoxSecretQ.Text) || string.IsNullOrEmpty(textBoxSecretQ.Text))
            {
                MessageBox.Show("Secret question cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSecretA.Text) || string.IsNullOrEmpty(textBoxSecretA.Text))
            {
                MessageBox.Show("Secret question cannot be empty.");
                return;
            }
            Employee employee = new Employee()
            {
                Employee_Id = employeeService.GetLastId(),
                Employee_Name = textBoxEmployeeName.Text,
                Employee_Role = (EmployeeRole)(Tools.IndexOfRadioButton(radioButton9, radioButton8, radioButton7, radioButton1)+1),
                Employee_Pin = int.Parse(textBoxPIN.Text),
                Employee_SecretQuestion = textBoxSecretQ.Text,
                Employee_SecretAnwser = textBoxSecretA.Text
            };
            employeeService.AddEmployee(employee);
            employeeView.employees = employeeService.GetAllEmployees();
            employeeView.FillListView();
            this.Close();
        }

        private void groupBoxCourse_Enter(object sender, EventArgs e)
        {

        }
    }
}
