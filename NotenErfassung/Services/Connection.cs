using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NotenErfassung
{
    static class Connection
    {
        public static SqlConnection getConnection()
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NotenErfassung;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return new SqlConnection(connectionString);
        }
    }
}
