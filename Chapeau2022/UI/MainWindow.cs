using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Size = new Size(200, 235);
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            new Order();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new Bill();
        }

        private void btnStockView_Click(object sender, EventArgs e)
        {
            StockView stock = new StockView();
            stock.Show();
        }

        private void btnKitchenView_Click(object sender, EventArgs e)
        {
            KitchenAndBar kitchenAndBar = new KitchenAndBar();
            kitchenAndBar.Show();
        }
    }
}
