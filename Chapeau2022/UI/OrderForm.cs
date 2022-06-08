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
    public partial class OrderForm : Form, IOrderObserver
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
            Start(employeeId, table_Id);
            this.Size = new Size(375, 500);
        }

        void Start(int table, int employee)
        {
            _CurrentItemsDisplayed = new List<MenuItem>();
            _observers = new List<INotifierObserver>();
            
            OrderService _orderService = OrderService.GetInstance();
            _order = new Order(employee, table);
            _order.Order_Id = _orderService.GetNewOrderId();

            rbLunch.Checked = true;
            btnDrinks.PerformClick();

            //pnl Overview
            lblOrder_Id.Text = _order.Order_Id.ToString();
            if (_order.menuItems.Count > 0)
                btnDrinks_Click(null, null);
        }

        //on button click return only drinks + drink attributes
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //listview columns
            InitBaseListAttributes();

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
                    lVItems.Items.Add(lvi);
                }
            }
        }

        private void btnAppetizers_Click(object sender, EventArgs e) => DisplayCourseInList(CourseType.Appetizer);

        private void btnMain_Click(object sender, EventArgs e) => DisplayCourseInList(CourseType.Main);

        private void btnDessert_Click(object sender, EventArgs e) => DisplayCourseInList(CourseType.Dessert);

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

            foreach (MenuItem item in menuItems)
                AddFoodItemToCurrentItems(item, _CurrentcourseType);
            UpdateListViewItems();
        }
        private void AddFoodItemToList(FoodItem Item)
        {
            string[] tempItem = { Item.Item_Name, Item.Item_Price.ToString() };
            ListViewItem lvi = new ListViewItem(tempItem);
            lVItems.Items.Add(lvi);
        }

        private void AddDrinkItemToList(DrinkItem Item)
        {
            string alc = "";
            if (Item.Item_DrinkType == DrinkType.Alcoholic)
                alc = "yes";

            string[] tempItem = { Item.Item_Name, Item.Item_Price.ToString(), alc };
            ListViewItem lvi = new ListViewItem(tempItem);
            lVItems.Items.Add(lvi);
        }

        private MenuType GetListViewMenuType()
        {
            MenuType type;
            if (rbLunch.Checked)
                type = MenuType.Lunch;
            else if (rbDinner.Checked)
                type = MenuType.Dinner;
            else
                type = MenuType.Unknown;
            return type;
        }


        //observers
        public void NotifyObservers()
        {
            foreach (IOrderObserver obs in _observers)
                obs.Update(_order);
        }

        public void AddObserver(INotifierObserver observer) => _observers.Add(observer);

        public void RemoveObserver(INotifierObserver observer) => _observers.Remove(observer);

        //list interaction

        private void lVItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lVItems.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                MenuItem _item = GetItemFromList();
                PopupAddToOrder popup = new PopupAddToOrder(_item, _order, this);
                popup.ShowDialog();
            }
            else
            {
                this.lVItems.SelectedItems.Clear();
                MessageBox.Show("No Item is selected");
            }
        }

        private MenuItem GetItemFromList()
         {
            int id = lVItems.FocusedItem.Index;
            MenuItemService _service = MenuItemService.GetInstance();
            if (_CurrentItemsDisplayed[id] != null)
                return _CurrentItemsDisplayed[id];
            else
                throw new Exception("Item selected could not be found");

        }

        private void InitBaseListAttributes()
        {
            lVItems.Items.Clear();
            lVItems.Columns.Clear();
            lVItems.View = View.Details;
            lVItems.FullRowSelect = true;

            /*lVItems.Columns.Add("ID");*/
            lVItems.Columns.Add("Name", 160);
            lVItems.Columns.Add("Price");
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


        void InitBaseListAttributesOverview()
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

        void UpdateListViewOverview()
        {
            InitBaseListAttributes();
            foreach (OrderedItem item in _order.menuItems)
            {
                string[] it = new string[] { item.menuItem.Item_Id.ToString(), item.menuItem.Item_Name, item.menuItem.Item_Price.ToString(), item._itemOrdered_Qty.ToString(), item._itemOrdered_Comment };
                ListViewItem listViewItem = new ListViewItem(it);
                lvOrder.Items.Add(listViewItem);

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

        public void Update(Order order)
        {
            UpdateListViewOverview();
        }
    }
}
