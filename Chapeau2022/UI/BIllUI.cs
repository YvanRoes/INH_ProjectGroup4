using System;
using Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Globalization;
using System.Threading;

namespace UI
{

    public partial class BillUI : Form
    {
        private BillService billService = new BillService();
        private OrderedItemService orderedItemsService = new OrderedItemService();
        private List<OrderedItem> getOrderedItems;
        private const decimal HighVatRate = 0.21m;
        private const decimal LowVatRate = 0.06m;
        private decimal highVat = 0;
        private decimal lowVat = 0;
        private decimal subTotal = 0;
        private decimal tip;
        private int orderID;

        public BillUI()
        {
            InitializeComponent();
            Show();
            DisplayAllTable();
            txtTip.Enabled = false;
            txtComment.Enabled = false;

        }
        private void DisplayAllTable()
        {
            List<Bill> tables = billService.GetAllTables();
            foreach (Bill bill in tables)
            {
                cmbTable.Items.Add(bill.Table_Nr);
            }

        }
        
        private void cmbTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = int.Parse(cmbTable.SelectedItem.ToString());
            getOrderedItems = orderedItemsService.GetAllOrderedItems(selectedIndex);
            DisplayOrderedItems();
            CalculateTotalandVat();
            subTotal = 0;
            highVat = 0;
            lowVat = 0;
        }
        private void DisplayOrderedItems()
        {

            //set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            // clear the listview before filling it again
            lvOrderedItems.Items.Clear();

            foreach (OrderedItem orderedItems in getOrderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItems.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderedItems._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderedItems.menuItem.Item_Price.ToString("€0.00"));
                orderID = orderedItems._itemOrder_id;
                lvOrderedItems.Items.Add(li);
            }

        }
        private void CalculateTotalandVat()
        {
            DrinkItem drinkItem = new DrinkItem();
            foreach (OrderedItem orderedItems in getOrderedItems)
            {
                if (drinkItem.Item_DrinkType == DrinkType.Alcoholic)
                {
                    highVat += orderedItems.menuItem.Item_Price * orderedItems._itemOrdered_Qty * HighVatRate;
                }
                else
                {
                    lowVat += orderedItems.menuItem.Item_Price * orderedItems._itemOrdered_Qty * LowVatRate;
                }
                subTotal += orderedItems.menuItem.Item_Price * orderedItems._itemOrdered_Qty;
            }
            lblSubTotal.Text = subTotal.ToString("0.00");
            lblTotalVat.Text = (highVat + lowVat).ToString("0.00");
            lblTotal.Text = (subTotal + highVat + lowVat).ToString("0.00");
        }

        private decimal CheckTipBox()
        {

            if (txtTip.Text != string.Empty)
            {
                tip = decimal.Parse(txtTip.Text);

                lblTotal.Text = (decimal.Parse(lblTotal.Text.ToString()) + tip).ToString();
                //(subTotal + highVat + lowVat + tip).ToString("0.00");
            }
            else
            {
                tip = 0.00m;
            }
            return tip;
        }
        // Check the Comment box whether the user enter any comment ot not
        private string CheckCommentBox()
        {
            string comment = "";

            if (txtComment.Text != string.Empty)
            {
                comment = txtComment.Text;
            }
            else
            {
                comment = "No comment";
            }

            return comment;
        }

        private void cbComment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbComment.Checked)
                txtComment.Enabled = true;
            else
                txtComment.Enabled = false;

        }

        private void cbTip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTip.Checked)
                txtTip.Enabled = true;
            else
                txtTip.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
        }
        public void CheckPaymentMethod(Bill bill)
        {
            
          
        }
        private void btnPay_Click_1(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            decimal total = decimal.Parse((lblTotal.Text).ToString());
            decimal splitAmount = decimal.Parse(txtSplitAmount.Text.ToString());

            
            if (txtSplitAmount.Text != string.Empty && splitAmount <= total)
            {
                total = splitAmount;
            }
            else
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }
            if (rbCreditcard.Checked == false || rbPin.Checked == false || rbCash.Checked == false)
            {
                MessageBox.Show("Please select a payment method");
                return;
            }
            else
            {
                if (rbCreditcard.Checked)
                    bill.Method = BillMethod.CreditCard;
                else if (rbPin.Checked)
                    bill.Method = BillMethod.Pin;
                else if (rbCash.Checked)
                    bill.Method = BillMethod.Cash;
            }
            Bill insertBill = new Bill(orderID, total, CheckTipBox(), CheckCommentBox(), bill.Method);
            //billService.UpdatePaymentStatus(orderID);
            billService.InsertBill(insertBill);
            MessageBox.Show($"Payment Successfull");
            txtTip.Text = "";
            lblTotal.Text = (decimal.Parse(lblTotal.Text.ToString()) - splitAmount).ToString();


        }



    }
}