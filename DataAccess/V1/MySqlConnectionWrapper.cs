using Dapper;
using MySql.Data.MySqlClient;

namespace csharp_Mysql_Sample.DataAccess.V1
{
    public class MySqlConnectionWrapper : IMySqlClient
    {
        private MySqlConnection connection;

        public MySqlConnectionWrapper(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Connect()
        {
            connection.Open();
            Console.WriteLine("Connected to MySQL Database");
        }

        public void Disconnect()
        {
            connection.Close();
            Console.WriteLine("Disconnected from MySQL Database");
        }

        /// <summary>
        /// ExecuteSql
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <param name="sql">Execute Sql</param>
        /// <returns>Sql Result</returns>
        public IEnumerable<T> ExecuteSql<T>(string sql)
        {
            return connection.Query<T>(sql);
        }
    }
}
