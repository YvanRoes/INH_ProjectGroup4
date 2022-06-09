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
using Model;

namespace UI
{
    public partial class OrderForm : Form, IOrderObserver, INotifierObservable
    {
        List<INotifierObserver> _observers;

        Order _order;
        List<MenuItem> _CurrentItemsDisplayed;
        CourseType _CurrentcourseType;
        MenuType _CurrentmenuType;

        public OrderForm(int table_Id, int employeeId)
        {
            InitializeComponent();
            Show();
            this.Size = new Size(375, 500);

            //init globals
            _CurrentItemsDisplayed = new List<MenuItem>();
            _observers = new List<INotifierObserver>();
            _order = new Order(table_Id, employeeId);

            Start();
            
        }

        void Start()
        {   
            OrderService _orderService = OrderService.GetInstance();
            _order.Order_Id = _orderService.GetNewOrderId();

            rbLunch.Checked = true;
            btnDrinks.PerformClick();

            //pnl Overview
            lblOrder_Id.Text = _order.Order_Id.ToString();
            if (_order.menuItems.Count > 0)
                btnDrinks_Click(null, null);
        }


        //order categories
        private void btnDrinks_Click(object? sender, EventArgs? e)
        {
            //listview columns
            InitBaseListAttributes();
            lVOrder.Columns.Add("Alcoholic", 70);
            gBLunchDinner.Enabled = false;


            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();
            //order

            _CurrentItemsDisplayed.Clear();
            foreach( MenuItem item in _menuItems)
            {
                if (item is DrinkItem)
                {
                    DrinkItem _drinkItem = (DrinkItem)item;
                    _CurrentItemsDisplayed.Add(_drinkItem);
                    string alc = "";
                    if (_drinkItem.Item_DrinkType == DrinkType.Alcoholic)
                        alc = "yes";
                    
                    string[] tempItem = {_drinkItem.Item_Name, _drinkItem.Item_Price.ToString(), alc };
                    ListViewItem lvi = new ListViewItem(tempItem);
                    lVOrder.Items.Add(lvi);
                }
            }
        }

        private void btnAppetizers_Click(object? sender, EventArgs? e) => DisplayCourseInList(CourseType.Appetizer);

        private void btnMain_Click(object? sender, EventArgs? e) => DisplayCourseInList(CourseType.Main);

        private void btnDessert_Click(object? sender, EventArgs? e) => DisplayCourseInList(CourseType.Dessert);


        //display functions
        private void AddFoodItemToCurrentItems(MenuItem item, CourseType type)
        {
            if (item is FoodItem)
            {
                FoodItem foodItem = (FoodItem)item;
                if (foodItem.Item_CourseType == type)
                    if(foodItem.Item_MenuType == _CurrentmenuType)
                        if(foodItem.Item_Stock != 0)
                            _CurrentItemsDisplayed.Add(foodItem);
            }
        }

        private void UpdateListViewItems()
        {
            foreach(MenuItem item in _CurrentItemsDisplayed)
            {
                if (item is FoodItem)
                    AddFoodItemToList((FoodItem)item);
            }
        }

        private void DisplayCourseInList(CourseType courseType)
        {
            MenuItemService menuItemService = MenuItemService.GetInstance();
            List<MenuItem> menuItems = menuItemService.GetAllMenuItems();
            InitBaseListAttributes();
            _CurrentItemsDisplayed.Clear();
            _CurrentcourseType = courseType;
            gBLunchDinner.Enabled = true;

            foreach (MenuItem item in menuItems)
                AddFoodItemToCurrentItems(item, _CurrentcourseType);
            UpdateListViewItems();
        }

        private void AddFoodItemToList(FoodItem Item)
        {
            string[] tempItem = { Item.Item_Name, Item.Item_Price.ToString() };
            ListViewItem lvi = new ListViewItem(tempItem);
            lVOrder.Items.Add(lvi);
        }


        //list interaction OrderPanel
        private void InitBaseListAttributes()
        {
            lVOrder.Items.Clear();
            lVOrder.Columns.Clear();
            lVOrder.View = View.Details;
            lVOrder.FullRowSelect = true;

            /*lVItems.Columns.Add("ID");*/
            lVOrder.Columns.Add("Name", 160);
            lVOrder.Columns.Add("Price");
        }

        private void lVOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lVOrder.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                MenuItem _item = GetItemFromOrderList();
                PopupAddToOrder popup = new PopupAddToOrder(_item, _order, this);
                popup.ShowDialog();
            }
            else
            {
                this.lVOrder.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
        }

        private MenuItem GetItemFromOrderList()
         {
            int id = lVOrder.FocusedItem.Index;
            MenuItemService _service = MenuItemService.GetInstance();
            if (_CurrentItemsDisplayed[id] != null)
                return _CurrentItemsDisplayed[id];
            else
                throw new Exception("Item selected could not be found");

        }

        private void UpdateCourseList()
        {
            _CurrentItemsDisplayed.Clear();
            switch (_CurrentcourseType)
            {
                case CourseType.Appetizer:
                    btnAppetizers_Click(null, null);
                    break;
                case CourseType.Main:
                    btnMain_Click(null, null);
                    break;
                case CourseType.Dessert:
                    btnDessert_Click(null, null);
                    break;
            }

        }


        //list interaction OverviewPanel
        void InitBaseListAttributesOverview()
        {
            lVOverview.Items.Clear();
            lVOverview.Columns.Clear();
            lVOverview.View = View.Details;
            lVOverview.FullRowSelect = true;

            lVOverview.Columns.Add("ID");
            lVOverview.Columns.Add("Name", 100);
            lVOverview.Columns.Add("Price");
            lVOverview.Columns.Add("Qty.");
            lVOverview.Columns.Add("Comments", 100);

        }

        private void lvOverview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lVOverview.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                OrderedItem _item = GetItemFromOverviewList();
                PopupEditOrderedItem popup = new PopupEditOrderedItem(_item, _order, this);
                popup.ShowDialog();
            }
            else
            {
                this.lVOrder.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
        }

        private OrderedItem GetItemFromOverviewList()
        {
            int id = lVOverview.FocusedItem.Index;
            MenuItemService _service = MenuItemService.GetInstance();

            if (_order.menuItems[id] != null)
                return _order.menuItems[id];
            else
                throw new Exception("Item selected could not be found");
        }

        void UpdateListViewOverview()
        {
            InitBaseListAttributes();
            foreach (OrderedItem item in _order.menuItems)
            {
                if(item._itemOrdered_Qty > 0)
                {
                    string[] it = new string[] { item.menuItem.Item_Id.ToString(), item.menuItem.Item_Name, item.menuItem.Item_Price.ToString(), item._itemOrdered_Qty.ToString(), item._itemOrdered_Comment };
                    ListViewItem listViewItem = new ListViewItem(it);
                    lVOverview.Items.Add(listViewItem);
                }
            }
        }


        //Call to action
        private void btnClear_Click(object sender, EventArgs e) { _order.menuItems.Clear(); UpdateListViewOverview(); }

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
                this.Close();
            }
            else
                MessageBox.Show("The order you are trying to sumbit is empty");


        }

        private void makeTheOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(375, 500);
            pnlOrder.Show();
            pnlOverview.Hide();
            pnlOrder.Dock = DockStyle.Fill;
        }

        private void orderOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(425, 650);
            pnlOverview.Show();
            pnlOrder.Hide();
            pnlOverview.Dock = DockStyle.Fill;
            InitBaseListAttributesOverview();
            UpdateListViewOverview();
        }

        private void rbLunch_CheckedChanged(object sender, EventArgs e)
        {
            _CurrentmenuType = MenuType.Lunch;
            UpdateCourseList();
        }

        private void rbDinner_CheckedChanged(object sender, EventArgs e)
        {
            _CurrentmenuType = MenuType.Dinner;
            UpdateCourseList();
        }

        public void Update(Order order) => UpdateListViewOverview();


        //observers
        public void NotifyObservers()
        {
            foreach (INotifierObserver obs in _observers)
                obs.UpdateKitchenAndBar();
        }

        public void AddObserver(INotifierObserver observer) => _observers.Add(observer);

        public void RemoveObserver(INotifierObserver observer) => _observers.Remove(observer);

    }
}
