using MySql.Data.MySqlClient;
namespace Commerce.BLL.Repository
{
    internal class Connection
    {
        public static MySqlConnection Conn()
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
