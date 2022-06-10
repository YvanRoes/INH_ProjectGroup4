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
using UI;

namespace UI
{
    public partial class AddItem : Form
    {
        private bool isFood;
        private DrinkService drinkService;
        private FoodService foodService;
        private StockView stockView;
        private Tools tools;
        public AddItem(StockView stockView)
        {
            isFood = false;
            drinkService = new DrinkService();
            foodService = new FoodService();
            tools = new Tools();
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
                groupBox2.Hide();

                isFood = false;
            }
            else 
            {
                lblDrinkName.Hide();
                lblFoodName.Show();

                groupBoxAlcoholContent.Hide();
                groupBoxCourse.Show();
                groupBox2.Show();

                isFood = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFood)
            {
                CreateFoodItem();
                stockView.FoodStock();
                Close();
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
            int CourseType = tools.IndexOfRadioButton(radioButton9, radioButton8, radioButton7);
            int MenuType = tools.IndexOfRadioButton(radioButton10,radioButton6, radioButton3);
            int Id = foodService.GetLastId()+1;
            
            FoodItem item = new FoodItem()
            {
                Item_Id = Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_CourseType = (CourseType)CourseType,
                Item_MenuType = (MenuType)MenuType,
                Item_AmountNeeded = int.Parse(textBoxAmountNeeded.Text)
            };
            foodService.AddItem(item);
        }
        private void CreateDrinkItem() 
        {
            int drinkType = tools.IndexOfRadioButton(radioButton4, radioButton5);
            int Id = foodService.GetLastId() + 1;

            DrinkItem drink = new DrinkItem()
            {
                Item_Id = Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_DrinkType = (DrinkType)drinkType,
                Item_AmountNeeded = int.Parse(textBoxAmountNeeded.Text)
            };
            drinkService.AddDrink(drink);
        }
    }
}
