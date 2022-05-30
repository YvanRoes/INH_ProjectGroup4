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
        public EditFoodItem(FoodItem item)
        {
            InitializeComponent();
            this.item = item;
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

        }
    }
}
