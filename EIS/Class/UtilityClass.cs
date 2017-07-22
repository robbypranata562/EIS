using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;

using System.Data;
using System.Reflection;
using System.Configuration;


namespace EIS.Class
{
    class UtilityClass
    {
        public SqlCommand command = new SqlCommand();
        public SqlConnection connection = new SqlConnection();
        public SqlDataReader dtreader;
        public SqlDataAdapter DA;
        public string _connString = "Data Source=RNH;Initial Catalog=db_sis;Persist Security Info=True;UID=sa;PWD=password";
        public SqlParameter param = new SqlParameter();
        public Boolean conn;
        public SqlDependency commanddependency;

        public Boolean OpenConnection()
        {
            if (!conn)
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                connection.ConnectionString = _connString;
                connection.Open();
                conn = true;
            }
            else
            {
                connection.Close();
                connection.ConnectionString = _connString;
                connection.Open();
                conn = true;
            }
            return conn;
        }

        public void CloseConnection()
        {
            if (conn)
            {
                connection.Close();

            }
        }

    }
}
