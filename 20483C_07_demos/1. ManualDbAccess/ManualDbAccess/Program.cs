using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ManualDbAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["MainDb"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                SqlCommand getPeople = new SqlCommand("select * from people", connection);
                SqlDataReader reader = getPeople.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["FirstName"]);
                }
                //SqlDataAdapter adapter = new SqlDataAdapter(getPeople);
                //DataSet data = new DataSet();
                //adapter.Fill(data);
                //DataTable people = data.Tables[0];
                //foreach(DataRow row in people.Rows)
                //{
                //    Console.WriteLine(row["FirstName"]);
                //}
            }
        }
    }
}
