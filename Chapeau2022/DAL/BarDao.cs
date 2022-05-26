using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BarDao : BaseDao
    {
        public List<Bar> GetAllRunningOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bar> GetAllFinishedOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
       
        private List<Bar> ReadTables(DataTable dataTable)
        {
            List<Bar> bars = new List<Bar>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bar bar = new Bar()
                {
                    TableNr = (int)dr[""],
                    Placed = (DateTime)dr[""],
                    Quantity = (int)dr[""],
                    DrinkType = (DrinkType)dr[""],
                    DrinkName = (string)dr[""],
                    DrinkDescription = (string)dr[""],
                    DrinkStatus = (Status)dr[""]
                };
                bars.Add(bar);
            }
            return bars;
        }
    }
}
