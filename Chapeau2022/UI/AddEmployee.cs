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
    public partial class AddEmployee : Form
    {
        Tools tools;
        EmployeeService employeeService;
        EmployeeView employeeView;
        public AddEmployee(EmployeeView employeeView)
        {
            tools = new Tools();
            employeeService = new EmployeeService();
            this.employeeView = employeeView;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Employee_Id = employeeService.GetLastId(),
                Employee_Name = textBoxEmployeeName.Text,
                Employee_Role = (EmployeeRole)(tools.IndexOfRadioButton(radioButton9, radioButton8, radioButton7, radioButton1)+1),
                Employee_Pin = int.Parse(textBoxPIN.Text),
                Employee_SecretQuestion = textBoxSecretQ.Text,
                Employee_SecretAnwser = textBoxSecretA.Text
            };

            employeeService.AddEmployee(employee);
            employeeView.employees = employeeService.GetAllEmployees();
            employeeView.FillListView();
            this.Close();
        }
    }
}
