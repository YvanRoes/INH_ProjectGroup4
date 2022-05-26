using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class OrderDao : BaseDao
    {
        public void SendSingleOrder(Order order)
        {
            InsertIntoOrderTable(order);
            InsertAllintoOrderedItem(order);
        }

        void InsertIntoOrderTable(Order order)
        {
            //making query and adding args
            string query = "INSERT INTO ORDER(order_TimeTaken, orderStatus) VALUES(@TT, 0);";
            SqlParameter[] sqlParameters = new SqlParameter[1] { new SqlParameter("TT", order.TimeTaken) };


            //exe query
            ExecuteEditQuery(query, sqlParameters);
        }

        void InsertAllintoOrderedItem(Order order)
        {
            order.Items.ForEach(x => 
            {
                //query and args
                string query = "INSERT INTO ORDERED_ITEM(itemOrdered_Quantity, itemOrdered_Status, item_Id, item_Description) VALUES(@Qty, 0, @Id, @des);";
                SqlParameter[] sqlParameters = new SqlParameter[3] { new SqlParameter("TT", order.TimeTaken), new SqlParameter("@Id", x.Item_Id.ToString()), new SqlParameter("@des", x.ItemOrdered_Description)};

                //execute
                ExecuteEditQuery(query, sqlParameters);
            });
        }
    }
}
