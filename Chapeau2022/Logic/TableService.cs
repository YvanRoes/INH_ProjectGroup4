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

        public void SetTableAsFree(Table table)
        {
            tableDao.SetTableAsFree(table);
        }
        public void SetTableAsOccupied(Table table)
        {
            tableDao.SetTableAsOccupied(table);
        }
        public List<Table> GetTableStatus(TableStatus tablestatus)
        {
            List<Table> tables = tableDao.GetTableStatus(tablestatus);
            return tables;
        }

    }
}
