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
    public partial class OrderOverview : Form, IOrderObserver, INotifierObservable
    {
        IOrderObservable _observable;
        Order _order;

        //observers to update kitchen and stock accordingly
        List<INotifierObserver> _observers = new List<INotifierObserver>();

        public OrderOverview(IOrderObservable observable, Order order)
        {
            InitializeComponent();
            _observable = observable;
            _observable.AddObserver((IOrderObserver)this);
            _order = order;
            lblOrder_Id.Text = _order.Order_Id.ToString();

            if (order.menuItems.Count > 0)
                UpdateListView();
        }

        //Listview
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

        //Call to action
        private void btnClear_Click(object sender, EventArgs e) { _order.menuItems.Clear(); UpdateListView(); }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (_order.menuItems.Count > 0)
            {
                OrderService _orderService = OrderService.GetInstance();
                _orderService.SendOrderToDatabase(_order);
                MessageBox.Show($"Order {_order.Order_Id} has been placed");
                //Notify kitchen and stock accordingly
                NotifyObservers();

                //close order form
                OrderForm obj = (OrderForm)Application.OpenForms["OrderForm"];
                obj.Close();
            }
            else
                MessageBox.Show("The order you are trying to sumbit is empty");


        }

        //IOrderObserver
        public void Update(Order order)
        {
            _order = order;
            UpdateListView();

        }

        //INotifierObservable
        public void AddObserver(INotifierObserver observer) => _observers.Add(observer);

        public void RemoveObserver(INotifierObserver observer) => _observers.Remove(observer);

        void NotifyObservers()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }
}
