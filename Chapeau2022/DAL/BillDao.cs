using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDao : BaseDao
    {
        //Inser the  bill into the database
        public void BillRecord(Bill bill)
        {
            string query = $"INSERT INTO [BILL] VALUES ({bill.Method}, '{bill.Tip}', '{bill.Price}', '{bill.DateTime.ToString("dddd, dd MMMM yyyy")}', {bill.EmployeeID}, {bill.OrderNr})";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }


    }
}
