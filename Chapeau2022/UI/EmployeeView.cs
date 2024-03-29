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
    public enum SortType { ascending, descending };
    public partial class EmployeeView : Form
    {
        public EmployeeService employeeService;

        public List<Employee> employees;
        public SortType sortType;
        public EmployeeView()
        {
            employeeService = new EmployeeService();
            employees = new List<Employee>();
            sortType = SortType.ascending;
            InitializeComponent();
            Start();
        }

        private void Start() 
        {
            employees = employeeService.GetAllEmployees();
            FillListView();
            changeSortTypeArrows();
        }

        public void FillListView() 
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 325);
            listView1.Columns.Add("Name", 375);
            listView1.Columns.Add("Role", 300);
            listView1.Columns.Add("PIN", 200);

            foreach (Employee e in employees)
            {
                string[] tempItem = {e.Employee_Id.ToString(), e.Employee_Name, e.Employee_Role.ToString(), "****"};
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
                EditEmployee editEmployee = new EditEmployee(employeeService.GetEmployeeById(int.Parse(listView1.SelectedItems[0].Text)), this, employeeService.GetEmployeeById(int.Parse(listView1.SelectedItems[0].Text)).Employee_Id);
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

        //sorting the listView
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                employees = employees.OrderBy(i => i.Employee_Id).ToList();
                FillListView();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                employees = employees.OrderBy(i => i.Employee_Role).ToList();
                FillListView();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                employees = employees.OrderBy(i => i.Employee_Name).ToList();
                FillListView();
            }
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees = employees.OrderBy(i => i.Employee_Id).ToList();
            FillListView();
        }
        
        private void staffRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees = employees.OrderBy(i => i.Employee_Role).ToList();
            FillListView();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees = employees.OrderBy(i => i.Employee_Name).ToList();
            FillListView();
        }
        //SORTING USING THE HEADER
        private void idToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(sortType == SortType.ascending)
                employees = employees.OrderBy(i => i.Employee_Id).ToList();
            else
                employees = employees.OrderByDescending(i => i.Employee_Id).ToList();

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;

            FillListView();
            changeSortTypeArrows();
        }

        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sortType == SortType.ascending)
                employees = employees.OrderBy(i => i.Employee_Name).ToList();
            else
                employees = employees.OrderByDescending(i => i.Employee_Name).ToList();

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;

            FillListView();
            changeSortTypeArrows();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortType == SortType.ascending)
                employees = employees.OrderBy(i => i.Employee_Role).ToList();
            else
                employees = employees.OrderByDescending(i => i.Employee_Role).ToList();

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;

            FillListView();
            changeSortTypeArrows();
        }

        private void pINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees = employees.OrderBy(i => i.Employee_Pin).ToList();
            FillListView();
        }
        private void changeSortTypeArrows()
        {
            if (sortType == SortType.descending)
            {
                idToolStripMenuItem1.Text = "Id ▼";
                nameToolStripMenuItem1.Text = "Name ▼";
                roleToolStripMenuItem.Text = "Role ▼";
                pINToolStripMenuItem.Text = "PIN ▼";
            }
            else
            {
                idToolStripMenuItem1.Text = "Id ▲";
                nameToolStripMenuItem1.Text = "Name ▲";
                roleToolStripMenuItem.Text = "Role ▲";
                pINToolStripMenuItem.Text = "PIN ▲";
            }
        }
    }
}
