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
    public class KitchenDao : BaseDao
    {
        public List<Kitchen> GetAllRunningOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Kitchen> GetAllFinishedOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Kitchen> ReadTables(DataTable dataTable)
        {
            List<Kitchen> kitchens = new List<Kitchen>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Kitchen kitchen = new Kitchen()
                {
                    TableNr = (int)dr[""],
                    Placed = (DateTime)dr[""],
                    Quantity = (int)dr[""],
                    CourseType = (CourseType)dr[""],
                    FoodOrder = (string)dr[""]
                };
                kitchens.Add(kitchen);
            }
            return kitchens;
        }
    }
}
