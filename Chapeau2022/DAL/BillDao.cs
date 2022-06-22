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
    public class BillDao : BaseDao
    {
        //Inser the  bill into the database
        public void InsertBill(Bill bill)
        {
            string query = $"INSERT INTO [BILL] VALUES (@order_Id, @total, @tip, @comment, @method)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@order_Id", bill.OrderId);
            sqlParameters[1] = new SqlParameter("@total", bill.Total);
            sqlParameters[2] = new SqlParameter("@tip", bill.Tip);
            sqlParameters[3] = new SqlParameter("@comment", bill.Comment);
            sqlParameters[4] = new SqlParameter("@method", bill.Method);

            ExecuteEditQuery(query, sqlParameters);

        }

        // When the order is paid ,then update the payment status as paid on database
        public void UpdatePaymentStatus(int orderId)
        {
            string query = $@"UPDATE [dbo].[ORDER] 
                              SET order_Status = {(int)PayStatus.paid}
                              WHERE order_Id = @order_Id";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@order_Id", orderId);

            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Bill> GetAllTables()
        {
            string query = @"SELECT table_Nr FROM [TABLE]
                            ";
   
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<Bill> ReadTables(DataTable datatable)
        {
            List<Bill> tables = new List<Bill>();

            foreach (DataRow dr in datatable.Rows)
            {

                Bill tableNr = new Bill()
                {
                    Table_Nr = (int)dr["table_Nr"]
                };
                tables.Add(tableNr);
            }

            return tables;
        }
    }

}