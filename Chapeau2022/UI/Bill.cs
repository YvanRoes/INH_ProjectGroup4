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

namespace UI
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            Show();
            ListOrderedItems();
        }
        private void ListOrderedItems()
        {
            BillService billService = new BillService();
            List<OrderedItem> orderedItems = billService.GetAllOrderedItems();

            // clear the listview before filling it again
            lvOrderedItems.Items.Clear();

            foreach (OrderedItem orderItems in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderItems.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderItems._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderItems.menuItem.Item_Price.ToString());
                lvOrderedItems.Items.Add(li);

            }
        }


    }
}
