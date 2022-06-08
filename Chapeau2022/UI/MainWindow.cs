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

namespace UI
{
    public partial class MainWindow : Form
    {
        Employee employee = new Employee();

        public MainWindow()
        {
            InitializeComponent();
            this.Size = new Size(228, 347);
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            new OrderForm(4, 1);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new BillUI();
        }

        private void btnStockView_Click(object sender, EventArgs e)
        {
            StockView stock = new StockView();
            stock.Show();
        }

        private void btnKitchenView_Click(object sender, EventArgs e)
        {
            employee.Employee_Role = EmployeeRole.chef;

            this.Hide();
            KitchenAndBar kitchenAndBar = new KitchenAndBar(employee);
            kitchenAndBar.ShowDialog();
        }

        private void btnBarView_Click(object sender, EventArgs e)
        {
            employee.Employee_Role = EmployeeRole.bartender;

            this.Hide();
            KitchenAndBar kitchenAndBar = new KitchenAndBar(employee);
            kitchenAndBar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login();
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TableView();
        }
    }
}
