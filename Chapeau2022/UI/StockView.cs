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
    public partial class StockView : Form
    {
        private FoodService _foodService;
        private DrinkService _drinkService;
        public bool IsDisplayingFood;
        private Tools tools;
        private List<FoodItem> FoodItems;
        private List<DrinkItem> DrinkItems;
        public StockView()
        {
            _foodService = new FoodService();
            _drinkService = new DrinkService();
            FoodItems = new List<FoodItem>();
            DrinkItems = new List<DrinkItem>();
            tools = new Tools();
            IsDisplayingFood = false;
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            //listView1.Sorting = SortOrder.Ascending;

            DrinkStock();
            button4.Visible = true;
            button5.Visible = true;
        }
        public void FoodStock()
        {
            IsDisplayingFood = true;

            FoodItems = _foodService.GetAllFoodItems();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 124);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 124);
            listView1.Columns.Add("Item Type", 124);
            listView1.Columns.Add("Item Course", 124);
            listView1.Columns.Add("Qty.", 124);

            foreach (FoodItem item in FoodItems)
            {
                string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
        }
        public void DrinkStock()
        {
            IsDisplayingFood = false;

            DrinkItems = _drinkService.GetAllDrinkItems();

            tools.FillListViewWithDrinks(listView1, DrinkItems);

            if (radioButton1.Checked)
                SortByStatus();
            else if (radioButton2.Checked)
                SortByPrice();
            else if (radioButton3.Checked)
                SortByName();
            else 
                SortById();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FoodStock();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DrinkStock();
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
            if (IsDisplayingFood)
            {
                try
                {
                    _foodService.DeleteItem(int.Parse(listView1.SelectedItems[0].Text));
                    FoodStock();

                }
                catch { MessageBox.Show("Please select the item you would like to delete."); }
            }
            else
            {
                _drinkService.DeleteDrink(int.Parse(listView1.SelectedItems[0].Text));

                DrinkStock();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form addItem = new AddItem(this);
            addItem.ShowDialog();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SortByStatus();
        }
        private void SortByStatus()
        {
            if (radioButton1.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Status()).ToList();
                tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SortByPrice();
        }
        private void SortByPrice() 
        {
            if (radioButton2.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Price).ToList();
                tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SortByName();
        }
        private void SortByName() 
        {
            if (radioButton3.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Name).ToList();
                tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Id).ToList();
                tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
        }
        private void SortById() 
        {
            if (radioButton4.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Id).ToList();
                tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
        }
    }
}
