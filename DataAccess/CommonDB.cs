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
        //ConString = Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CybellesCyklerDB;Integrated Security=True;
        protected readonly string connectionString;
        
        public CommonDB(string conString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Close();
                }
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
