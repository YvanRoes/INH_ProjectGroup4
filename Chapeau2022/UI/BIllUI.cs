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
        decimal splitAmount=0;

        public BillUI()
        {
            InitializeComponent();
            Show();
            DisplayAllTable();
            lblStillToPay.Visible = false;

            txtTip.Enabled = false;
            txtComment.Enabled = false;
            txtSplitAmount.Enabled = false;

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
            if (cbAddComment.Checked)
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


        Bill bill = new Bill();

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal total = decimal.Parse((lblTotal.Text).ToString());
                if (cbSplitAmount.Checked)
                {
                    if (txtSplitAmount.Text != string.Empty)
                    {
                        splitAmount = decimal.Parse(txtSplitAmount.Text.ToString());
                        if (splitAmount > total)
                        {
                            MessageBox.Show("Please enter a valid amount");
                            return;
                        }

                    }
                    total = splitAmount;

                }

                if (rbCreditcard.Checked)
                    bill.Method = BillMethod.CreditCard;
                else if (rbPin.Checked)
                    bill.Method = BillMethod.Pin;
                else if (rbCash.Checked)
                    bill.Method = BillMethod.Cash;
                else
                {
                    MessageBox.Show("Please select a payment method");
                    return;
                }
                Bill insertBill = new Bill(orderID, total, CheckTipBox(), CheckCommentBox(), bill.Method);
                // billService.UpdatePaymentStatus(orderID);
                billService.InsertBill(insertBill);
                MessageBox.Show($"Payment Successfull");
 
                Clear();
                lblStillToPay.Visible = true;
                txtTip.Text = "";
                txtSplitAmount.Text = "";
                lblTotal.Text = (decimal.Parse(lblTotal.Text.ToString()) - splitAmount).ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroor:{ex.Message}");
            }


        }
        public void Clear()
        {
            lblSubTotalName.Text = "";
            lblTotalVatNaam.Text = "";
            lblSubTotal.Text = "";
            lblTotalVat.Text = "";
            lblEuro2.Text = "";
            lblEuro1.Text = "";
            //lblTotal.Text = "";


        }

        private void cbTip_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbTip.Checked)
            {
                txtTip.Enabled = true;
            }
            else
            {
                txtTip.Enabled = false;

            }
        }

        private void cbAddComment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddComment.Checked)
            {
                txtComment.Enabled = true;
            }
            else
            {
                txtComment.Enabled = false;

            }

        }

        private void cbSplitAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSplitAmount.Checked)
            {
                txtSplitAmount.Enabled = true;

            }
            else
            {
                txtSplitAmount.Enabled = false;

            }

        }

    }
}