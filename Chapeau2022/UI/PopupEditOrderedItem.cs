using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class PopupEditOrderedItem : Form
    {
        OrderedItem _OrderedItem { get; set; }
        Order _Order { get; set; }
        OrderForm _OrderForm { get; set; }
        public PopupEditOrderedItem(OrderedItem item, Order order, OrderForm form)
        {
            InitializeComponent();
            _OrderedItem = item;
            _Order = order;
            _OrderForm = form;

            Start();

        }

        void Start()
        {
            lblMenuItemName.Text = _OrderedItem.menuItem.Item_Name;
            lblPrice.Text = _OrderedItem.menuItem.Item_Price.ToString();
        }
    }
}
