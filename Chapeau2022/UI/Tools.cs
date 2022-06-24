using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.IO;
using System.Drawing;

namespace UI
{
    public static class Tools
    {
        public static int IndexOfRadioButton(RadioButton radioButton1, RadioButton radioButton2) 
        {
            List<RadioButton> buttons = new List<RadioButton>();
            int index = 0;

            buttons.Add(radioButton1);
            buttons.Add(radioButton2);

            foreach (RadioButton radioButton in buttons) 
            {
                if (radioButton.Checked) 
                {
                    index = buttons.IndexOf(radioButton);
                }
            }
            return index;
        }
        public static int IndexOfRadioButton(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3)
        {
            List<RadioButton> buttons = new List<RadioButton>();
            int index = 0;

            buttons.Add(radioButton1);
            buttons.Add(radioButton2);
            buttons.Add(radioButton3);

            foreach (RadioButton radioButton in buttons)
            {
                if (radioButton.Checked)
                {
                    index = buttons.IndexOf(radioButton);
                }
            }
            return index;
        }
        public static int IndexOfRadioButton(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
        {
            List<RadioButton> buttons = new List<RadioButton>();
            int index = 0;

            buttons.Add(radioButton1);
            buttons.Add(radioButton2);
            buttons.Add(radioButton3);
            buttons.Add(radioButton4);

            foreach (RadioButton radioButton in buttons)
            {
                if (radioButton.Checked)
                {
                    index = buttons.IndexOf(radioButton);
                }
            }
            return index;
        }
        public static int IndexOfSelectedCheckBox(CheckBox box1, CheckBox box2, CheckBox box3) 
        {
            List<CheckBox> boxes = new List<CheckBox>();
            int index = 0;

            boxes.Add(box1);
            boxes.Add(box2);
            boxes.Add(box3);

            foreach (CheckBox box in boxes)
            {
                if (box.Checked)
                {
                    index = boxes.IndexOf(box);
                }
            }
            return index;
        }
        public static void FillListViewWithDrinks(ListView listView1, List<DrinkItem> DrinkItems) 
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 250);
            listView1.Columns.Add("Name", 380);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Alcohol", 320);
            listView1.Columns.Add("Qty.", 200);
            listView1.Columns.Add("Status", 150);
            listView1.Columns.Add(" ", 80);
            string s = "      ";
            foreach (DrinkItem item in DrinkItems)
            {
                string[] tempItem = {item.Item_Id.ToString(),item.Item_Name, item.Item_Price.ToString(), item.Item_DrinkType.ToString(), item.Item_Stock.ToString() +"  /  "+item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);

                if (item2.SubItems[5].Text == "Full")
                {
                    item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                    item2.UseItemStyleForSubItems = false;
                }
                else if (item2.SubItems[5].Text == "Low")
                {
                    item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                    item2.UseItemStyleForSubItems = false;
                }
                else
                {
                    item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                    item2.UseItemStyleForSubItems = false;
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithEmptyDrinks(ListView listView1, List<DrinkItem> DrinkItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 250);
            listView1.Columns.Add("Name", 380);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Alcohol", 320);
            listView1.Columns.Add("Qty.", 200);
            listView1.Columns.Add("Status", 150);
            listView1.Columns.Add(" ", 80);
            string s = "      ";
            foreach (DrinkItem item in DrinkItems)
            {
                if (item.Status() == "Restock") {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_DrinkType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[5].Text == "Full")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[5].Text == "Low")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithLowDrinks(ListView listView1, List<DrinkItem> DrinkItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 250);
            listView1.Columns.Add("Name", 380);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Alcohol", 320);
            listView1.Columns.Add("Qty.", 200);
            listView1.Columns.Add("Status", 150);
            listView1.Columns.Add(" ", 80);
            string s = "      ";
            foreach (DrinkItem item in DrinkItems)
            {
                if (item.Status() == "Low")
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_DrinkType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[5].Text == "Full")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[5].Text == "Low")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithFullDrinks(ListView listView1, List<DrinkItem> DrinkItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 250);
            listView1.Columns.Add("Name", 380);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Alcohol", 320);
            listView1.Columns.Add("Qty.", 200);
            listView1.Columns.Add("Status", 150);
            listView1.Columns.Add(" ", 80);
            string s = "      ";
            foreach (DrinkItem item in DrinkItems)
            {
                if (item.Status() == "Full")
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_DrinkType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[5].Text == "Full")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[5].Text == "Low")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 530);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            foreach (FoodItem item in FoodItems)
            {
                string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);

                if (item2.SubItems[6].Text == "Full")
                {
                    item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97,203,71);
                    item2.UseItemStyleForSubItems = false;
                }
                else if (item2.SubItems[6].Text == "Low")
                {
                    item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                    item2.UseItemStyleForSubItems = false;
                }
                else
                {
                    item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                    item2.UseItemStyleForSubItems = false;
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithLunchFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 500);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            foreach (FoodItem item in FoodItems)
            {
                if (item.Item_MenuType == MenuType.Lunch) 
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[6].Text == "Full")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[6].Text == "Low")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithEmptyFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 500);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            foreach (FoodItem item in FoodItems)
            {
                if (item.Status() == "Restock")
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[6].Text == "Full")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[6].Text == "Low")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithLowFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 500);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            foreach (FoodItem item in FoodItems)
            {
                if (item.Status() == "Low")
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[6].Text == "Full")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[6].Text == "Low")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithFullFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 500);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            foreach (FoodItem item in FoodItems)
            {
                if (item.Status() == "Full")
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[6].Text == "Full")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[6].Text == "Low")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithDinnerFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 500);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            foreach (FoodItem item in FoodItems)
            {
                if (item.Item_MenuType == MenuType.Dinner)
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(),  "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[6].Text == "Full")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[6].Text == "Low")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithSearchBoxFood(ListView listView1, List<FoodItem> FoodItems, string searchWord)
        {
            
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 500);
            listView1.Columns.Add("Price", 180);
            listView1.Columns.Add("Item Type", 250);
            listView1.Columns.Add("Item Course", 175);
            listView1.Columns.Add("Qty.", 150);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add(" ", 80);

            int i;
            foreach (FoodItem item in FoodItems)
            {
                i = 0;
                string itemName = item.Item_Name.ToLower();
                string searchWrd = searchWord.ToLower();

                for(int n = searchWord.Length; n>0; n--)
                {
                    if (itemName[i] == searchWrd[i])
                    {
                        
                        i++;
                    }
                    else
                        break;
                }
                if (i == searchWord.Length) 
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[6].Text == "Full")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[6].Text == "Low")
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[7].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static void FillListViewWithSearchBoxDrink(ListView listView1, List<DrinkItem> FoodItems, string searchWord)
        {

            listView1.Clear();
            listView1.Columns.Add("Id", 250);
            listView1.Columns.Add("Name", 380);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Alcohol", 320);
            listView1.Columns.Add("Qty.", 200);
            listView1.Columns.Add("Status", 150);
            listView1.Columns.Add(" ", 80);

            int i;
            foreach (DrinkItem item in FoodItems)
            {
                i = 0;
                string itemName = item.Item_Name.ToLower();
                string searchWrd = searchWord.ToLower();

                for (int n = searchWord.Length; n > 0; n--)
                {
                    if (itemName[i] == searchWrd[i])
                    {

                        i++;
                    }
                    else
                        break;
                }
                if (i == searchWord.Length)
                {
                    string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_DrinkType.ToString(), item.Item_Stock.ToString() + "  /  " + item.Item_AmountNeeded.ToString(), item.Status(), "⬤" };
                    ListViewItem item2 = new ListViewItem(tempItem);
                    listView1.Items.Add(item2);

                    if (item2.SubItems[5].Text == "Full")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(97, 203, 71);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else if (item2.SubItems[5].Text == "Low")
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(228, 246, 119);
                        item2.UseItemStyleForSubItems = false;
                    }
                    else
                    {
                        item2.SubItems[6].ForeColor = System.Drawing.Color.FromArgb(242, 77, 97);
                        item2.UseItemStyleForSubItems = false;
                    }
                }
            }
            ColourInRows(listView1);
        }
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,*";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }
        public static bool hasSpecialCharForPrice(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}-;'<>_*";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }
        public static bool hasInt(string input)
        {
            string specialChar = @"1234567890";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }
        public static void ColourInRows(ListView listView1) 
        {
            for (int l = 0; l <= listView1.Items.Count - 1; l++)
            {
                if (listView1.Items[l].Index % 2 == 1)
                    for (int n = 0; n <= listView1.Items[l].SubItems.Count - 1; n++)
                    {
                        listView1.Items[l].SubItems[n].BackColor = Color.WhiteSmoke;
                    }

                else
                    for (int n = 0; n <= listView1.Items[l].SubItems.Count - 1; n++)
                    {
                        listView1.Items[l].SubItems[n].BackColor = Color.White;
                    }
            }
        }
    }
}
