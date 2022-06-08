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
    public partial class PopupAddToOrder : Form, IOrderObservable
    {
        MenuItem _menuItem;
        Order _order;
        int _Qty = 1;
        IOrderObserver _observer; //OrderForm

        public PopupAddToOrder(MenuItem item, Order order, IOrderObserver observer)
        {
            this._order = order;
            this._observer = observer;
            this._menuItem = item;
            InitializeComponent();
            Start(item, order);
        }

        void Start(MenuItem item, Order order)
        {
            Displayitem(item);
            LoadQty();
        }

        //Quantity
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Qty += 1;
            LoadQty();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            _Qty -= 1;
            LoadQty();
        }

        //Comments
        private void cBComments_CheckedChanged(object sender, EventArgs e)
        {
            if(cBComments.Checked)
                tBComments.Enabled = true;
            else
                tBComments.Enabled = false;
        }

        //Display
        void Displayitem(MenuItem item)
        {
            lblMenuItemName.Text = item.Item_Name;
            lblPrice.Text = item.Item_Price.ToString();
        }

        private void LoadQty() => txtQty.Text = _Qty.ToString();

        public void NotifyObservers() => _observer.Update(_order);

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (_Qty > 0)
            {
                _order.AddItem(_menuItem, _Qty, tBComments.Text);
                NotifyObservers();
                this.Close();
            }
            else
                MessageBox.Show("Quantity specified is not possible");
            
        }

        public void AddObserver(IOrderObserver observer)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IOrderObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
