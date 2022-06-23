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
        Order _order;
        List<MenuItem> _CurrentItemsDisplayed;
        CourseType _CurrentcourseType;
        MenuType _CurrentmenuType;

        public OrderForm(int table_Id, int employee_Id)
        {
            InitializeComponent();
            Show();

            //init globals
            _CurrentItemsDisplayed = new List<MenuItem>();
            _order = new Order(employee_Id, table_Id);

            colorListViewHeader(ref lVOrder, Color.FromArgb(141, 153, 174) ,Color.FromArgb(225,233,236));
            colorListViewHeader(ref lVOverview, Color.FromArgb(141, 153, 174), Color.FromArgb(225, 233, 236));
            Start();
            
        }

        void Start()
        {   
            OrderService _orderService = OrderService.GetInstance();
            _order.Order_Id = _orderService.GetNewOrderId();

            rbLunch.Checked = true;
            
            //pnl Overview
            lblOrder_Id.Text = _order.Order_Id.ToString();
            lblTable.Text = _order.table_Id.ToString();
            if (_order.menuItems.Count > 0)
                btnDrinks.PerformClick();
            InitBaseListAttributesOverview();
        }


        //order categories
        private void btnDrinks_Click(object? sender, EventArgs? e)
        {
            //listview columns
            InitBaseListAttributes();
            _CurrentItemsDisplayed.Clear();
            UpdateListViewItems();
            lVOrder.Columns[1].Width = 85;
            lVOrder.Columns.Add("Alcoholic", 70);
            

            gBLunchDinner.Enabled = false;

            //service
            MenuItemService _menuItemService = MenuItemService.GetInstance();
            List<MenuItem> _menuItems = _menuItemService.GetAllMenuItems();
            //order

            
            foreach( MenuItem item in _menuItems)
            {
                if (item is DrinkItem)
                {
                    _CurrentItemsDisplayed.Add(item as DrinkItem);
                    AddDrinkItemToList((DrinkItem)item);
                    
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
                    if(foodItem.Item_MenuType == _CurrentmenuType || foodItem.Item_MenuType == MenuType.LunchAndDinner)
                        if(foodItem.Item_Stock != 0)
                            _CurrentItemsDisplayed.Add(foodItem);
            }
        }

        private void UpdateListViewItems()
        {

            foreach(MenuItem item in _CurrentItemsDisplayed)
            {
                foreach(ListViewItem it in lVOrder.Items)
                {
                    if (it.Index == _CurrentItemsDisplayed.IndexOf(item))
                        return;
                }
                if (item is FoodItem)
                    AddFoodItemToList((FoodItem)item);
                if (item is DrinkItem)
                    AddDrinkItemToList((DrinkItem)item);
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
            string[] tempItem = { Item.Item_Name, $"{Item.Item_Price} /u"};
            ListViewItem lvi = new ListViewItem(tempItem);
            lVOrder.Items.Add(lvi);
        }

        private void AddDrinkItemToList(DrinkItem item)
        {
            string alc = "";
            if (item.Item_DrinkType == DrinkType.Alcoholic)
                alc = "yes";

            string[] tempItem = { item.Item_Name, $"{item.Item_Price} /u", alc };
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
            lVOrder.Columns.Add("Price", 155);
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
                MessageBox.Show("No Item is selected");
            }
            UpdateListViewItems();
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

            lVOverview.Columns.Add("Name", 150);
            lVOverview.Columns.Add("Price");
            lVOverview.Columns.Add("Qty.");
            lVOverview.Columns.Add("Comments", 90);

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
                MessageBox.Show("No Item is selected");
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
            lVOverview.Items.Clear();
            foreach (OrderedItem item in _order.menuItems)
            {
                if(item._itemOrdered_Qty > 0)
                {
                    string[] it = new string[] { item.menuItem.Item_Name, $"{item.menuItem.Item_Price} /u", item._itemOrdered_Qty.ToString(), item._itemOrdered_Comment };
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
                //compare stock with qty 
                foreach(OrderedItem item in _order.menuItems)
                {
                    if(item._itemOrdered_Qty > item.menuItem.Item_Stock)
                    {
                        MessageBox.Show($"The item {item.menuItem.Item_Name} Quantity has exceeded our stock. In stock: {item.menuItem.Item_Stock}");
                        return;
                    }
                }

                //make the order
                OrderService _orderService = OrderService.GetInstance();
                _orderService.SendOrderToDatabase(_order);
                MenuItemService menuItemService = MenuItemService.GetInstance();
                menuItemService.UpdateMenuItemStocks(_order);
                MessageBox.Show($"Order {_order.Order_Id} has been placed");

                this.Close();
                MainWindow mainWindow = new MainWindow();
            }
            else
                MessageBox.Show("The order you are trying to sumbit is empty");


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

        public void Update(Order order) { _order = order; UpdateListViewItems(); UpdateListViewOverview(); }

        private void Logout(object? sender, EventArgs? e)
        {
            if ((MessageBox.Show("are you sure you would like to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                this.Close();
                MainWindow mainWindow = new MainWindow();
            }
        }

        public void Hello()
        {
            MessageBox.Show("Hellpo");
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
