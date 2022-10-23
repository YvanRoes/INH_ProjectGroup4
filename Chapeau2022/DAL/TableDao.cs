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
    public class TableDao : BaseDao
    {
        public void SetTableAsFree(Table table)
        {
            string query = "UPDATE TABLE " +
                "SET occupancy = 0 " +
                "WHERE occupancy = @tableOccupancy; ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@itemOrderedId", table.tableOccupancy) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void SetTableAsOccupied(Table table)
        {
            string query = "UPDATE TABLE " +
                "SET occupancy = 1 " +
                "WHERE occupancy = @tableOccupancy; ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@itemOrderedId", table.tableOccupancy) };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Table> GetTableStatus(TableStatus tablestatus)
        {
            string query = $@" 
                            SELECT table_Nr,occupancy
                            FROM TABLE 
                            WHERE occupancy={(int)TableStatus.Free}
                            ";
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@occupancy", (int)tablestatus) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableId = (int)dr["table_Nr"],
                    tableOccupancy = (TableStatus)dr["occupancy"],

                };
                tables.Add(table);
            }
            return tables;
        }

        public List<Table> GetAllTables()
        {
            string query = @"SELECT table_Nr FROM [TABLE]
                            ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<Table> ReadAllTables(DataTable datatable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in datatable.Rows)
            {

                Table tableNr = new Table()
                {
                    Table_Nr = (int)dr["table_Nr"]
                };
                tables.Add(tableNr);
            }

            return tables;
        }
    }
}
