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
    public partial class OrderForm : Form, IObservable
    {
        List<IObserver> _observers;
        Order _order;
        List<MenuItem> _CurrentItemsDisplayed;

        public OrderForm(int table_Id, int employeeId)
        {
            InitializeComponent();
            Show();
            Start(employeeId, table_Id);
        }

        void Start(int table, int employee)
        {
            _CurrentItemsDisplayed = new List<MenuItem>();
            
            OrderService _orderService = OrderService.GetInstance();

            _observers = new List<IObserver>();
            _order = new Order(employee, table);
            _order.Order_Id = _orderService.GetNewOrderId();

            rbLunch.Checked = true;
            btnDrinks.PerformClick();
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

        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            //listview columns
            InitBaseListAttributes();

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();

            _CurrentItemsDisplayed.Clear();
            foreach(MenuItem item in _menuItems)
            {
                if (item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_CourseType == CourseType.Appetizer)
                    {
                        _CurrentItemsDisplayed.Add(_foodItem);
                        UpdateListView();
                    }
                        
                }
            }

            
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            InitBaseListAttributes();

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();

            _CurrentItemsDisplayed.Clear();
            foreach( MenuItem item in _menuItems)
            {
                if (item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_CourseType == CourseType.Main)
                    {
                        _CurrentItemsDisplayed.Add(_foodItem);
                        UpdateListView();
                    }
                }
            }
            
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            InitBaseListAttributes();

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();

            _CurrentItemsDisplayed.Clear();
            foreach (MenuItem item in _menuItems)
            {
                if (item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_CourseType == CourseType.Dessert)
                    {
                        _CurrentItemsDisplayed.Add(_foodItem);
                        UpdateListView();
                    }
                }
            }
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
            else if (rbLunchDinner.Checked)
                type = MenuType.Lunch_Dinner;
            else
                type = MenuType.Unknown;
            return type;
        }

        //OverView Form
        private void btnOverview_Click(object sender, EventArgs e)
        {
            OrderOverview frm = new OrderOverview(this, _order);
            frm.Show();
        }

        //observers
        public void NotifyObservers()
        {
            foreach (IObserver obs in _observers)
                obs.Update(_order);
        }

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        //list interaction

        private void lVItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lVItems.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                MenuItem _item = GetItemFromList();
                PopupAddToOrder popup = new PopupAddToOrder(_item, _order, _observers);
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

        private void UpdateListView()
        {
            lVItems.Clear();
            lVItems.Items.Clear();
            InitBaseListAttributes();
            MenuType _CurrentType = GetListViewMenuType();

            foreach (MenuItem item in _CurrentItemsDisplayed)
            {
                if(item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_MenuType == _CurrentType)
                        AddFoodItemToList((FoodItem)item);
                    else
                    {
                        /*if (_CurrentType == MenuType.Lunch_Dinner)
                        {
                            if (_foodItem.Item_MenuType == MenuType.Lunch || _foodItem.Item_MenuType == MenuType.Dinner)
                                AddFoodItemToList(_foodItem);
                        }*/
                        /*else
                            _CurrentItemsDisplayed.Remove(item);*/

                    }
                }
                if(item is DrinkItem)
                    AddDrinkItemToList((DrinkItem)item);
            }
        }

        private void rbLunch_CheckedChanged(object sender, EventArgs e) => UpdateListView();

        private void rbDinner_CheckedChanged(object sender, EventArgs e) => UpdateListView();

        private void rbLunchDinner_CheckedChanged(object sender, EventArgs e) => UpdateListView();
    }
}
