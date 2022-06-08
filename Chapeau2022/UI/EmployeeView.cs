﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class EmployeeView : Form
    {
        public EmployeeService employeeService;
        public List<Employee> employees;
        public EmployeeView()
        {
            employeeService = new EmployeeService();
            employees = new List<Employee>();

            InitializeComponent();
            Start();
        }
        private void Start() 
        {
            employees = employeeService.GetAllEmployees();
            FillListView();
        }
        public void FillListView() 
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 30);
            listView1.Columns.Add("Name", 165);
            listView1.Columns.Add("Role", 105);
            listView1.Columns.Add("PIN", 50);

            foreach (Employee e in employees)
            {
                string[] tempItem = {e.Employee_Id.ToString(), e.Employee_Name, e.Employee_Role.ToString(), e.Employee_Pin.ToString()};
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
        }

        private void bttnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(this);
            addEmployee.ShowDialog();
        }

        private void bttnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the item.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    employeeService.DeleteEmployee(int.Parse(listView1.SelectedItems[0].Text));
                    employees = employeeService.GetAllEmployees();
                    FillListView();
                }
            }
            else
                MessageBox.Show("Please select an employee first.");
        }

        private void bttnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                EditEmployee editEmployee = new EditEmployee(employeeService.GetEmployeeById(int.Parse(listView1.SelectedItems[0].Text)), this);
                editEmployee.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Please select an employee you would like to edit first.");
            }
        }
        public void ListViewClearSelected() 
        {
            listView1.SelectedItems.Clear();
        }
    }
}
