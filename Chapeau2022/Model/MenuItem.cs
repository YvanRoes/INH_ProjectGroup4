using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int menuId { get; set; }
        public string itemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int stock { get; set; }
    }
}
