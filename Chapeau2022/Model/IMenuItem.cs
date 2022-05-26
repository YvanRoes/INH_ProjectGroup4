using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IMenuItem
    {
        int Item_Id { get; set; }

        string Item_Name { get; set; }

        decimal Item_Price { get; set; }

        int Item_Stock { get; set; }
    }
}
