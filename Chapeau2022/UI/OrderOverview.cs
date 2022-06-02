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
using Logic;

namespace UI
{
    public partial class OrderOverview : Form, IObserver
    {
        IObservable _observable;
        Order _order;

        public OrderOverview(IObservable observable, Order order)
        {
            InitializeComponent();
            _observable = observable;
            _observable.AddObserver((IObserver)this);
            _order = order;
            lblOrder_Id.Text = _order.Order_Id.ToString();

            if (order.menuItems.Count > 0)
                UpdateListView();
        }

        public void Update(Order order)
        {
            _order = order;
            UpdateListView();
            
        }

        void InitBaseListAttributes()
        {
            lvOrder.Items.Clear();
            lvOrder.Columns.Clear();
            lvOrder.View = View.Details;
            lvOrder.FullRowSelect = true;

            lvOrder.Columns.Add("ID");
            lvOrder.Columns.Add("Name", 100);
            lvOrder.Columns.Add("Price");
            lvOrder.Columns.Add("Qty.");
            lvOrder.Columns.Add("Comments", 100);
            
        }

        void UpdateListView()
        {
            InitBaseListAttributes();
            foreach(OrderedItem item in _order.menuItems)
            {
                string[] it = new string[] { item.menuItem.Item_Id.ToString(), item.menuItem.Item_Name, item.menuItem.Item_Price.ToString(), item._itemOrdered_Qty.ToString(), item._itemOrdered_Comment };
                ListViewItem listViewItem = new ListViewItem(it);
                lvOrder.Items.Add(listViewItem);

            }
        }

        void RemoveEmptyItems()
        {
            foreach(OrderedItem item in _order.menuItems)
                if(item._itemOrdered_Qty <= 0)
                    _order.RemoveItem(item);
        }

        private void btnClear_Click(object sender, EventArgs e) { _order.menuItems.Clear(); UpdateListView(); }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (_order.menuItems.Count > 0)
            {
                OrderService _orderService = OrderService.GetInstance();
                _orderService.SendOrderToDatabase(_order);
            }
            else
                MessageBox.Show("The order you are trying to sumbit is empty");


        }
    }
}
