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
            radioButton9.Checked = true;
            radioButton10.Checked = true;
            radioButton4.Checked = true;
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
            }
            else 
            {
                CreateDrinkItem();
            }
        }
        private void CreateFoodItem() 
        {
            if (CheckForInputErrors())
                return;

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
            stockView.FoodStock();
            Close();
        }
        private void CreateDrinkItem() 
        {
            if (CheckForInputErrors())
                return;

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
            stockView.DrinkStock();
            Close();
        }
        private bool CheckForInputErrors() 
        {
            //checking if the name is empty of has special characters
            if (string.IsNullOrWhiteSpace(textBoxItemName.Text) || string.IsNullOrEmpty(textBoxItemName.Text))
            {
                MessageBox.Show("Item name cannot be empty.");
                return true;
            }
            if (tools.hasSpecialChar(textBoxItemName.Text))
            {
                MessageBox.Show("Name cannot contain special characters.");
                return true;
            }
            if (CheckForSpecialCharacters())
                return true;

            if (CheckForLetters())
                return true;

            if (CheckForSpaceOrEmpty())
                return true;

            return false;
        }
        private bool CheckForSpecialCharacters() 
        {
            //checking if the price, amount and quantity fields have special characters
            if (tools.hasSpecialChar(textBoxPrice.Text))
            {
                MessageBox.Show("Price cannot contain special characters.");
                return true;
            }
            if (tools.hasSpecialChar(textBoxQuantity.Text))
            {
                MessageBox.Show("Quantity cannot contain special characters.");
                return true;
            }
            if (tools.hasSpecialChar(textBoxAmountNeeded.Text))
            {
                MessageBox.Show("The amount needed field cannot contain special characters.");
                return true;
            }
            return false;
        }
        private bool CheckForLetters() 
        {
            //checking if the price, amount or quantity contain letters
            if (textBoxPrice.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Price cannot contain letters.");
                return true;
            }
            if (textBoxQuantity.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Quantity cannot contain letters.");
                return true;
            }
            if (textBoxAmountNeeded.Text.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Amount needed cannot contain letters.");
                return true;
            }
            return false;
        }
        private bool CheckForSpaceOrEmpty() 
        {
            //checking if the price, amount or quantity are null or empty strings/ containing spaces only and automatically assigning a value of 0 if the user fails to provide information
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
                textBoxPrice.Text = "0";

            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text) || string.IsNullOrEmpty(textBoxQuantity.Text))
                textBoxQuantity.Text = "0";

            if (string.IsNullOrWhiteSpace(textBoxAmountNeeded.Text) || string.IsNullOrEmpty(textBoxAmountNeeded.Text))
                textBoxAmountNeeded.Text = "0";
            return false;
        }
        //the code below ensures proper functioning of the +/- buttons in case of inappropreate input
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text))
                textBoxQuantity.Text = "0";

            textBoxQuantity.Text = (int.Parse(textBoxQuantity.Text) + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAmountNeeded.Text))
                textBoxAmountNeeded.Text = "0";

            textBoxAmountNeeded.Text = (int.Parse(textBoxAmountNeeded.Text) + 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text != "0")
                try
                {
                    textBoxQuantity.Text = (int.Parse(textBoxQuantity.Text) - 1).ToString();
                }
                catch
                {
                    textBoxQuantity.Text = "0";
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBoxAmountNeeded.Text != "0")
                try
                {
                    textBoxAmountNeeded.Text = (int.Parse(textBoxAmountNeeded.Text) - 1).ToString();
                }
                catch
                {
                    textBoxAmountNeeded.Text = "0";
                }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
