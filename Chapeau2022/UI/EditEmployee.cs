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

namespace UI
{
    public partial class EditEmployee : Form
    {
        private Employee employee;
        private EmployeeService employeeService;
        EmployeeView employeeView;
        private Tools tools;
        public EditEmployee(Employee employee, EmployeeView employeeView)
        {
            this.employee = employee;
            this.employeeView = employeeView;
            tools = new Tools();
            employeeService = new EmployeeService();
            InitializeComponent();
            LoadEmployeeInformation();
        }
        public void LoadEmployeeInformation() 
        {
            textBoxEmployeeName.Text = employee.Employee_Name;
            textBoxPIN.Text = employee.Employee_Pin.ToString();
            textBoxSecretA.Text = employee.Employee_SecretAnwser;
            textBoxSecretQ.Text = employee.Employee_SecretQuestion.ToString();
            int radioIndex = (int)employee.Employee_Role;

            if (radioIndex == 1)
                radioButton1.Checked = true;
            else if (radioIndex == 2)
                radioButton2.Checked = true;
            else if (radioIndex == 3)
                radioButton3.Checked = true;
            else
                radioButton4.Checked = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Employee_Id = employeeService.GetLastId(),
                Employee_Name = textBoxEmployeeName.Text,
                Employee_Role = (EmployeeRole)(tools.IndexOfRadioButton(radioButton1, radioButton2, radioButton3, radioButton4)+1),
                Employee_Pin = int.Parse(textBoxPIN.Text),
                Employee_SecretQuestion = textBoxSecretQ.Text,
                Employee_SecretAnwser = textBoxSecretA.Text
            };

            employeeService.UpdateEmployee(employee);
            employeeView.employees = employeeService.GetAllDrinkItems();
            employeeView.FillListView();
            this.Close();
        }
    }
}
