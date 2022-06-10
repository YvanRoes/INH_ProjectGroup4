using System;
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
        private int employeeId;

        public EditEmployee(Employee employee, EmployeeView employeeView, int employeeId)
        {
            this.employee = employee;
            this.employeeView = employeeView;
            this.employeeId = employeeId;
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
            switch (radioIndex)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckForErrors()) 
            {
                return;
            }

            Employee employee = new Employee()
            {
                Employee_Id = employeeId,
                Employee_Name = textBoxEmployeeName.Text,
                Employee_Role = (EmployeeRole)(tools.IndexOfRadioButton(radioButton1, radioButton2, radioButton3, radioButton4)+1),
                Employee_Pin = int.Parse(textBoxPIN.Text),
                Employee_SecretQuestion = textBoxSecretQ.Text,
                Employee_SecretAnwser = textBoxSecretA.Text
            };
            employeeService.UpdateEmployee(employee);
            employeeView.FillListView();
            employeeView.ListViewClearSelected();
            this.Close();
        }
        private bool CheckForErrors() 
        {
            if (string.IsNullOrWhiteSpace(textBoxEmployeeName.Text) || string.IsNullOrEmpty(textBoxEmployeeName.Text))
            {
                MessageBox.Show("Item name cannot be empty.");
                return true;
            }

            if (tools.hasInt(textBoxEmployeeName.Text) || tools.hasSpecialChar(textBoxEmployeeName.Text))
            {
                MessageBox.Show("Name cannot contain integers or special characters.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(textBoxPIN.Text) || string.IsNullOrEmpty(textBoxPIN.Text))
                textBoxPIN.Text = "1234";

            if (string.IsNullOrWhiteSpace(textBoxSecretQ.Text) || string.IsNullOrEmpty(textBoxSecretQ.Text))
            {
                MessageBox.Show("Secret question cannot be empty.");
                return true;
            }

            if (string.IsNullOrWhiteSpace(textBoxSecretA.Text) || string.IsNullOrEmpty(textBoxSecretA.Text))
            {
                MessageBox.Show("Secret question cannot be empty.");
                return true;
            }
            return false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeeView.employees = employeeService.GetAllEmployees();
            employeeView.ListViewClearSelected();
            employeeView.FillListView();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
