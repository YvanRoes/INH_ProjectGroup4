using Logic;
using Model;
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
    public partial class KitchenAndBar : Form
    {
        OrderedItemService ordredItemService = new OrderedItemService();
        public KitchenAndBar()
        {
            InitializeComponent();
        }

        private void DisplayOrders()
        {
            lvOrders.Items.Clear();
            ListViewItem li = new ListViewItem();
            List<OrderedItem> orderedItems = ordredItemService.GetAllOrders();

            foreach (OrderedItem orderedItem in orderedItems)
            {
                li.SubItems.Add(orderedItem.quantity.ToString());
            }
        }

        private void DisplayRunningOrders()
        {

        }

        private void DisplayFinishedOrders()
        {

        }
    }
}
