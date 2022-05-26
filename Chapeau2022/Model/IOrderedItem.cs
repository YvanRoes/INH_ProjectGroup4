using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IOrderedItem
    {
        int ItemOrdered_Id { get; set; }

        int ItemOrdered_Quantity { get; set; }

        ItemOrderedStatus ItemOrdered_status { get; set; }

        public string ItemOrderedDescription { get; set; }
    }
}
