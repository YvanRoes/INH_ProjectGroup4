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
        int tableNumber;
        string tableStatus;
        public TableView()
        {
            InitializeComponent();
            Show();
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
        //checks if the table currently has any running or ready to be served orders
        private void CheckTableStatus (int table, out string tableStatus)
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
            else
            {
                tableStatus = "Free";
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
            mainWindow.ShowDialog();
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


        //clicking the table buttons will change its status according to the TableStatus method
        private void btnTable1_Click(object sender, EventArgs e)
        {
            tableNumber = 1;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable1.BackColor = Color.White;
            }
            else if (tableStatus == "Ready to serve")
            {
                btnTable1.BackColor = Color.Red;
            }
            else
            {
                btnTable1.BackColor = Color.Green;
            }
            txtTable1.Text = $"{tableStatus}";
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            tableNumber = 2;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable2.BackColor = Color.White;
            }
            else if (tableStatus == "Ready to serve")
            {
                btnTable2.BackColor = Color.Red;
            }
            else if (tableStatus == "Occupied")
            {
                btnTable2.BackColor = Color.White;
            }
            else
            {
                btnTable2.BackColor = Color.Green;
            }
            txtTable2.Text = $"{tableStatus}";
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            tableNumber = 3;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable3.BackColor = Color.White;
            }
            else if (tableStatus == "Ready to serve")
            {
                btnTable3.BackColor = Color.Red;
            }
            else
            {
                btnTable3.BackColor = Color.Green;
            }
            txtTable3.Text = $"{tableStatus}";
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            tableNumber = 4;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable4.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable4.BackColor = Color.Red;
            }
            else
            {
                btnTable4.BackColor = Color.Green;
            }
            txtTable4.Text = $"{tableStatus}";
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            tableNumber = 5;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable4.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable5.BackColor = Color.Red;
            }
            else
            {
                btnTable5.BackColor = Color.Green;
            }
            txtTable5.Text = $"{tableStatus}";
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            tableNumber = 6;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable6.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable6.BackColor = Color.Red;
            }
            else
            {
                btnTable6.BackColor = Color.Green;
            }
            txtTable6.Text = $"{tableStatus}";
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            tableNumber = 7;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable7.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable7.BackColor = Color.Red;
            }
            else
            {
                btnTable7.BackColor = Color.Green;
            }
            txtTable7.Text = $"{tableStatus}";
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            tableNumber = 8;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable8.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable8.BackColor = Color.Red;
            }
            else
            {
                btnTable8.BackColor = Color.Green;
            }
            txtTable8.Text = $"{tableStatus}";
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            tableNumber = 9;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable9.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable9.BackColor = Color.Red;
            }
            else
            {
                btnTable9.BackColor = Color.Green;
            }
            txtTable9.Text = $"{tableStatus}";
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            tableNumber = 10;
            CheckTableStatus(tableNumber, out tableStatus);
            if (tableStatus == "Running")
            {
                btnTable10.BackColor = Color.White;
            }
            else if (tableStatus == "Ready")
            {
                btnTable10.BackColor = Color.Red;
            }
            else
            {
                btnTable10.BackColor = Color.Green;
            }
            txtTable10.Text = $"{tableStatus}";
        }
        //changes table status by clicking a table button
        /*private void OccupyOrFreeUpTable(object sender)
        {
            Control ctrl = ((Control)sender);

            switch (ctrl.BackColor.Name)
            {
                case "Red": //clicking a "ready to serve" table won't change its status to free or occupied
                    ctrl.BackColor = Color.Red;
                    tableStatus = "Ready to Serve"; 
                    break;
                case "Green": //if the table is free, clicking it will turn it to occupied
                    ctrl.BackColor = Color.White;
                    tableStatus = "Occupied";
                    break;
                case "White":
                    ctrl.BackColor = Color.Green;
                    tableStatus = "Free";
                    break;

                default: //the table is free by default
                    ctrl.BackColor = Color.Green;
                    tableStatus = "Free";
                    break;
            }
        }*/
    }
}
