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
            DisplayRunningOrderedDrinkItem();
        }

        private void DisplayRunningOrderedDrinkItem()
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

        private void DisplayFinishedOrderedDrinkItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = ordredItemService.GetAllFinishedDrinkOrders();

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

        private void DisplayRunningOrderedFoodItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = ordredItemService.GetAllRunningFoodOrders();

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.Placed.ToString());
                li.SubItems.Add(orderedItem.ItemOrdered_Quantity.ToString());
                li.SubItems.Add(orderedItem.Item_CourseType.ToString());
                li.SubItems.Add(orderedItem.Item_Name);
                li.SubItems.Add(orderedItem.ItemOrderedDescription);
                li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                lvOrders.Items.Add(li);
            }
        }

        private void DisplayFinishedOrderedFoodItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = ordredItemService.GetAllFinishedFoodOrders();

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.Placed.ToString());
                li.SubItems.Add(orderedItem.ItemOrdered_Quantity.ToString());
                li.SubItems.Add(orderedItem.Item_CourseType.ToString());
                li.SubItems.Add(orderedItem.Item_Name);
                li.SubItems.Add(orderedItem.ItemOrderedDescription);
                li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                lvOrders.Items.Add(li);
            }
        }
    }
}
