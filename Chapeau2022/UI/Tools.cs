using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public class Tools
    {
        public int IndexOfRadioButton(RadioButton radioButton1, RadioButton radioButton2) 
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
        public int IndexOfRadioButton(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3)
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
        public int IndexOfRadioButton(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
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
        public int IndexOfSelectedCheckBox(CheckBox box1, CheckBox box2, CheckBox box3) 
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
        public void FillListViewWithDrinks(ListView listView1, List<DrinkItem> DrinkItems) 
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 50);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 60);
            listView1.Columns.Add("Alcohol", 124);
            listView1.Columns.Add("Qty.", 50);
            listView1.Columns.Add("Status", 124);

            foreach (DrinkItem item in DrinkItems)
            {
                string[] tempItem = {item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_DrinkType.ToString(), item.Item_Stock.ToString(), item.Status() };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
            
        }
        public void FillListViewWithFood(ListView listView1, List<FoodItem> FoodItems)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 40);
            listView1.Columns.Add("Name", 124);
            listView1.Columns.Add("Price", 60);
            listView1.Columns.Add("Item Type", 124);
            listView1.Columns.Add("Item Course", 124);
            listView1.Columns.Add("Qty.", 50);
            listView1.Columns.Add("Status", 120);

            foreach (FoodItem item in FoodItems)
            {
                string[] tempItem = { item.Item_Id.ToString(), item.Item_Name, item.Item_Price.ToString(), item.Item_MenuType.ToString(), item.Item_CourseType.ToString(), item.Item_Stock.ToString(), item.Status() };
                ListViewItem item2 = new ListViewItem(tempItem);
                listView1.Items.Add(item2);
            }
        }
        public bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,**";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
    }
}
