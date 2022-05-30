using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblDrinkName.Show();
                lblFoodName.Hide();

                groupBoxAlcoholContent.Show();
                groupBoxCourse.Hide();
                groupBoxMenu.Hide();
            }
            else 
            {
                lblDrinkName.Hide();
                lblFoodName.Show();

                groupBoxAlcoholContent.Hide();
                groupBoxCourse.Show();
                groupBoxMenu.Show();
            }
        }
    }
}
