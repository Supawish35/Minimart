using Microsoft.Data.SqlClient;

namespace Minimart;

public class Minimart {
    public static SqlConnection Connect() {
        string serverName = @"SUPAWISH\SQLEXPRESS";
        string databaseName = "Minimart";

        string connectionString = $"Data Source={serverName}; Initial Catalog={databaseName}; Integrated Security = True; Encrypt = False;";
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        return conn;
    }
}