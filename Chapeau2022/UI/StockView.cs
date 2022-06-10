﻿using System;
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
using System.Windows.Forms.Layout;
using System.Windows.Forms.VisualStyles;
using System.Windows.Markup;
using System.Windows;

namespace UI
{
    public partial class StockView : Form
    {
        private FoodService _foodService;
        private DrinkService _drinkService;
        public bool IsDisplayingFood;
        private List<FoodItem> FoodItems;
        private List<DrinkItem> DrinkItems;
        public StockView()
        {
            _foodService = new FoodService();
            _drinkService = new DrinkService();
            FoodItems = new List<FoodItem>();
            DrinkItems = new List<DrinkItem>();
            IsDisplayingFood = false;
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            //listView1.Sorting = SortOrder.Ascending;

            DrinkStock();
            button4.Visible = true;
            button5.Visible = true;
        }
        public void FoodStock()
        {
            IsDisplayingFood = true;

            FoodItems = _foodService.GetAllFoodItems();

            Tools.FillListViewWithFood(listView1, FoodItems);

            if (radioButton1.Checked)
                SortByStatus();
            else if (radioButton2.Checked)
                SortByPrice();
            else if (radioButton3.Checked)
                SortByName();
            else
                SortById();
        }
        public void DrinkStock()
        {
            IsDisplayingFood = false;

            DrinkItems = _drinkService.GetAllDrinkItems();

            Tools.FillListViewWithDrinks(listView1, DrinkItems);

            if (radioButton1.Checked)
                SortByStatus();
            else if (radioButton2.Checked)
                SortByPrice();
            else if (radioButton3.Checked)
                SortByName();
            else 
                SortById();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FoodStock();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DrinkStock();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsDisplayingFood)
            {
                try
                {
                    Form EditItem = new EditFoodItem(_foodService.GetFoodItemById(int.Parse(listView1.SelectedItems[0].Text)), this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
            else
            {
                try
                {
                    Form EditItem = new EditDrinkItem(_drinkService.GetDrinkItemById(int.Parse(listView1.SelectedItems[0].Text)), this);
                    EditItem.ShowDialog();
                }
                catch { MessageBox.Show("Please select an item before editing."); }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected item.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (IsDisplayingFood)
                    {

                        _foodService.DeleteItem(int.Parse(listView1.SelectedItems[0].Text));
                        FoodStock();
                    }
                    else
                    {
                        _drinkService.DeleteDrink(int.Parse(listView1.SelectedItems[0].Text));
                        DrinkStock();
                    }
                }
            }
            else
                MessageBox.Show("Please select an item first.");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form addItem = new AddItem(this);
            addItem.ShowDialog();
        }
        public void ClearSelectedListViewItems() 
        {
            listView1.SelectedItems.Clear();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SortByStatus();
        }
        private void SortByStatus()
        {
            if (radioButton1.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Status()).ToList();
                Tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
            else if (radioButton1.Checked && IsDisplayingFood)
            {
                FoodItems = FoodItems.OrderBy(i => i.Status()).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SortByPrice();
        }
        private void SortByPrice() 
        {
            if (radioButton2.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Price).ToList();
                Tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
            else if (radioButton2.Checked && IsDisplayingFood)
            {
                FoodItems = FoodItems.OrderBy(i => i.Item_Price).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SortByName();
        }
        private void SortByName() 
        {
            if (radioButton3.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Name).ToList();
                Tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
            else if (radioButton3.Checked && IsDisplayingFood)
            {
                FoodItems = FoodItems.OrderBy(i => i.Item_Name).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SortById();
        }
        private void SortById() 
        {
            if (radioButton4.Checked && !IsDisplayingFood)
            {
                DrinkItems = DrinkItems.OrderBy(i => i.Item_Id).ToList();
                Tools.FillListViewWithDrinks(listView1, DrinkItems);
            }
            else if (radioButton4.Checked && IsDisplayingFood)
            {
                FoodItems = FoodItems.OrderBy(i => i.Item_Id).ToList();
                Tools.FillListViewWithFood(listView1, FoodItems);
            }
        }
    }
}
