using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Status
    {
        ready, notReady
    }
    public class OrderedItem
    {
        public int itemId { get; set; }
        public int quantity { get; set; }
        public int menuId { get; set; }
        public Status status { get; set; }
    }
}
