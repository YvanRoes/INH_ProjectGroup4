using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
