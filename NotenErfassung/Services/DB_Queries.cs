using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NotenErfassung
{
    class DB_Queries
    {
        public IEnumerable<Subject> GetAllSubjects()
        {
            var query = @"SELECT SUBJECTS.NAME FROM SUBJECTS";

            using (var connection = Connection.getConnection())
            {
                var command = new SqlCommand(query, connection);

                connection.Open();

                return null;
            }
        }
    }
}
