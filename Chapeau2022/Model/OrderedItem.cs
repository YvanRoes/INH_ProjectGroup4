using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum ItemOrderedStatus
    {
        Ready, NotReady
    }
    public class OrderedItem
    {
        public MenuItem menuItem { get; set; }

        public int _itemOrdered_id { get; set; }

        public int _itemOrder_id { get; set; }

        public int _itemOrdered_Qty { get; set; }

        public ItemOrderedStatus _itemOrdered_Status { get; set; }

        public string _itemOrdered_Comment { get; set; }

        //Kitchen and barview
        public DateTime _itemOrdered_Placed { get; set; }

        public int table_Id { get; set; }

        public OrderedItem(MenuItem item) => menuItem = item;
    }
}
