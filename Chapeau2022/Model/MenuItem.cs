using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int Item_Id { get; set; }

        public string Item_Name { get; set; }

        public decimal Item_Price { get; set; }

        public int Item_Stock { get; set; }

        public int Item_AmountNeeded { get; set; }

    }
}
