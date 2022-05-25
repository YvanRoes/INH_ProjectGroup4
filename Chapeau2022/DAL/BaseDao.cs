using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public abstract class BaseDao
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _connection;

        public BaseDao()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            _adapter = new SqlDataAdapter();
        }
        

        protected SqlConnection OpenConnection()
        {
                if (_connection.State == ConnectionState.Closed || _connection.State == ConnectionState.Broken)
                    _connection.Open();
            return _connection;
        }

        private void CloseConnection() => _connection.Close();


        //Edit query
        protected void ExecuteEditQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                _adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            } catch (Exception) { throw; }
        }


        //Select query
        protected DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable table;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                _adapter.InsertCommand = command;
                command.ExecuteNonQuery();
                _adapter.SelectCommand = command;
                _adapter.Fill(dataSet);
                table = dataSet.Tables[0];
            }
            finally { CloseConnection(); }
            return table;
        }


    }
}
