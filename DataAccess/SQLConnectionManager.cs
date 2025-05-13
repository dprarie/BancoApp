using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BancoApp.DataAccess
{
   public static class SqlConnectionManager 
{
    public static string ConnectionString = "Server=localhost;Database=BancoDB;Trusted_Connection=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}
}
