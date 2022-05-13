using System;
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
    public partial class Order : Form
    {
        private OrderService _orderService;
        public Order()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(600, 520);
            Start();
        }

        void Start()
        {
            _orderService = new OrderService();
            List<MenuItem> items = _orderService.GetAllItems();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 124);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 124);
            listView1.Columns.Add("Type", 124);

            foreach(MenuItem item in items)
            {
                string[] tempItem = {item._itemId.ToString(), item._itemName, item._ItemPrice.ToString(), item._itemType.ToString()};
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
        }
    }
}
