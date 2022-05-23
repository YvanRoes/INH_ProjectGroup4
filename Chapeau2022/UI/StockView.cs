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
        private StockService stockService;
        public StockView()
        {
            stockService = new StockService();
            InitializeComponent();
            Start();
        }
        public void Start() 
        {
            FoodStock();
        }
        public void FoodStock() 
        {
            List<Food> items = stockService.GetAllFoodItems();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 124);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 124);
            listView1.Columns.Add("Item Type", 124);
            listView1.Columns.Add("Item Course", 124);
            listView1.Columns.Add("Qty.", 124);

            foreach (Food item in items)
            {
                string[] tempItem = { item._itemId.ToString(), item._itemName, item._ItemPrice.ToString(),item._ItemType.ToString(),item._ItemCourse.ToString(), item._ItemQty.ToString() };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
        }
        public void DrinkStock()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 124);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 124);
            listView1.Columns.Add("Alcohol", 124);
            listView1.Columns.Add("Qty.", 124);
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
            Form EditItem = new EditFoodItem(stockService.GetFoodItemById(int.Parse(listView1.SelectedItems[0].Text)));
            EditItem.ShowDialog(); 
        }
    }
}
