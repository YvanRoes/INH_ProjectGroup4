using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int _itemId { get; set; }
        public string _itemName { get; set; }
        public MenuItemType _itemType { get; set; }
        public decimal _ItemPrice { get; set; }
        public MenuItemCourse _itemCourse { get; set;}
    }
}
