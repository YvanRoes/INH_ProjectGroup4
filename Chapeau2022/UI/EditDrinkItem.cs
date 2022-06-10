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
    public partial class EditDrinkItem : Form
    {
        private DrinkItem item;
        private DrinkService drinkService;
        private StockView stockView;
        private Tools tools;
        public EditDrinkItem(DrinkItem item, StockView stockView)
        {
            this.item = item;
            this.stockView = stockView;
            drinkService = new DrinkService();
            tools = new Tools();
            InitializeComponent();
            Start();
        }
        public void Start() 
        { 
            label2.Text=item.Item_Name.ToString();
            textBoxItemName.Text=item.Item_Name.ToString();
            textBoxPrice.Text=item.Item_Price.ToString();
            textBoxQuantity.Text=item.Item_Stock.ToString();
            textBoxAmountNeeded.Text = item.Item_AmountNeeded.ToString();

            int typeId = (int)Enum.Parse(typeof(DrinkType), item.Item_DrinkType.ToString());

            if (typeId == 0)
                radioButton4.Select();
            else if (typeId == 1)
                radioButton5.Select();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (CheckForInputErrors())
                return;

            int drinkType = tools.IndexOfRadioButton(radioButton4, radioButton5);

            DrinkItem drink = new DrinkItem()
            {
                Item_Id = item.Item_Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_DrinkType = (DrinkType)drinkType,
                Item_AmountNeeded = int.Parse(textBoxAmountNeeded.Text)
            };
            drinkService.UpdateDrink(drink);
            stockView.DrinkStock();
            stockView.ClearSelectedListViewItems();
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text))
                textBoxQuantity.Text = "0";

            textBoxQuantity.Text = (int.Parse(textBoxQuantity.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxAmountNeeded.Text != "0")
                try
                {
                    textBoxAmountNeeded.Text = (int.Parse(textBoxAmountNeeded.Text) - 1).ToString();
                }
                catch
                {
                    textBoxAmountNeeded.Text = "0";
                }
        }
    }
}
