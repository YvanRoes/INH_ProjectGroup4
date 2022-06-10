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
    public partial class PopupEditOrderedItem : Form, IOrderObservable
    {
        OrderedItem _OrderedItem { get; set; }
        Order _Order { get; set; }
        IOrderObserver _Observer { get; set; }
        int _Qty { get; set; }
        string _Comment { get; set; }
        public PopupEditOrderedItem(OrderedItem item, Order order, IOrderObserver observer)
        {
            InitializeComponent();
            _OrderedItem = item;
            _Order = order;
            _Observer = observer;
            _Qty = _OrderedItem._itemOrdered_Qty;
            _Comment = _OrderedItem._itemOrdered_Comment;
            Start(_OrderedItem);
        }

        void Start(OrderedItem item)
        {
            Displayitem(item);
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
            if (cBComments.Checked)
                tBComments.Enabled = true;
            else
            {
                tBComments.Enabled = false;
                tBComments.Clear();
            }
            
        }

        //Display
        void Displayitem(OrderedItem item)
        {
            lblMenuItemName.Text = item.menuItem.Item_Name;
            lblPrice.Text = item.menuItem.Item_Price.ToString();
            LoadQty();

            if(_OrderedItem._itemOrdered_Comment != null || _OrderedItem._itemOrdered_Comment != "")
            {
                tBComments.Text = _OrderedItem._itemOrdered_Comment;
                tBComments.Enabled = true;
                cBComments.Checked = true;
                
            }

        }

        private void LoadQty() => txtQty.Text = _Qty.ToString();

        //observer
        public void NotifyObservers() => _Observer.Update(_Order);

        public void AddObserver(IOrderObserver observer)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IOrderObserver observer)
        {
            throw new NotImplementedException();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _OrderedItem._itemOrdered_Qty = _Qty;
            if (cBComments.Checked)
                _OrderedItem._itemOrdered_Comment = tBComments.Text;
            else
                _OrderedItem._itemOrdered_Comment = "";
            NotifyObservers();
            this.Close();
        }
    }
}
