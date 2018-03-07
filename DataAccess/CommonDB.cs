using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CommonDB
    {
        string connectionString;
        public CommonDB(string conString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    connection.Close();
                }
                connectionString = conString;
            }
            catch (SqlException e)
            {

                throw e;
            }
        }

        public DataTable execute(string q)
        {
            DataTable resultSet = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(q, new SqlConnection(connectionString)))
            {
                adapter.Fill(resultSet);
            }
            return resultSet;
        }
    }
}
