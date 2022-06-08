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
    public partial class TableView : Form
    {
        OrderedItemService orderedItemService = new OrderedItemService();
        TableService tableService = new TableService();
        string text;
        OrderDisplay orderDisplay;
        public TableView()
        {
            InitializeComponent();
            Show();
            DisplayOrderedDrinkItem(ItemOrderedStatus.Ready);
            Waiter();

        }
        
        private void TableView_Load(object sender, EventArgs e)
        {

        }
        private void Waiter()
        {
            DisplayOrderedDrinkItem(ItemOrderedStatus.Ready);
            DisplayOrderedFoodItem(ItemOrderedStatus.Ready);
            DisplayOrderedDrinkItem(ItemOrderedStatus.NotReady);
            DisplayOrderedFoodItem(ItemOrderedStatus.NotReady);
            orderDisplay = OrderDisplay.Running;
        }

        //changes table status 
        private void TableStatus(object sender)
        {
            Control ctrl = ((Control)sender);

            switch (ctrl.BackColor.Name)
            {
                case "Red":
                    ctrl.BackColor = Color.Red;
                    text = "Ready to Serve";
                    break;
                case "Green":
                    ctrl.BackColor = Color.White;
                    text = "Occupied";
                    break;

                default:
                    ctrl.BackColor = Color.Green;
                    text = "Free";
                    break;
            }
        }
        private void DisplayOrderedDrinkItem(ItemOrderedStatus itemOrderedStatus)
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllDrinkOrders(itemOrderedStatus);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                if (orderedItem.menuItem is DrinkItem)
                {
                    DrinkItem item = (DrinkItem)orderedItem.menuItem;
                    ListViewItem li = new ListViewItem(orderedItem.table_Id.ToString());
                    li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                    li.SubItems.Add(orderedItem._itemOrdered_Qty.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                    li.Tag = orderedItem;
                    lvOrders.Items.Add(li);
                }
            }
        }
        private void DisplayOrderedFoodItem(ItemOrderedStatus itemOrderedStatus)
        {
            List<OrderedItem> orderedItems = orderedItemService.GetAllFoodOrders(itemOrderedStatus);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                if (orderedItem.menuItem is FoodItem)
                {
                    FoodItem item = (FoodItem)orderedItem.menuItem;
                    ListViewItem li = new ListViewItem(orderedItem.table_Id.ToString());
                    li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                    li.SubItems.Add(orderedItem._itemOrdered_Qty.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                    li.Tag = orderedItem;
                    lvOrders.Items.Add(li);
                }
            }
        }
        TimeSpan orderTimePlaced(DateTime placed)
        {
            TimeSpan orderTime = DateTime.Now - placed;
            return orderTime;
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable1.Text = $"{text}";
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable2.Text = $"{text}";
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable3.Text = $"{text}";
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable4.Text = $"{text}";
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable5.Text = $"{text}";
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable6.Text = $"{text}";
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable7.Text = $"{text}";
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable8.Text = $"{text}";
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable9.Text = $"{text}";
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            TableStatus(sender);
            txtTable10.Text = $"{text}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
