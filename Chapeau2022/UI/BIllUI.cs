using System;
using Logic;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using System.Globalization;
using System.Threading;

namespace UI
{

    public partial class BillUI : Form
    {
        private BillService billService = new BillService();
        private TableService tableService = new TableService();
        private Bill bill = new Bill();
        private OrderedItemService orderedItemsService = new OrderedItemService();
        private List<OrderedItem> getOrderedFoods;
        private List<OrderedItem> getOrderedDrinks;


        private const decimal HighVatRate = 0.21m;
        private const decimal LowVatRate = 0.06m;

        private decimal highVat;
        private decimal lowVat;
        private decimal subTotal;
        private decimal total;

        private int orderID;


        public BillUI()
        {
            InitializeComponent();
            Show();
            DisplayAllTable();           

            lblStillToPay.Visible = false;
            btnPay.Enabled = false;
            btnTip.Enabled = false;
            btnComment.Enabled = false;

            rbCreditcard.Checked = false;
            rbPin.Checked = false;
            rbCash.Checked = false;

        }
 
        private void DisplayAllTable()
        {
            List<Table> allTables =tableService.GetALlTables();
            foreach (Table table in allTables)
            {
                cmbTable.Items.Add(table.Table_Nr);
            }

        }
        //private List<OrderedItem> GetAllOrderedFoods(int tableNr)
        //{

        //    return orderedItemsService.GetAllOrderedFoods(tableNr);
        //}
        private void cmbTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int tableNr = int.Parse(cmbTable.SelectedItem.ToString());
            if (cmbTable.SelectedIndex > -1)
            {
                btnPay.Enabled = true;
            }
            //GetAllOrderedFoods(tableNr);
            getOrderedFoods = orderedItemsService.GetAllOrderedFoods(tableNr);
            getOrderedDrinks = orderedItemsService.GetALlOrdereDrinks(tableNr);
            DisplayOrderedItems();
            CalculateTotalandVat();
            highVat = 0;
            lowVat = 0;
            subTotal = 0;
            total = 0;
            
        }
        private void DisplayOrderedItems()
        {

            //set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            // clear the listview before filling it again
            lvOrderedItems.Items.Clear();

            foreach (OrderedItem orderedItems in getOrderedFoods)
            {
                ListViewItem li = new ListViewItem(orderedItems.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderedItems._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderedItems.menuItem.Item_Price.ToString("€0.00"));
                orderID = orderedItems._itemOrder_id;
                lvOrderedItems.Items.Add(li);
            }
            foreach (OrderedItem orderedItems in getOrderedDrinks)
            {
                ListViewItem li = new ListViewItem(orderedItems.menuItem.Item_Name.ToString());
                li.SubItems.Add(orderedItems._itemOrdered_Qty.ToString());
                li.SubItems.Add(orderedItems.menuItem.Item_Price.ToString("€0.00"));
                orderID = orderedItems._itemOrder_id;

                lvOrderedItems.Items.Add(li);
            }

        }
        //here i have to display the high vat and low vat
        private void CalculateTotalandVat()
        {
            DrinkItem drinkItem = new DrinkItem();
            foreach (OrderedItem orderedItems in getOrderedDrinks)
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
            foreach(OrderedItem orderedItems in getOrderedFoods)
            {
                lowVat += orderedItems.menuItem.Item_Price * orderedItems._itemOrdered_Qty * LowVatRate;
                subTotal += orderedItems.menuItem.Item_Price * orderedItems._itemOrdered_Qty;
            }
            lblHighVat.Text=highVat.ToString("0.00");
            lblLowVat.Text = lowVat.ToString("0.00");
            lblSubTotal.Text = subTotal.ToString("0.00");
           
            total = (subTotal + highVat + lowVat);
            lblTotal.Text = total.ToString("0.00");
            txtSplitBox.Text = total.ToString("0.00");
        }


        private void txtTip_TextChanged(object sender, EventArgs e)
       {
            if (txtTip.Text != string.Empty)
            {
                btnTip.Enabled = true;
            }
            else
            {
                btnTip.Enabled = false;
            }
        }
        decimal tip = 0.00m;
        private decimal GetTips()
        {
            if (decimal.Parse(txtTip.Text) <= 0)
            {
                string errorMessage = "Please enter a amount greater than 0";
                MessageBox.Show(errorMessage);
            }
            else if (txtTip.Text != string.Empty)
            {
                tip = decimal.Parse(txtTip.Text);

                lblTotal.Text = (decimal.Parse(lblTotal.Text) + tip).ToString("0.00");
            }
            else if(txtTip.Text==string.Empty)
            {
                txtTip.Text = tip.ToString("0.00");
            }

            return tip;
        }
        private void btnTip_Click(object sender, EventArgs e)
        {
            
                try
                {
                   GetTips();
                    tip = 0;
                    txtTip.Text = tip.ToString("0.00");
                
                }

                catch (Exception)
                {
                    MessageBox.Show("Something went wrong\n try again");

                }
            
        }
        // Check the Comment box whether the user enter any comment ot not

        private void CheckCommentBox()
        {
            string comment = "";
            try
            {
                if (txtComment.Text != string.Empty)
                {
                    comment = txtComment.Text;
                }
                else
                {
                    comment = "No comment";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong\ntry again");
              
            }

        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            try
            {
                CheckCommentBox();
                MessageBox.Show("Successfull");
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong\ntry again");
            }


        }
        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if(txtComment.Text != string.Empty)
            {
                btnComment.Enabled = true;
            }
            else
            {
                btnComment.Enabled = false;

            }


        }
  

        // Insert the bill to the database and update the payment status
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                decimal splitAmount;

                if (decimal.Parse(txtSplitBox.Text) <= 0)
                {
                    MessageBox.Show("Please enter an amount greater than 0");
                    return;
                }
                if (decimal.Parse(txtSplitBox.Text) > decimal.Parse(lblTotal.Text))
                {
                    MessageBox.Show("Please enter less than total");
                    return;
                }
                if (txtSplitBox.Text != string.Empty)
                {
                    splitAmount = decimal.Parse(txtSplitBox.Text);
                }

                if (rbCreditcard.Checked)
                    bill.Method = BillMethod.CreditCard;
                else if (rbPin.Checked)
                    bill.Method = BillMethod.Pin;
                else if(rbCash.Checked)
                    bill.Method = BillMethod.Cash;
                else
                {
                    MessageBox.Show("Please select a payment method first");
                    return;
                }

                PayBill();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eror:{ex.Message}");
            }

        }

        private void PayBill()
        {
            Bill insertBill;
            if (decimal.Parse(lblTotal.Text) != 0)
            {
                decimal tip= txtTip.Text == ""?tip=0.00m: tip = decimal.Parse(txtTip.Text);
                if (decimal.Parse(lblTotal.Text) == decimal.Parse(txtSplitBox.Text))
                {
                    insertBill = new Bill(orderID, decimal.Parse(lblTotal.Text), tip, txtComment.Text, bill.Method);
                    billService.InsertBill(insertBill);
                    //billService.UpdatePaymentStatus(orderID);
                    MessageBox.Show($"Full Payment Successfull");
                    CloseForm();
                }
                else
                {
                    insertBill = new Bill(orderID, decimal.Parse(txtSplitBox.Text), tip, txtComment.Text, bill.Method);
                    billService.InsertBill(insertBill);
                    MessageBox.Show($"Partial payment is successfull");
                    UpdateTheForm();                   
                    lblTotal.Text = (decimal.Parse(lblTotal.Text) - decimal.Parse(txtSplitBox.Text)).ToString();
                    txtSplitBox.Text=lblTotal.Text;
                }
            }
            
        }
        public void UpdateTheForm()
        {
            lblSubTotalName.Visible = false;
            lblSubTotal.Visible = false;
            lblEuro1.Visible = false;
            lblHighVatName.Visible = false;
            lblHighVat.Visible = false;
            lblEuro2.Visible = false;
            lblLowVatName.Visible = false;
            lblLowVat.Visible = false;
            lblEuro4.Visible = false;
            lblTotalName.Visible = false;
            lblStillToPay.Visible = true;
        }

        // Close the form when there is nothing to pay
        private void CloseForm()
        {
                this.Close();
                new MainWindow();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new MainWindow();
            this.Hide();
        }

        
    }
}