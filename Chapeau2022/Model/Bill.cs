namespace Model
{
    public enum PayStatus
    {
        notpaid, paid
    }
    public class Bill
    {
        public decimal Tip { get; set; }
        public decimal Total { get; set; }

        public BillMethod Method { get; set; }
        public string Comment { get; set; }

        public Bill()
        {

        }
        public Bill(decimal total, decimal tip, string comment, BillMethod billMethod)
        {
            Total = total;
            Tip = tip;
            Comment = comment;
            Method = billMethod;
        }


    }
}