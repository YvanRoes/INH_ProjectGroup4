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
            InitializeComponent();
            this.item = item;
        }
    }
}
