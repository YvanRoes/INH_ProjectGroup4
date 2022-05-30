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
    public partial class AddItem : Form
    {
        private bool isFood;
        private DrinkService drinkService;
        private FoodService foodService;
        private StockView stockView;
        public AddItem(StockView stockView)
        {
            isFood = false;
            drinkService = new DrinkService();
            foodService = new FoodService();
            this.stockView = stockView;
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblDrinkName.Show();
                lblFoodName.Hide();

                groupBoxAlcoholContent.Show();
                groupBoxCourse.Hide();
                groupBoxMenu.Hide();

                isFood = false;
            }
            else 
            {
                lblDrinkName.Hide();
                lblFoodName.Show();

                groupBoxAlcoholContent.Hide();
                groupBoxCourse.Show();
                groupBoxMenu.Show();

                isFood = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFood)
            {
                CreateFoodItem();
            }
            else 
            {
                CreateDrinkItem();
                stockView.DrinkStock();
                Close();
            }
        }
        private void CreateFoodItem() 
        {
            int CourseType;
            int MenuType;
            List<FoodItem> list = foodService.GetAllFoodItems();
            int Id = list[list.Count].Item_Id + 1;
            if (radioButton1.Checked)
            {
                CourseType = 0;
            }
            else if (radioButton2.Checked)
            {
                CourseType = 1;
            }
            else
            {
                CourseType = 2;
            }

            if (radioButton4.Checked)
            {
                MenuType = 0;
            }
            else
            {
                MenuType = 1;
            }
            FoodItem item = new FoodItem()
            {
                Item_Id = Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = int.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_CourseType = (CourseType)CourseType,
                Item_MenuType = (MenuType)MenuType
            };
        }
        private void CreateDrinkItem() 
        {
            int drinkType;
            List<DrinkItem> list = drinkService.GetAllDrinkItems();
            int Id = list[list.Count-1].Item_Id+1;

            if (radioButton4.Checked)
            {
                drinkType = 0;
            }
            else
            {
                drinkType = 1;
            }
            DrinkItem drink = new DrinkItem()
            {
                Item_Id = Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_DrinkType = (DrinkType)drinkType
            };
            drinkService.AddDrink(drink);
        }
    }
}
