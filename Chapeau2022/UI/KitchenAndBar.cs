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
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        OrderedItemService orderedItemService = new OrderedItemService();
        Employee employee;
        OrderDisplay orderDisplay;
        
        public KitchenAndBar(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            if (employee.EmployeeRole == EmployeeRole.bartender)
            {
                lblKitchenAndBar.Text = "Bar";
                DisplayRunningOrderedDrinkItem();
            }
            else
            {
                lblKitchenAndBar.Text = "Kitchen";
                DisplayRunningOrderedFoodItem();
            }

            Timer();
        }

        void Timer()
        {
            t.Interval = 10000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DisplayRunningOrderedDrinkItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllDrinkOrders(ItemOrderedStatus.NotReady);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                if (orderedItem.menuItem is DrinkItem)
                {
                    DrinkItem item = (DrinkItem)orderedItem.menuItem;
                    ListViewItem li = new ListViewItem(orderedItem.table_Id.ToString());
                    li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                    li.SubItems.Add(item.Item_DrinkType.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem._itemOrdered_Comment);
                    li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                    li.SubItems.Add(orderedItem.table_Id.ToString());
                    lvOrders.Items.Add(li);
                }


            }
        }

        private void DisplayFinishedOrderedDrinkItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllDrinkOrders(ItemOrderedStatus.Ready);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                if(orderedItem.menuItem is DrinkItem)
                {
                    DrinkItem item = (DrinkItem)orderedItem.menuItem;
                    ListViewItem li = new ListViewItem(orderedItem.table_Id.ToString());
                    li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                    li.SubItems.Add(item.Item_DrinkType.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem._itemOrdered_Comment);
                    li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                    li.SubItems.Add(orderedItem.table_Id.ToString());
                    lvOrders.Items.Add(li);
                }
                
                
            }
        }

        private void DisplayRunningOrderedFoodItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllFoodOrders(ItemOrderedStatus.NotReady);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                if(orderedItem.menuItem is FoodItem)
                {
                    FoodItem item = (FoodItem)orderedItem.menuItem;
                    ListViewItem li = new ListViewItem(orderedItem.table_Id.ToString());
                    li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                    li.SubItems.Add(item.Item_CourseType.ToString());
                    li.SubItems.Add(item.Item_Name);
                    li.SubItems.Add(orderedItem.);
                    li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                    li.SubItems.Add(orderedItem.TableNr.ToString());
                    li.Tag = orderedItem;
                    lvOrders.Items.Add(li);
                }
                
            }
        }

        private void DisplayFinishedOrderedFoodItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllFoodOrders(ItemOrderedStatus.ready);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.TableNr.ToString());
                li.SubItems.Add(orderTimePlaced(orderedItem.Placed).TotalMinutes.ToString("00 minutes ago"));
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
            orderDisplay = OrderDisplay.Running;

            if (employee.EmployeeRole == EmployeeRole.bartender)
            {
                DisplayRunningOrderedDrinkItem();
            }
            else
            {
                DisplayRunningOrderedFoodItem();
            }
            //DisplayRunningOrderedDrinkItem();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            orderDisplay = OrderDisplay.Finished;

            if (employee.EmployeeRole == EmployeeRole.bartender)
            {
                DisplayFinishedOrderedDrinkItem();
            }
            else
            {
                DisplayFinishedOrderedFoodItem();
            }

            //DisplayFinishedOrderedDrinkItem();
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

        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        void Refresh()
        {
            if (orderDisplay == OrderDisplay.Running)
            {
                if (employee.EmployeeRole == EmployeeRole.bartender)
                {
                    DisplayRunningOrderedDrinkItem();
                }
                else
                {
                    DisplayRunningOrderedFoodItem();
                }
            }

            else if (orderDisplay == OrderDisplay.Finished)
            {
                if (employee.EmployeeRole == EmployeeRole.bartender)
                {
                    DisplayFinishedOrderedDrinkItem();
                }
                else
                {
                    DisplayFinishedOrderedFoodItem();
                }
            }

        }

        //private void btnReady_Click(object sender, EventArgs e)
        //{
        //   foreach (lvOrders.SelectedItems)
        //    {
        //        // ... .Tag
        //    }
        //}
    }
}
