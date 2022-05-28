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

            //DisplayRunningOrderedFoodItem();

        }

        private void DisplayRunningOrderedDrinkItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = ordredItemService.GetAllDrinkOrders(ItemOrderedStatus.notReady);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderTimePlaced(orderedItem.Placed).TotalMinutes.ToString());
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
            List<OrderedItem> orderedItems = ordredItemService.GetAllDrinkOrders(ItemOrderedStatus.ready);

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
            List<OrderedItem> orderedItems = ordredItemService.GetAllFoodOrders(ItemOrderedStatus.notReady);

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
            List<OrderedItem> orderedItems = ordredItemService.GetAllFoodOrders(ItemOrderedStatus.notReady);

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

        private void btnRunning_Click(object sender, EventArgs e)
        {
            DisplayRunningOrderedDrinkItem();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            DisplayFinishedOrderedDrinkItem();
        }

        TimeSpan orderTimePlaced(DateTime placed)
        {
            TimeSpan orderTime = DateTime.Now - placed;
            return orderTime;
        }
    }
}
