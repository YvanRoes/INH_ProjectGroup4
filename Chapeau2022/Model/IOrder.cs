using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IOrder
    {
        DateTime Placed { get; set; }

        int TableNr { get; set; }
    }
}
