using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Salary.Extensions;
using Salary.Formatting;
using Salary.Properties;
using Salary.TaskScripts;

namespace Salary
{
    class SalaryReporter
    {
        public String RunReport(String verb, Options options, IFormatter formatter)
        {
            // Invoke appropriate verb script with supplied options
            using (var conn = GetConnection())
            using (var results = ExecuteVerb(conn, verb, options))
            {
                return formatter.Format(results);
            }
        }

        private SqlConnection GetConnection()
        {
            var conn = new SqlConnection(Settings.Default.ConnectionString);
            conn.Open();
            return conn;
        }

        private DbDataReader ExecuteVerb(SqlConnection conn, String verb, Options options)
        {
            SqlCommand command = null;

            // Could use reflection to build up a SqlCommand with the appropriately named script
            // and pass in specified options
            switch (verb)
            {
                case "search":
                    command = new SqlCommand(Scripts.Search, conn);
                    command.Parameters.AddWithValue("@Name", options.SearchVerb.Name);
                    break;

                case "role":
                    command = new SqlCommand(Scripts.Role, conn);
                    command.Parameters.AddWithValue("@Role", options.RoleVerb.Role);
                    break;
            }

            return (command != null) ? command.ExecuteReader() : null;
        }
    }
}
