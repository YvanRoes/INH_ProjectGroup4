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

            int typeId = (int)Enum.Parse(typeof(DrinkType), item.Item_DrinkType.ToString());

            if (typeId == 0)
                radioButton4.Select();
            else if (typeId == 1)
                radioButton5.Select();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int drinkType = tools.IndexOfRadioButton(radioButton4, radioButton5);

            DrinkItem drink = new DrinkItem()
            {
                Item_Id = item.Item_Id,
                Item_Name = textBoxItemName.Text,
                Item_Price = decimal.Parse(textBoxPrice.Text),
                Item_Stock = int.Parse(textBoxQuantity.Text),
                Item_DrinkType = (DrinkType)drinkType
            };
            drinkService.UpdateDrink(drink);
            stockView.DrinkStock();
            Close();
        }
    }
}
