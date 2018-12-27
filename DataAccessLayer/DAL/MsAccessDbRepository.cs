using System.Collections.Generic;
using System.Data.OleDb;

namespace DAL
{
    public class MsAccessDbRepository
    {
        public static List<string> FetchUsers()
        {
            var tempUsers = new List<string>();
            var query = "select * from users";
            using (var msAccessConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\intel\\Documents\\techintalkDb.accdb"))
            {
                var command = new OleDbCommand(query, msAccessConnection);
                msAccessConnection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tempUsers.Add(reader.GetValue(0) + " : " + reader.GetValue(1));
                }
            }
            return tempUsers;
        }
    }
}
