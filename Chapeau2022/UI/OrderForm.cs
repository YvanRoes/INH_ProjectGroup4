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

namespace ChapeauTest
{
    public partial class OrderForm : Form, IObservable
    {
        List<IObserver> _observers;
        Order _order;

        public OrderForm(int table_Id, int employeeId)
        {
            InitializeComponent();
            Start(employeeId, table_Id);
        }

        void Start(int table, int employee)
        {
            MenuItemService _menuItemService  = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();
            _menuItems = _menuItems.OrderBy(i => i.Item_Name).ToList();

            OrderService _orderService = OrderService.GetInstance();

            _observers = new List<IObserver>();
            _order = new Order(employee, table);
            _order.Order_Id = _orderService.GetNewOrderId();

            //initialize listview
            InitBaseListAttributes();

            foreach(MenuItem item in _menuItems)
            {
                string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_Stock.ToString() };
                ListViewItem lvi = new ListViewItem(tempItem);
                lVItems.Items.Add(lvi);
            }
        }

        //on button click return only drinks + drink attributes
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //listview columns
            InitBaseListAttributes();
            lVItems.Columns.Add("Alcohol");

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();

            foreach( MenuItem item in _menuItems)
            {
                if (item is DrinkItem)
                {
                    DrinkItem tempDrink = (DrinkItem)item;
                    string alc = "";
                    if (tempDrink.Item_DrinkType == DrinkType.Alcoholic)
                        alc = "yes";
                    
                    string[] tempItem = { tempDrink.Item_Id.ToString(), tempDrink.Item_Name, tempDrink.Item_Price.ToString(), alc };
                    ListViewItem lvi = new ListViewItem(tempItem);
                    lVItems.Items.Add(lvi);
                }
            }
        }

        private void btnAppetizers_Click(object sender, EventArgs e)
        {
            //listview columns
            InitBaseListAttributes();
            lVItems.Columns.Add("MenuType", 70);

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();

            foreach(MenuItem item in _menuItems)
            {
                if (item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_CourseType == CourseType.Appetizer)
                    {
                        AddFoodItemToListView(_foodItem);
                    }
                }
            }

            
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            InitBaseListAttributes();
            lVItems.Columns.Add("MenuType", 70);

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();


            foreach( MenuItem item in _menuItems)
            {
                if (item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_CourseType == CourseType.Main)
                    {
                        AddFoodItemToListView(_foodItem);
                    }
                }
            }
            
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            InitBaseListAttributes();
            lVItems.Columns.Add("MenuType", 70);

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();


            foreach (MenuItem item in _menuItems)
            {
                if (item is FoodItem)
                {
                    FoodItem _foodItem = (FoodItem)item;
                    if (_foodItem.Item_CourseType == CourseType.Dessert)
                    {
                        AddFoodItemToListView(_foodItem);
                    }
                }
            }
        }

        private void AddFoodItemToListView(FoodItem _foodItem)
        {
            string[] tempItem = { _foodItem.Item_Id.ToString(), _foodItem.Item_Name, _foodItem.Item_Price.ToString(), _foodItem.Item_MenuType.ToString() };
            ListViewItem lvi = new ListViewItem(tempItem);
            lVItems.Items.Add(lvi);
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
        private void lVItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private MenuItem GetItemFromList()
        {
            int? id = int.Parse(lVItems.FocusedItem.SubItems[0].Text);
            MenuItemService _service = MenuItemService.GetInstance();
            return (MenuItem)_service.GetAllMenuItems().Find(i => i.Item_Id == id);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            MenuItem _item = GetItemFromList();
            PopupAddToOrder popup = new PopupAddToOrder(_item, _order, _observers);
            popup.ShowDialog();
        }

        void InitBaseListAttributes()
        {
            lVItems.Items.Clear();
            lVItems.Columns.Clear();
            lVItems.View = View.Details;
            lVItems.FullRowSelect = true;

            lVItems.Columns.Add("ID");
            lVItems.Columns.Add("Name", 124);
            lVItems.Columns.Add("Price");
        }
    }
}
