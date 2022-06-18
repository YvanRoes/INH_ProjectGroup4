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
        private List<OrderedItem> orders;
        int tableNumber = 1;
        string tableStatus;
        public TableView()
        {
            InitializeComponent();
            Show();
            Waiter();
        }
        
        private void Waiter()
        {
            orders = orderedItemService.GetAllOrders(tableNumber);
            DisplayOrderedItems();
        }

        private void DisplayOrderedItems()
        {
            lvOrders.Items.Clear();
            foreach (OrderedItem orderedItem in orders)
            {
                ListViewItem li = new ListViewItem(orderedItem._itemOrder_id.ToString());
                li.SubItems.Add(orderedItem.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderedItem._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderTimePlaced(orderedItem._itemOrdered_Placed).TotalMinutes.ToString("00 minutes ago"));
                li.SubItems.Add(orderedItem._itemOrdered_Status.ToString());
                li.Tag = orderedItem;
                lvOrders.Items.Add(li);
            }
        }

        TimeSpan orderTimePlaced(DateTime placed)
        {
            TimeSpan orderTime = DateTime.Now - placed;
            return orderTime;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Waiter();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            new BillUI();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(2, 1);
            this.Hide();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
        }
        private void btnServeOrder_Click(object sender, EventArgs e)
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
        private void ServeOrderedItem()
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvOrders.SelectedItems)
                {
                    orderedItemService.MarkOrderedItemAsServed((OrderedItem)item.Tag);
                }
            }
        }

        //checks if the table currently has any running or ready to be served orders
        private void CheckTableStatus(int table, out string tableStatus)
        {
            if (lvOrders.Items.Count == 0)
            {
                tableStatus = "Free";
            }
            else if (lvOrders.Items[0].SubItems[4].Text == "NotReady") //checks if the order is not ready
            {
                tableStatus = "Running";
            }
            else if (lvOrders.Items[0].SubItems[4].Text == "Ready") //checks if the order is ready
            {
                tableStatus = "Ready to serve";
            }
            
            else
            {
                tableStatus = "Occupied";
            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            tableNumber = 1;
            txtTableNumber.Text = "Table 1";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable1.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            tableNumber = 2;
            txtTableNumber.Text = "Table 2";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable2.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            tableNumber = 3;
            txtTableNumber.Text = "Table 3";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable3.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            tableNumber = 4;
            txtTableNumber.Text = "Table 4";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable4.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            tableNumber = 5;
            txtTableNumber.Text = "Table 5";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable5.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            tableNumber = 6;
            txtTableNumber.Text = "Table 6";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable6.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            tableNumber = 7;
            txtTableNumber.Text = "Table 7";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable7.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            tableNumber = 8;
            txtTableNumber.Text = "Table 8";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable8.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            tableNumber = 9;
            txtTableNumber.Text = "Table 9";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable9.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            tableNumber = 10;
            txtTableNumber.Text = "Table 10";
            Waiter();
            CheckTableStatus(tableNumber, out tableStatus);
            txtTable10.Text = $"{tableStatus}";
            ChangeButtonColor(sender, e);
        }

        //clicking the table buttons will change its color
        private void ChangeButtonColor(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //CheckTableStatus(tableNumber, b, out tableStatus);
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
            

        }

        private void TableView_Load(object sender, EventArgs e)
        {
            btnTable2_Click(btnTable2, e);
            btnTable3_Click(btnTable3, e);
            btnTable4_Click(btnTable4, e);
            btnTable5_Click(btnTable5, e);
            btnTable6_Click(btnTable6, e);
            btnTable7_Click(btnTable7, e);
            btnTable8_Click(btnTable8, e);
            btnTable9_Click(btnTable9, e);
            btnTable10_Click(btnTable10, e);
            btnTable1_Click(btnTable1, e);
        }
    }
}
