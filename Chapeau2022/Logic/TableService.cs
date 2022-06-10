using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class TableService
    {
            private TableDao tableDao;
            public TableService()
            {
                tableDao = new TableDao();
            }

           /*public List<Table> ReadTables(int tableId) // Gets all employees for the table
            {
                return tableDao.ReadTables(tableId);
            }*/



    }
}
