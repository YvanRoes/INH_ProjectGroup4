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
    public partial class EditFoodItem : Form
    {
        private FoodItem item;
        private StockView stockView;
        private FoodService foodService;
        private Tools tools;
        public EditFoodItem(FoodItem item, StockView stockView)
        {
            this.stockView = stockView;
            this.item = item;
            foodService = new FoodService();
            tools = new Tools();
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            label2.Text = item.Item_Name.ToString();
            textBoxItemName.Text = item.Item_Name.ToString();
            textBoxPrice.Text = item.Item_Price.ToString();
            textBoxQuantity.Text = item.Item_Stock.ToString();
            textBoxAmountNeeded.Text = item.Item_AmountNeeded.ToString();

            int CourseId = (int)Enum.Parse(typeof(CourseType), item.Item_CourseType.ToString());

            switch (CourseId)
            {
                case 0:
                    radioButton1.Select();
                    break;
                case 1:
                    radioButton2.Select();
                    break;
                case 2: 
                    radioButton3.Select();
                    break;
            }
        

            int MenuTypeId = (int)Enum.Parse(typeof(MenuType), item.Item_MenuType.ToString());

            if (MenuTypeId == 0)
                radioButton4.Select();
            else if (MenuTypeId == 1)
                radioButton5.Select();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int CourseType = tools.IndexOfRadioButton(radioButton1, radioButton2, radioButton3);
            int MenuType = tools.IndexOfRadioButton(radioButton4, radioButton5);

            FoodItem food = new FoodItem()
            {
                Item_Id = item.Item_Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_MenuType = (MenuType)MenuType,
                Item_CourseType = (CourseType)CourseType,
                Item_AmountNeeded = int.Parse(textBoxAmountNeeded.Text)
            };
            foodService.UpdateFoodItem(food);
            stockView.FoodStock();
            Close();
        }
    }
}
