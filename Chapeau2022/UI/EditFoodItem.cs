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
        public EditFoodItem(FoodItem item, StockView stockView)
        {
            InitializeComponent();
            this.stockView = stockView;
            this.item = item;
            foodService = new FoodService();
            Start();
        }

        public void Start() 
        { 
            label2.Text = item.Item_Name.ToString();
            textBoxItemName.Text = item.Item_Name.ToString();
            textBoxPrice.Text = item.Item_Price.ToString();
            textBoxQuantity.Text = item.Item_Stock.ToString();

            int CourseId = (int)Enum.Parse(typeof(CourseType), item.Item_CourseType.ToString());

            if (CourseId == 0)
                radioButton1.Select();
            else if (CourseId == 1)
                radioButton2.Select();
            else if (CourseId == 2)
                radioButton3.Select();

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
            int CourseType;
            int MenuType;

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
            FoodItem food = new FoodItem()
            {
                Item_Id = item.Item_Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_MenuType = (MenuType)MenuType,
                Item_CourseType = (CourseType)CourseType
            };
            foodService.UpdateFoodItem(food);
            stockView.FoodStock();
            Close();
        }
    }
}
