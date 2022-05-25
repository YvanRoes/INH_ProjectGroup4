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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        /*private void EditFoodItem_Load(object sender, EventArgs e)
        {
            textBoxItemName.Text = item.Item_Name.ToString();
            textBoxPrice.Text = item.Item_Price.ToString();
            textBoxQuantity.Text = item.Item_Stock.ToString();

            int typeId = (int)Enum.Parse(typeof(), item._ItemType.ToString());

            if (typeId == 0)
                radioButton1.Select();
            else if(typeId == 1)
                radioButton2.Select();
            else if(typeId == 2)
                radioButton3.Select();
        }*/
    }
}
