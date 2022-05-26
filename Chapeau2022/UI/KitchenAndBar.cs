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
            DisplayRunningOrderedItem();
        }

        private void DisplayRunningOrderedItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = ordredItemService.GetAllRunningDrinkOrders();

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.Placed.ToString());
                li.SubItems.Add(orderedItem.ItemOrdered_Quantity.ToString());
                li.SubItems.Add(orderedItem.Item_DrinkType.ToString());
                li.SubItems.Add(orderedItem.Item_Name);
                li.SubItems.Add(orderedItem.ItemOrderedDescription);
                li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                lvOrders.Items.Add(li);
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
