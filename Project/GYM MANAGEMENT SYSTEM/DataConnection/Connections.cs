using System;
using System.Data.SqlClient;
using System.IO;

namespace GYM_MANAGEMENT_SYSTEM.DataConnection
{
    /// <summary>
    /// Connects To The Sql Server Databases 
    /// </summary>
    public class Connections
    {
        /// <summary>
        /// returns Sql connection From Current Server 
        /// </summary>
        /// <returns></returns>
        /// 


        public SqlConnection GetSqlConnection()
        {
            string databaseName = "gym_db.mdf";
            string PathName = Path.GetFullPath(Environment.CurrentDirectory);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + PathName + @"\" + databaseName + ";Integrated Security=true;";

            var SqlConnection = new SqlConnection(connectionString);

            return SqlConnection;
        }
    }
}
