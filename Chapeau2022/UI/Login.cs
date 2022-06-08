using System;
using Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;


namespace UI
{

    public partial class Login : Form
    {
        EmployeeService employeeService = new EmployeeService();
        Employee employee = new Employee();

        public Login()
        {
            InitializeComponent();
            Show();

            btnLogin.Enabled = false;

        }

        private string username;
        private string password;


        public void ButtonStatus()
        {
            if (txtUsername.TextLength > 0 && txtPassword.TextLength > 0)
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {

 
            if (!CheckPassword())
            {
                MessageBox.Show("Username or password  is incorrect!");
            }
            else
            {

                new MainWindow();
            }
           

        }
        private bool CheckPassword() //checks if the password is correct or not
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (employeeService.GetByEmployeeName(username).Count == 0 || username == "" || password == "")
            {
                return false;
            }

            employee = employeeService.GetByEmployeeName(username)[0];

            if (username == employee.Employee_Name && PasswordWithSaltHasher.IsPasswordCorrect(password, new HashWithSaltResult(employee.Salt, employee.Password)))
            {
                return true;
            }
            return false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) //stores username in a string

        {
            username = txtUsername.Text;
            ButtonStatus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) //stores password in a string
        {
            password = txtPassword.Text;
            ButtonStatus();
        }

        public void EmployeeRole()
        {

        }
      
    }
}
