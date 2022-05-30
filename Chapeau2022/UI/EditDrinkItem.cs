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
        public EditDrinkItem(DrinkItem item)
        {
            this.item = item;
            InitializeComponent();
            Start();
        }
        public void Start() 
        { 
            label2.Text=item.Item_Name.ToString();
            textBoxItemName.Text=item.Item_Name.ToString();
            textBoxPrice.Text=item.Item_Price.ToString();
            textBoxQuantity.Text=item.Item_Stock.ToString();

            int typeId = (int)Enum.Parse(typeof(DrinkType), item.Item_DrinkType.ToString());

            if (typeId == 0)
                radioButton4.Select();
            else if (typeId == 1)
                radioButton5.Select();
        }
    }
}
