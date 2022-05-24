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
    public class OrderedItem : MenuItem
    {
        public int ItemOrdered_Id { get; set; }

        public int ItemOrdered_Quantity { get; set; }

        public Status ItemOrdered_status { get; set; }
    }
}
