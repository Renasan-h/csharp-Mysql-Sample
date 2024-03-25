namespace csharp_Mysql_Sample.DataAccess.V1
{
    public interface IMySqlClient
    {
        void Connect();
        void Disconnect();
        IEnumerable<T> ExecuteSql<T>(string sql);
    }
}
