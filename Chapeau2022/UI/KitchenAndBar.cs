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
        }

        private void DisplayRunningOrderedDrinkItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllDrinkOrders(ItemOrderedStatus.notReady);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.TableNr.ToString());
                li.SubItems.Add(orderTimePlaced(orderedItem.Placed).TotalMinutes.ToString("00 minutes ago"));
                li.SubItems.Add(orderedItem.Item_DrinkType.ToString());
                li.SubItems.Add(orderedItem.Item_Name);
                li.SubItems.Add(orderedItem.ItemOrderedDescription);
                li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                li.SubItems.Add(orderedItem.TableNr.ToString());
                lvOrders.Items.Add(li);
            }
        }

        private void DisplayFinishedOrderedDrinkItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllDrinkOrders(ItemOrderedStatus.ready);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.TableNr.ToString());
                li.SubItems.Add(orderTimePlaced(orderedItem.Placed).TotalMinutes.ToString("00 minutes ago"));
                li.SubItems.Add(orderedItem.Item_DrinkType.ToString());
                li.SubItems.Add(orderedItem.Item_Name);
                li.SubItems.Add(orderedItem.ItemOrderedDescription);
                li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                li.SubItems.Add(orderedItem.TableNr.ToString());
                lvOrders.Items.Add(li);
            }
        }

        private void DisplayRunningOrderedFoodItem()
        {
            lvOrders.Items.Clear();
            List<OrderedItem> orderedItems = orderedItemService.GetAllFoodOrders(ItemOrderedStatus.notReady);

            foreach (OrderedItem orderedItem in orderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItem.TableNr.ToString());
                li.SubItems.Add(orderTimePlaced(orderedItem.Placed).TotalMinutes.ToString("00 minutes ago"));
                li.SubItems.Add(orderedItem.Item_CourseType.ToString());
                li.SubItems.Add(orderedItem.Item_Name);
                li.SubItems.Add(orderedItem.ItemOrderedDescription);
                li.SubItems.Add(orderedItem.ItemOrdered_status.ToString());
                li.SubItems.Add(orderedItem.TableNr.ToString());
                li.Tag = orderedItem;
                lvOrders.Items.Add(li);
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
