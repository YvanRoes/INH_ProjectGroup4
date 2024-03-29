﻿using Logic;
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
    public partial class KitchenAndBar : Form
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
            colorListViewHeader(ref lvOrders, Color.FromArgb(141, 153, 174), Color.FromArgb(225, 233, 236));

            Timer();
        }

        private void BarView()
        {
            lblKitchenAndBar.Text = "Bar View";
            lvOrders.Columns[3].Text = "Drink Type";
            lvOrders.Columns[4].Text = "Drink Name";
            lblReadyCourse.Hide();
            chbxAppetizer.Hide();
            chbxMain.Hide();
            chbxDessert.Hide();
            btnReady.Left -= 350;

            //start display
            DisplayOrderedDrinkItem(ItemOrderedStatus.Running);
            orderDisplay = OrderDisplay.Running;
        }

        private void KitchenView()
        {
            lblKitchenAndBar.Text = "Kitchen View";
            lvOrders.Columns[3].Text = "Course Type";
            lvOrders.Columns[4].Text = "Food Name";

            //start display
            DisplayOrderedFoodItem(ItemOrderedStatus.Running);
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
                DisplayOrderedDrinkItem(ItemOrderedStatus.Running);
            }
            else
            {
                DisplayOrderedFoodItem(ItemOrderedStatus.Running);
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            orderDisplay = OrderDisplay.Finished;

            if (employee.Employee_Role == EmployeeRole.bartender)
            {
                DisplayOrderedDrinkItem(ItemOrderedStatus.Finished);
            }
            else
            {
                DisplayOrderedFoodItem(ItemOrderedStatus.Finished);
            }
        }

        TimeSpan orderTimePlaced(DateTime placed)
        {
            TimeSpan orderTime = DateTime.Now - placed;
            return orderTime;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("are you sure you would like to logout?", "Logout?",
MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow();
            }
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
                    DisplayOrderedDrinkItem(ItemOrderedStatus.Running);
                }
                else
                {
                    DisplayOrderedFoodItem(ItemOrderedStatus.Running);
                }
            }

            else if (orderDisplay == OrderDisplay.Finished)
            {
                if (employee.Employee_Role == EmployeeRole.bartender)
                {
                    DisplayOrderedDrinkItem(ItemOrderedStatus.Finished);
                }
                else
                {
                    DisplayOrderedFoodItem(ItemOrderedStatus.Finished);
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
                throw new Exception("please select a table");
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
                //so the list is not null
                if (chbxMain.Checked == false && chbxDessert.Checked == false && chbxAppetizer.Checked == false)
                {
                    items.Add(item);
                }
            }

            return items;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbxTableNr.Text.Length == 0) && (lvOrders.SelectedItems.Count == 0) && (!chbxDessert.Checked && !chbxMain.Checked && !chbxAppetizer.Checked))
                    throw new Exception("please select a item");
                else if ((tbxTableNr.Text.Length == 0) && (lvOrders.SelectedItems.Count == 0))
                    throw new Exception("please select a table");
                else
                {
                    //having both table nr entered and item selected
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

        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
