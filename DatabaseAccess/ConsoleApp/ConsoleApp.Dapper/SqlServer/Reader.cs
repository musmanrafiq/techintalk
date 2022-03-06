using ConsoleApp.Dapper.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Dapper.SqlServer
{
    public class Reader
    {
        public static void Read()
        {
            var cs = @"Server=localhost;Database=NorthWind;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var users = con.Query<User>("SELECT * from users");

            foreach (var user in users)
            {
                Console.WriteLine(user.user_name);
            }
        }
    }
}
