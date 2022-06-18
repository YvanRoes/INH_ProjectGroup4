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
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        OrderedItemService orderedItemService = new OrderedItemService();
        TableService tableService = new TableService();
        int tableNumber;
        string tableStatus;
        public TableView()
        {
            InitializeComponent();
            Show();
            Waiter();
            
        }
        
        private void Waiter()
        {
            lvOrders.Items.Clear();
            DisplayOrderedDrinkItem(ItemOrderedStatus.Finished);
            DisplayOrderedFoodItem(ItemOrderedStatus.Finished);
            DisplayOrderedDrinkItem(ItemOrderedStatus.Running);
            DisplayOrderedFoodItem(ItemOrderedStatus.Running);
        }

        //fills the listview with the ordered drinks
        private void DisplayOrderedDrinkItem(ItemOrderedStatus itemOrderedStatus)
        {

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
        //fills the listview with ordered food
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
        }
        private void ServeOrderedItem()
        {
            foreach (ListViewItem item in lvOrders.SelectedItems)
            {
                orderedItemService.MarkOrderedItemAsServed((OrderedItem)item.Tag);
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvOrders.SelectedItems.Count == 0)
                {
                    throw new Exception("No order selected");
                }
                else if (lvOrders.SelectedItems[0].SubItems[4].Text == "NotReady")
                {
                    throw new Exception("This order is not yet ready to serve!");
                }
                else
                {
                    if (lvOrders.SelectedItems[0].SubItems[4].Text == "Ready")
                    {
                        ServeOrderedItem();
                        MessageBox.Show("Order has been served!");
                        Waiter();
                    }
                    else 
                    {
                        MessageBox.Show("Unable so serve order");                
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //checks if the table currently has any running or ready to be served orders
        private void CheckTableStatus(int table, Button b, out string tableStatus)
        {
            tableStatus = "";
            if (lvOrders.Items[0].SubItems[0].Text == $"{table}") //checks if the table number is in the listview
            {
                if (lvOrders.Items[0].SubItems[4].Text == "NotReady") //checks if the order is not ready
                {
                    tableStatus = "Running";
                }
                else if (lvOrders.Items[0].SubItems[4].Text == "Ready") //checks if the order is ready
                {
                    tableStatus = "Ready to serve";
                }
            }
            else if (b.BackColor == Color.White)
            {
                tableStatus = "Free";
            }
            else
            {
                tableStatus = "Occupied";
            }
        }
        void CheckButtonClick(object sender, EventArgs e) //checks which button was clicked 
        {
            Control ctrl = ((Control)sender);

            switch (ctrl.Name) //selects the correct table number
            {
                case "btnTable1":
                    tableNumber = 1;
                    break;
                case "btnTable2":
                    tableNumber = 2;
                    break;
                case "btnTable3":
                    tableNumber = 3;
                    break;
                case "btnTable4":
                    tableNumber = 4;
                    break;
                case "btnTable5":
                    tableNumber = 5;
                    break;
                case "btnTable6":
                    tableNumber = 6;
                    break;
                case "btnTable7":
                    tableNumber = 7;
                    break;
                case "btnTable8":
                    tableNumber = 8;
                    break;
                case "btnTable9":
                    tableNumber = 9;
                    break;
                case "btnTable10":
                    tableNumber = 10;
                    break;

                default: //the tablnumber is 1 by default
                    tableNumber = 1;
                    break;
            }
        }

        //clicking the table buttons will change its status according to the TableStatus method
        private void btnTable1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            CheckButtonClick(sender, e);
            CheckTableStatus(tableNumber, b, out tableStatus);
            if (tableStatus == "Running")
            {
                b.ForeColor = Color.Black;
                b.BackColor = Color.White;
            }
            else if (tableStatus == "Ready to serve")
            {
                b.BackColor = Color.Red;
                b.ForeColor = Color.White;
            }
            else if (tableStatus == "Free")
            {
                b.BackColor = Color.Green;
                b.ForeColor = Color.White;
            }
            else
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.Black;
            }
            switch (tableNumber) //fills the correct label
            {
                case 1:
                    txtTable1.Text = $"{tableStatus}";
                    break;
                case 2:
                    txtTable2.Text = $"{tableStatus}";
                    break;
                case 3:
                    txtTable3.Text = $"{tableStatus}";
                    break;
                case 4:
                    txtTable4.Text = $"{tableStatus}";
                    break;
                case 5:
                    txtTable5.Text = $"{tableStatus}";
                    break;
                case 6:
                    txtTable6.Text = $"{tableStatus}";
                    break;
                case 7:
                    txtTable7.Text = $"{tableStatus}";
                    break;
                case 8:
                    txtTable8.Text = $"{tableStatus}";
                    break;
                case 9:
                    txtTable9.Text = $"{tableStatus}";
                    break;
                case 10:
                    txtTable10.Text = $"{tableStatus}";
                    break;

                default: //the tablnumber is 1 by default
                    txtTable1.Text = $"{tableStatus}";
                    break;
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Waiter();
        }
    }
}
