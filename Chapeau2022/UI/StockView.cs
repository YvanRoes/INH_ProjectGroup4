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

namespace UI
{
    public partial class StockView : Form
    {
        private FoodService _foodService;
        private DrinkService _drinkService;
        public bool IsDisplayingFood;
        public StockView()
        {
            _foodService = new FoodService();
            _drinkService = new DrinkService();
            IsDisplayingFood = false;
            InitializeComponent();
            Start();
        }
        public void Start() 
        {
            DrinkStock();
        }
        public void FoodStock() 
        {
            IsDisplayingFood = true;

            List<FoodItem> items = _foodService.GetAllFoodItems();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 124);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 124);
            listView1.Columns.Add("Item Type", 124);
            listView1.Columns.Add("Item Course", 124);
            listView1.Columns.Add("Qty.", 124);

            foreach (FoodItem item in items)
            {
                string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(),item.Item_MenuType.ToString(),item.Item_CourseType.ToString(), item.Item_Stock.ToString() };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
        }
        public void DrinkStock()
        {
            IsDisplayingFood = false;

            List<DrinkItem> items = _drinkService.GetAllDrinkItems();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 124);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 124);
            listView1.Columns.Add("Alcohol", 124);
            listView1.Columns.Add("Qty.", 124);

            foreach (DrinkItem item in items)
            {
                string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(),item.Item_DrinkType.ToString(), item.Item_Stock.ToString() };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
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
                    Form EditItem = new EditFoodItem(_foodService.GetFoodItemById(int.Parse(listView1.SelectedItems[0].Text)));
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
            else 
            {
                try
                {
                    Form EditItem = new EditDrinkItem(_drinkService.GetDrinkItemById(int.Parse(listView1.SelectedItems[0].Text)),this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
        }
    }
}
