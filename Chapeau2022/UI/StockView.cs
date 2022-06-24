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
using DAL;
using System.Windows.Forms.Layout;
using System.Windows.Forms.VisualStyles;
using System.Windows.Markup;
using System.Windows;

namespace UI
{
    public enum SortBy {status, price, name, id, quantity, alcohol,menu,course };
    public partial class StockView : Form
    {
        private FoodService _foodService;
        private DrinkService _drinkService;
        public bool IsDisplayingFood;
        public SortType sortType;
        private SortBy sortBy;
        private List<FoodItem> FoodItems;
        private List<DrinkItem> DrinkItems;
        public StockView()
        {
            _foodService = new FoodService();
            _drinkService = new DrinkService();
            FoodItems = new List<FoodItem>();
            DrinkItems = new List<DrinkItem>();
            IsDisplayingFood = false;
            sortBy = new SortBy();
            sortType = SortType.ascending;
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            DrinkStock();
            menuTypeToolStripMenuItem.Enabled = false;
            SortById();
        }
        public void FoodStock()
        {
            IsDisplayingFood = true;

            FoodItems = _foodService.GetAllFoodItems();

            Tools.FillListViewWithFood(listView1, FoodItems);

            if (sortBy == SortBy.status)
                SortByStatus();
            else if (sortBy == SortBy.price)
                SortByPrice();
            else if (sortBy == SortBy.name)
                SortByName();
            else
                SortById();
        }
        public void DrinkStock()
        {
            IsDisplayingFood = false;
            menuStrip5.Hide();

            DrinkItems = _drinkService.GetAllDrinkItems();

            Tools.FillListViewWithDrinks(listView1, DrinkItems);

            if (sortBy == SortBy.status)
                SortByStatus();
            else if (sortBy == SortBy.price)
                SortByPrice();
            else if (sortBy == SortBy.name)
                SortByName();
            else
                SortById();

            button2.BackColor = Color.FromArgb(235, 117, 66);
            button2.ForeColor = Color.White;
            button1.BackColor = Color.Gainsboro;
            button1.ForeColor = Color.FromArgb(43, 45, 66);
            label3.Text = "Drink Inventory";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FoodStock();
            button1.BackColor = Color.FromArgb(235, 117, 66);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Gainsboro;
            button2.ForeColor = Color.FromArgb(43, 45, 66);

            menuTypeToolStripMenuItem.Enabled = true;
            label3.Text = "Food Inventory";

            menuStrip5.Show();
            menuStrip4.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DrinkStock();
            button2.BackColor = Color.FromArgb(235, 117, 66);
            button2.ForeColor = Color.White;
            button1.BackColor = Color.Gainsboro;
            button1.ForeColor = Color.FromArgb(43, 45, 66);

            menuTypeToolStripMenuItem.Enabled = false;
            label3.Text = "Drink Inventory";

            menuStrip4.Show();
            menuStrip5.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                try
                {
                    Form EditItem = new EditFoodItem(_foodService.GetFoodItemById(int.Parse(listView1.SelectedItems[0].Text)), this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
            else
            {
                try
                {
                    Form EditItem = new EditDrinkItem(_drinkService.GetDrinkItemById(int.Parse(listView1.SelectedItems[0].Text)), this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected item.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (IsDisplayingFood)
                    {

                        _foodService.DeleteItem(int.Parse(listView1.SelectedItems[0].Text));
                        FoodStock();
                    }
                    else
                    {
                        _drinkService.DeleteDrink(int.Parse(listView1.SelectedItems[0].Text));
                        DrinkStock();
                    }
                }
            }
            else
                MessageBox.Show("Please select an item first.");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form addItem = new AddItem(this);
            addItem.ShowDialog();
        }
        public void ClearSelectedListViewItems() 
        {
            listView1.SelectedItems.Clear();
        }

        //ALL THE METHODS USED FOR SORTING 
        private void SortByStatus()
        {
            if (sortType == SortType.ascending)
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderBy(i => i.Status()).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderBy(i => i.Status()).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
                label6.Text = "Ascending";
            }
            else 
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderByDescending(i => i.Status()).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderByDescending(i => i.Status()).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
            }
            sortBy = SortBy.status;
            label2.Text = "Sorted By: Status- ";
        }
        private void SortByPrice() 
        {
            if (sortType == SortType.ascending)
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderBy(i => i.Item_Price).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderBy(i => i.Item_Price).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
                label6.Text = "Ascending";
            }
            else
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderByDescending(i => i.Item_Price).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderByDescending(i => i.Item_Price).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
            }
            sortBy = SortBy.price;
            label2.Text = "Sorted By: Price- ";
        }
        private void SortByName() 
        {
            if (sortType == SortType.ascending)
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderBy(i => i.Item_Name).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderBy(i => i.Item_Name).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
                label6.Text = "Ascending";
            }
            else
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderByDescending(i => i.Item_Name).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderByDescending(i => i.Item_Name).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
            }
            sortBy = SortBy.name;
            label2.Text = "Sorted By: Name- ";
        }
        private void SortById() 
        {
            if (sortType == SortType.ascending)
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderBy(i => i.Item_Id).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderBy(i => i.Item_Id).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
                label6.Text = "Ascending";
            }
            else
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderByDescending(i => i.Item_Id).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderByDescending(i => i.Item_Id).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
            }
            sortBy = SortBy.id;
            label2.Text = "Sorted By: Id- ";
        }
        private void SortByQuantity()
        {
            if (sortType == SortType.ascending)
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderBy(i => i.Item_Stock).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderBy(i => i.Item_Stock).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
                label6.Text = "Ascending";
            }
            else
            {
                if (!IsDisplayingFood)
                {
                    DrinkItems = DrinkItems.OrderByDescending(i => i.Item_Stock).ToList();
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
                }
                else
                {
                    FoodItems = FoodItems.OrderByDescending(i => i.Item_Stock).ToList();
                    Tools.FillListViewWithFood(listView1, FoodItems);
                }
            }
            sortBy = SortBy.quantity;
            label2.Text = "Sorted By: Quantity- ";
        }
        private void SortByAlcohol()
        {
            if (sortType == SortType.ascending)
            {

                DrinkItems = DrinkItems.OrderBy(i => i.Item_DrinkType).ToList();
                Tools.FillListViewWithDrinks(listView1, DrinkItems);
                label6.Text = "Ascending";
            }
            else
            {
                DrinkItems = DrinkItems.OrderByDescending(i => i.Item_DrinkType).ToList();
                Tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
                sortBy = SortBy.alcohol;
            label2.Text = "Sorted By: Alcohol- ";
        }
        private void SortByMenuType()
        {
            if (sortType == SortType.ascending)
            {

                FoodItems = FoodItems.OrderBy(i => i.Item_MenuType).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
                label6.Text = "Ascending";
            }
            else
            {
                FoodItems = FoodItems.OrderByDescending(i => i.Item_MenuType).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
            }
            sortBy = SortBy.menu;
            label2.Text = "Sorted By: Menu- ";
        }
        private void SortByCourse()
        {
            if (sortType == SortType.ascending)
            {

                FoodItems = FoodItems.OrderBy(i => i.Item_CourseType).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
                label6.Text = "Ascending";
            }
            else
            {
                FoodItems = FoodItems.OrderByDescending(i => i.Item_CourseType).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
            }
            sortBy = SortBy.course;
            label2.Text = "Sorted By: Course- ";
        }
        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[6].Text == "Restock")
                        item.Selected = true;
            }
            else 
            {
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[5].Text == "Restock")
                        item.Selected = true;
            }
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                items.Add(item);
            }
            TopUpMultiple(items);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void statusToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SortByStatus();
        }
        private void priceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SortByPrice();
        }
        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SortByName();
        }
        private void idToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SortById();
        }
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortToolStripMenuItem.ForeColor = Color.FromArgb(235, 117, 66);
        }
        private void sortToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
        }
        private void sortToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void sortToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
        }

        //CHANGING COLOUR OF BUTTONS CLICKED
        private void sortToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            sortToolStripMenuItem.ForeColor = Color.FromArgb(235, 117, 66);
        }

        private void sortToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            sortToolStripMenuItem.ForeColor = Color.White;
        }

        private void inventoryTypeToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            inventoryTypeToolStripMenuItem.ForeColor = Color.FromArgb(235, 117, 66);
        }

        private void inventoryTypeToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void alterInventoryToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            alterInventoryToolStripMenuItem.ForeColor = Color.FromArgb(235, 117, 66);
        }

        private void alterInventoryToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            alterInventoryToolStripMenuItem.ForeColor = Color.White;
        }

        private void restockInvntoryToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            restockInvntoryToolStripMenuItem.ForeColor = Color.FromArgb(235, 117, 66);
        }

        private void restockInvntoryToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            restockInvntoryToolStripMenuItem.ForeColor = Color.White;
        }

        private void filterToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            filterToolStripMenuItem.ForeColor = Color.FromArgb(235, 117, 66);
        }

        private void filterToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            filterToolStripMenuItem.ForeColor = Color.White;
        }

        private void inventoryTypeToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            inventoryTypeToolStripMenuItem.ForeColor = Color.White;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //HANDLING FILTERING
        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lunchToolStripMenuItem.Checked)
                Tools.FillListViewWithLunchFood(listView1, FoodItems);
            else
                Tools.FillListViewWithFood(listView1, FoodItems);
        }

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dinnerToolStripMenuItem.Checked)
                Tools.FillListViewWithDinnerFood(listView1, FoodItems);
            else
                Tools.FillListViewWithFood(listView1, FoodItems);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                if (textBox1.Text.Length > 0)
                {
                    Tools.FillListViewWithSearchBoxFood(listView1, FoodItems, textBox1.Text);
                }
                else
                    Tools.FillListViewWithFood(listView1, FoodItems);
            }
            else 
            {
                if (textBox1.Text.Length > 0)
                {
                    Tools.FillListViewWithSearchBoxDrink(listView1, DrinkItems, textBox1.Text);
                }
                else
                    Tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
        }
        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            Point mousePosition = listView1.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listView1.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);

            switch (columnindex) 
            {
                case 0:
                    SortById();
                    break;
                case 1:
                    SortByName();
                    break;
                case 2:
                    SortByPrice();
                    break;
                case 5:
                    SortByStatus();
                    break;
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = SortBy.status;

            if(sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrows();
            SortByStatus();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.id;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrows();
            SortById();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.name;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrows();
            SortByName();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.price;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrows();
            SortByPrice();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.quantity;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrows();
            SortByQuantity();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.alcohol;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrows();
            SortByAlcohol();
        }
        private void changeSortTypeArrows() 
        {
            if (sortType == SortType.descending)
            {
                toolStripMenuItem6.Text = "Id ▼";
                toolStripMenuItem9.Text = "Name ▼";
                toolStripMenuItem13.Text = "Price ▼";
                toolStripMenuItem18.Text = "Alcohol ▼";
                toolStripMenuItem23.Text = "Quantity ▼";
                sToolStripMenuItem.Text = "Status ▼";
                label6.Text = "Descending";
            }
            else
            {
                toolStripMenuItem6.Text = "Id ▲";
                toolStripMenuItem9.Text = "Name ▲";
                toolStripMenuItem13.Text = "Price ▲";
                toolStripMenuItem18.Text = "Alcohol ▲";
                toolStripMenuItem23.Text = "Quantity ▲";
                sToolStripMenuItem.Text = "Status ▲";
                label6.Text = "Ascending";
            }
        }
        private void changeSortTypeArrowsFood()
        {
            if (sortType == SortType.descending)
            {
                toolStripMenuItem8.Text = "Id ▼";
                toolStripMenuItem10.Text = "Name ▼";
                toolStripMenuItem11.Text = "Price ▼";
                toolStripMenuItem12.Text = "Menu ▼";
                toolStripMenuItem14.Text = "Course ▼";
                toolStripMenuItem15.Text = "Quantity ▼";
                toolStripMenuItem16.Text = "Status ▼";
            }
            else
            {
                toolStripMenuItem8.Text = "Id ▲";
                toolStripMenuItem10.Text = "Name ▲";
                toolStripMenuItem11.Text = "Price ▲";
                toolStripMenuItem12.Text = "Menu ▲";
                toolStripMenuItem14.Text = "Course ▲";
                toolStripMenuItem15.Text = "Quantity ▲";
                toolStripMenuItem16.Text = "Status ▲";
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sortType = SortType.ascending;

            if (sortBy == SortBy.id)
                SortById();
            else if (sortBy == SortBy.name)
                SortByName();
            else if (sortBy == SortBy.price)
                SortByPrice();
            else if (sortBy == SortBy.alcohol)
                SortByAlcohol();
            else if (sortBy == SortBy.quantity)
                SortByQuantity();
            else 
                SortByStatus();

            if (!IsDisplayingFood)
                changeSortTypeArrows();
            else
                changeSortTypeArrowsFood();

            label6.Text = "Ascending";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            sortType = SortType.descending;
            if (sortBy == SortBy.id)
                SortById();
            else if (sortBy == SortBy.name)
                SortByName();
            else if (sortBy == SortBy.price)
                SortByPrice();
            else if (sortBy == SortBy.alcohol)
                SortByAlcohol();
            else if (sortBy == SortBy.quantity)
                SortByQuantity();
            else
                SortByStatus();

            if (!IsDisplayingFood)
                changeSortTypeArrows();
            else
                changeSortTypeArrowsFood();

            label6.Text = "Descending";
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.id;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortById();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.name;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortByName();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.price;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortByPrice();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.menu;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortByMenuType();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.course;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortByCourse();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.quantity;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortByQuantity();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.sortBy = SortBy.status;

            if (sortType == SortType.ascending)
                sortType = SortType.descending;
            else
                sortType = SortType.ascending;
            changeSortTypeArrowsFood();
            SortByStatus();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TopUp();
        }
        private void TopUp() 
        {
            if (listView1.SelectedItems.Count == 0) 
            {
                MessageBox.Show("Please select items before trying to restock.");
                return;
            }
            if (!(listView1.SelectedItems[0].SubItems[5].Text == "Full"))
            {
                if (IsDisplayingFood)
                {
                    try
                    {
                        FoodItem foodItem = new FoodItem();
                        foodItem = _foodService.GetFoodItemById(int.Parse(listView1.SelectedItems[0].Text));

                        foodItem.Item_Stock = foodItem.Item_AmountNeeded + 10;

                        _foodService.UpdateFoodItem(foodItem);
                        FoodStock();
                    }
                    catch { MessageBox.Show("Please select an item before editing."); }
                }
                else
                {
                    try
                    {
                        DrinkItem drinkItem = new DrinkItem();
                        drinkItem = _drinkService.GetDrinkItemById(int.Parse(listView1.SelectedItems[0].Text));

                        drinkItem.Item_Stock = drinkItem.Item_AmountNeeded + 10;

                        _drinkService.UpdateDrink(drinkItem);
                        DrinkStock();
                    }
                    catch { MessageBox.Show("Please select an item before editing."); }
                }
            }
        }
        private void TopUpMultiple(List<ListViewItem> items)
        {
            if (items == null || items.Count == 0) 
            {
                MessageBox.Show("Please select items before trying to restock.");
                return;
            }

            int i = 0;
            foreach (ListViewItem item in items) 
            {
                if (IsDisplayingFood)
                {

                    FoodItem foodItem = new FoodItem();
                    foodItem = _foodService.GetFoodItemById(int.Parse(items[i].Text));

                    if (foodItem.Status() != "Full")
                    {
                        foodItem.Item_Stock = foodItem.Item_AmountNeeded + 10;

                        _foodService.UpdateFoodItem(foodItem);
                        FoodStock();
                    }
                    i++;
                }
                else if(!IsDisplayingFood)
                {

                        DrinkItem drinkItem = new DrinkItem();
                        drinkItem = _drinkService.GetDrinkItemById(int.Parse(items[i].Text));

                         if (drinkItem.Status() != "Full")
                         {
                         drinkItem.Item_Stock = drinkItem.Item_AmountNeeded + 10;

                            _drinkService.UpdateDrink(drinkItem);
                            DrinkStock();
                         }
                         i++;

                }
            }
        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ListViewItem item in listView1.SelectedItems) 
            {
                items.Add(item);
            }

            TopUpMultiple(items);
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[6].Text == "Low")
                        item.Selected = true;
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[5].Text == "Low")
                        item.Selected = true;
            }
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                items.Add(item);
            }
            TopUpMultiple(items);
        }
        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[6].Text == "Restock" || item.SubItems[6].Text == "Low")
                        item.Selected = true;
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[5].Text == "Restock" || item.SubItems[5].Text == "Low")
                        item.Selected = true;
            }
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                items.Add(item);
            }
            TopUpMultiple(items);
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByStatus();
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByPrice();
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByName();
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortById();
        }

        private void statusToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                try
                {
                    Form EditItem = new EditFoodItem(_foodService.GetFoodItemById(int.Parse(listView1.SelectedItems[0].Text)), this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
            else
            {
                try
                {
                    Form EditItem = new EditDrinkItem(_drinkService.GetDrinkItemById(int.Parse(listView1.SelectedItems[0].Text)), this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addItem = new AddItem(this);
            addItem.ShowDialog();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected item.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (IsDisplayingFood)
                    {

                        _foodService.DeleteItem(int.Parse(listView1.SelectedItems[0].Text));
                        FoodStock();
                    }
                    else
                    {
                        _drinkService.DeleteDrink(int.Parse(listView1.SelectedItems[0].Text));
                        DrinkStock();
                    }
                }
            }
            else
                MessageBox.Show("Please select an item first.");
        }

        private void foodInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodStock();
            button1.BackColor = Color.FromArgb(235, 117, 66);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Gainsboro;
            button2.ForeColor = Color.FromArgb(43, 45, 66);

            menuTypeToolStripMenuItem.Enabled = true;
            label3.Text = "Food Inventory";

            menuStrip5.Show();
            menuStrip4.Hide();
        }

        private void drinkInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrinkStock();
            button2.BackColor = Color.FromArgb(235, 117, 66);
            button2.ForeColor = Color.White;
            button1.BackColor = Color.Gainsboro;
            button1.ForeColor = Color.FromArgb(43, 45, 66);

            menuTypeToolStripMenuItem.Enabled = false;
            label3.Text = "Drink Inventory";

            menuStrip4.Show();
            menuStrip5.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
