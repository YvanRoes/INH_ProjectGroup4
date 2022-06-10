﻿using System;
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

            txtTip.Enabled = false;
            txtComment.Enabled = false;
            txtNumberOfPeople.Enabled = false;
            btnSubmit.Visible = false;
            getOrderedItems = orderedItemsService.GetAllOrderedItems();
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



            // clear the listview before filling it again
            lvOrderedItems.Items.Clear();

            foreach (OrderedItem orderedItems in getOrderedItems)
            {
                ListViewItem li = new ListViewItem(orderedItems.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderedItems._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderedItems.menuItem.Item_Price.ToString("€0.00"));
                lblTable.Text = orderedItems.table_Id.ToString();
                orderID = orderedItems._itemOrder_id;
                li.Tag =orderedItems;
                lvOrderedItems.Items.Add(li);
            }
            return getOrderedItems;

        }

        //calculate the total price and vat
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

        // Check the tip box whether the user enter any tip ot not

        private decimal CheckTipBox()
        {

            if (txtTip.Text != string.Empty)
            {
                tip = decimal.Parse(txtTip.Text);

                lblTotal.Text = (subTotal + highVat + lowVat + tip).ToString("0.00");
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
        /// <summary>
        /// Insert data into database when user click on pay
        /// </summary>
        /// <param name="bill"></param>
        
        private void btnPay_Click_1(object sender, EventArgs e)
        {
            decimal total = subTotal + highVat + lowVat + tip;
            Bill bill = new Bill();
            try
            {
                if (rbCreditcard.Checked)
                    bill.Method = BillMethod.CreditCard;
                else if (rbPin.Checked)
                    bill.Method = BillMethod.Pin;
                else if (rbCash.Checked)
                    bill.Method = BillMethod.Cash;
                Bill insertBill = new Bill(orderID,total, CheckTipBox(), CheckCommentBox(), bill.Method);
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
        // Clear the form when the payment done
        private void ClearBillForm()
        {
            lblTable.Text = "";
            lvOrderedItems.Clear();
            lblSubTotal.Text = "";
            lblTotalVat.Text = "";
            lblTotal.Text = "";
            lblSplitBill.Text = "";
            cbTip.Checked = false;
            txtTip.Text = "";
            txtComment.Text = "";
            txtNumberOfPeople.Text = "";
            cbComment.Checked = false;
            checkBoxSplit.Checked = false;
            btnSubmit.Visible = false;
            rbCreditcard.Checked = false;
            rbPin.Checked = false;
            rbCash.Checked = false;

        }

        private void cbComment_CheckedChanged(object sender, EventArgs e)
        {
            if(cbComment.Checked)
                txtComment.Enabled = true;
            else
                txtComment.Enabled =false;

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
            MainWindow back=new MainWindow();
            back.Show();
        }

        private void checkBoxSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSplit.Checked)
            {
                txtNumberOfPeople.Enabled = true;
                btnSubmit.Visible = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                btnSubmit.Visible = false;
            }

        }
        //Split the bill among the group of people
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int nrOfPeople = int.Parse(txtNumberOfPeople.Text);
            double total = double.Parse(lblTotal.Text);
            double splitAmount = (double)(total/nrOfPeople);
            lblSplitBill.Text = splitAmount.ToString("€ 0.00");
        }
    }
}