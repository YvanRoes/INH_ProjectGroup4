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
        public List<KitchenItem> GetAllRunningOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<KitchenItem> GetAllFinishedOrders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<KitchenItem> ReadTables(DataTable dataTable)
        {
            List<KitchenItem> kitchens = new List<KitchenItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                KitchenItem kitchen = new KitchenItem()
                {
                    TableNr = (int)dr[""],
                    Placed = (DateTime)dr[""],
                    Quantity = (int)dr[""],
                    CourseType = (CourseType)dr[""],
                    itemName = (string)dr[""],
                    description = (string)dr[""],
                    status = (Status)dr[""],
                };
                kitchens.Add(kitchen);
            }
            return kitchens;
        }
    }
}
