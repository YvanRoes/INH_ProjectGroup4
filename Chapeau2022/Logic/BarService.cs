using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BarService
    {
        BarDao barDao;

        public BarService()
        {
            barDao = new BarDao();
        }
    }
}
