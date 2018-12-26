using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class Sql
    {
        public static List<string> FetchRecords()
        {
            var tempRecords = new List<string>();
            var connectionString = "Data Source=localhost;Initial Catalog=techintalkDb;User Id=sa;Password=root;";
            var query = "select * from users";
            var sqlConnection = new SqlConnection(connectionString);
            var command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = null;

            try
            {
                sqlConnection.Open();
                reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    tempRecords.Add("User id is : " + reader.GetValue(0) + " and its name is : " + reader.GetValue(1));
                }
            }
            catch(Exception exp)
            {

            }
            sqlConnection.Close();
            command.Dispose();
            reader.Close();
            return tempRecords;
        }
    }
}
