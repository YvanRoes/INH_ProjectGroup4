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
using System.Timers;
using System.Windows.Forms;

namespace UI
{
    public partial class KitchenAndBar : Form, INotifierObserver
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        OrderedItemService orderedItemService = new OrderedItemService();
        Employee employee;
        OrderDisplay orderDisplay;
        
        public KitchenAndBar(Employee employee)
        {
            InitializeComponent();
            this.Show();
            this.employee = employee;

            if (employee.Employee_Role == EmployeeRole.bartender)
            {
                BarView();
            }
            else
            {
                KitchenView();
            }

            Timer();
        }

        private void BarView()
        {
            lblKitchenAndBar.Text = "Bar";
            lvOrders.Columns[3].Text = "Drink Type";
            lvOrders.Columns[4].Text = "Drink Name";
            lblReadyCourse.Hide();
            chbxAppetizer.Hide();
            chbxMain.Hide();
            chbxDessert.Hide();
            btnReady.Location = new Point(545, 163);
            DisplayOrderedDrinkItem(ItemOrderedStatus.NotReady);
            orderDisplay = OrderDisplay.Running;
        }

        private void KitchenView()
        {
            lblKitchenAndBar.Text = "Kitchen";
            lvOrders.Columns[3].Text = "Food Type";
            lvOrders.Columns[4].Text = "Food Name";
            DisplayOrderedFoodItem(ItemOrderedStatus.NotReady);
            orderDisplay = OrderDisplay.Running;
        }

        void Timer()
        {
            timer.Interval = 10000; // timer set to 10000 milisecond = 10 second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Refresh();
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
                    li.SubItems.Add(item.Item_DrinkType.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem._itemOrdered_Comment);
                    li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                    li.Tag = orderedItem;
                    lvOrders.Items.Add(li);
                }
            }
        }

        private void DisplayOrderedFoodItem(ItemOrderedStatus itemOrderedStatus)
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllFoodOrders(itemOrderedStatus);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                if(orderedItem.menuItem is FoodItem)
                {
                    FoodItem item = (FoodItem)orderedItem.menuItem;
                    ListViewItem li = new ListViewItem(orderedItem.table_Id.ToString());
                    li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                    li.SubItems.Add(orderedItem._itemOrdered_Qty.ToString());
                    li.SubItems.Add(item.Item_CourseType.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem._itemOrdered_Comment);
                    li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                    li.Tag = orderedItem;
                    lvOrders.Items.Add(li);
                }   
            }
        }

        private void btnRunning_Click(object sender, EventArgs e)
        {
            orderDisplay = OrderDisplay.Running;

            if (employee.Employee_Role == EmployeeRole.bartender)
            {
                DisplayOrderedDrinkItem(ItemOrderedStatus.NotReady);
            }
            else
            {
                DisplayOrderedFoodItem(ItemOrderedStatus.NotReady);
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            orderDisplay = OrderDisplay.Finished;

            if (employee.Employee_Role == EmployeeRole.bartender)
            {
                DisplayOrderedDrinkItem(ItemOrderedStatus.Ready);
            }
            else
            {
                DisplayOrderedFoodItem(ItemOrderedStatus.Ready);
            }
        }

        TimeSpan orderTimePlaced(DateTime placed)
        {
            TimeSpan orderTime = DateTime.Now - placed;
            return orderTime;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            if (orderDisplay == OrderDisplay.Running)
            {
                if (employee.Employee_Role == EmployeeRole.bartender)
                {
                    DisplayOrderedDrinkItem(ItemOrderedStatus.NotReady);
                }
                else
                {
                    DisplayOrderedFoodItem(ItemOrderedStatus.NotReady);
                }
            }

            else if (orderDisplay == OrderDisplay.Finished)
            {
                if (employee.Employee_Role == EmployeeRole.bartender)
                {
                    DisplayOrderedDrinkItem(ItemOrderedStatus.Ready);
                }
                else
                {
                    DisplayOrderedFoodItem(ItemOrderedStatus.Ready);
                }
            }
        }

        private void ReadyTable()
        {
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (ListViewItem item in lvOrders.Items)
            {
                if (item.SubItems[0].Text == tbxTableNr.Text)
                {
                    items.Add(item);
                }
            }
            
            if (items.Count > 0)
            {
                items = ReadyCoursetype(items);
            }
            else
            {
                throw new Exception("no table selected");
            }

            foreach (ListViewItem item in items)
            {
                orderedItemService.UpdateItemOrderedStatus((OrderedItem)item.Tag);
            }
            Refresh();
        }

        private void ReadyOrderedItem()
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvOrders.SelectedItems)
                {
                    orderedItemService.UpdateItemOrderedStatus((OrderedItem)item.Tag);
                }
                Refresh();
            }
        }

        private List<ListViewItem> ReadyCoursetype(List<ListViewItem> lvItems)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (ListViewItem item in lvItems)
            {
                if (chbxAppetizer.Checked)
                {
                    if (item.SubItems[3].Text == chbxAppetizer.Text)
                    {
                        items.Add(item);
                    }
                }
                if (chbxMain.Checked)
                {
                    if (item.SubItems[3].Text == chbxMain.Text)
                    {
                        items.Add(item);
                    }
                }
                if (chbxDessert.Checked)
                {
                    if (item.SubItems[3].Text == chbxDessert.Text)
                    {
                        items.Add(item);
                    }
                }
            }

            return items;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbxTableNr.Text.Length == 0) && (lvOrders.SelectedItems.Count == 0) && (!chbxDessert.Checked && !chbxMain.Checked && !chbxAppetizer.Checked))
                    throw new Exception("no item selcted");
                else if ((tbxTableNr.Text.Length == 0) && (lvOrders.SelectedItems.Count == 0))
                    throw new Exception("no table selected");
                else
                {
                    if ((tbxTableNr.Text.Length > 0) && (lvOrders.SelectedItems.Count > 0))
                    {
                        ReadyTable();
                        ReadyOrderedItem();
                    }
                    else if (tbxTableNr.Text.Length > 0)
                        ReadyTable();
                    else
                        ReadyOrderedItem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateKitchenAndBar()
        {
            Refresh();
        }
    }
}
