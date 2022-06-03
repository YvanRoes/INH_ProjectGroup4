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
        private List<OrderedItem> listOfOrderedItems;
        //List<OrderedItem> listOfOrderedItems;
        //Order order;
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

            txtTip.Enabled = false;
            txtComment.Enabled = false;

            DisplayOrderedItems();
            CalculateTotalandVat();
        }

        //Display all the ordered items on the listview
        private List<OrderedItem> DisplayOrderedItems()
        {

            //set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            listOfOrderedItems = billService.GetAllOrderedItems();

            // clear the listview before filling it again
            lvOrderedItems.Items.Clear();

            foreach (OrderedItem orderedItems in listOfOrderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItems.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderedItems._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderedItems.menuItem.Item_Price.ToString("€0.00"));
                lblTable.Text = orderedItems.table_Id.ToString();
                orderID = orderedItems._itemOrder_id;
                lvOrderedItems.Items.Add(li);
            }
            return listOfOrderedItems;

        }

        //calculate the total price and vat
        public void CalculateTotalandVat()
        {
            DrinkItem drinkItem = new DrinkItem();
            foreach (OrderedItem orderedItems in listOfOrderedItems)
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
            lblSubTotal.Text = subTotal.ToString("€0.00");
            lblTotalVat.Text = (highVat + lowVat).ToString("€0.00");
            lblTotal.Text = (subTotal + highVat + lowVat).ToString("€0.00");
        }


        // Check the tip box whether the user enter any tip ot not

        public decimal CheckTipBox()
        {

            if (txtTip.Text != string.Empty)
            {


                // Running on the worker thread
                tip = decimal.Parse(txtTip.Text);

                lblTotal.Text = (subTotal + highVat + lowVat + tip).ToString("€0.00");
            }
            else
            {
                tip = 0.00m;
            }
            return tip;
        }
        // Check the Comment box whether the user enter any comment ot not
        public string CheckCommentBox()
        {
            string comment = "";

            if (txtComment.Text != string.Empty)
            {
                comment = txtComment.Text;
            }
            else
            {
                comment = "No comment enter";
            }

            return comment;
        }
        /// <summary>
        /// Insert data into database when user click on pay
        /// </summary>
        /// <param name="bill"></param>

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            decimal total = subTotal + highVat + lowVat + tip;
            try
            {
                if (rbCreditcard.Checked)
                    bill.Method = BillMethod.CreditCard;
                else if (rbPin.Checked)
                    bill.Method = BillMethod.Pin;
                else if (rbCash.Checked)
                    bill.Method = BillMethod.Cash;

                Bill insertBill = new Bill(total, CheckTipBox(), CheckCommentBox(), bill.Method);
                billService.InsertBill(insertBill);
                MessageBox.Show($"Payment Successfull");
                billService.UpdatePaymentStatus(orderID);
                ClearBillForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while payment\n{ex.Message}");

            }
        }
        public void ClearBillForm()
        {
            lvOrderedItems.Clear();
            lblSubTotal.Text = "";
            lblTotalVat.Text = "";
            lblTotal.Text = "";
            cbTip.Checked = false;
            txtTip.Text = "";
            txtComment.Text = "";
            cbComment.Checked = false;
            rbCreditcard.Checked = false;
            rbPin.Checked = false;
            rbCash.Checked = false;
        }

        private void cbComment_CheckedChanged(object sender, EventArgs e)
        {
            txtComment.Enabled = true;

        }

        private void cbTip_CheckedChanged(object sender, EventArgs e)
        {
            txtTip.Enabled = true;

        }

    }
}