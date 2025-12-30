//using DBconnnection.Models;
//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DBconnnection.DAL
//{
//    public class DBcontext
//    {
//        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True";
//        public List<Users> checkUser(string username,string password)
//        {
//            SqlConnection connection = new SqlConnection(conn);
//            SqlCommand cmd = new SqlCommand($"select * from Users where username='{username}',password='{password}'",connection);

//            connection.Open();
//            SqlDataReader reader = cmd.ExecuteReader();
//            List<Emp> user = new List<Emp>();

//            while (reader.Read())
//            {
//                user.Add(new Users()
//                {   
//                    Id=Convert.ToInt32(reader["UserId"]),
//                    Username=reader["Username"].ToString(),
//                    Password=reader["Password"].ToString()
//                });

                
//            }
//            connection.Close();
//            //return user;
//        }

//    }
//}
using DBconnnection.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnnection.DAL
{
    public class DBcontext
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True";
        public List<Users> checkUser(string username,string password)
        {
            SqlConnection connection = new SqlConnection(conn);
            string query = $"select * from Users where Username='{username}' and Password='{password}'";
            SqlCommand cmd = new SqlCommand(query,connection);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Users> user = new List<Users>();

            while (reader.Read())
            {
                user.Add(new Users()
                {   
                    Id=Convert.ToInt32(reader["UserId"]),
                    Username=reader["Username"].ToString(),
                    Password=reader["Password"].ToString()
                });

                
            }
            connection.Close();
            return user;
        }

        public int insertUser(int id,string username, string password)
        {
            SqlConnection connection = new SqlConnection(conn);
            string query = $"insert into Users (userid,username,password) values ({id},'{username}','{password}')";
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();

            int n = cmd.ExecuteNonQuery();
            connection.Close();
            return n;
        }

        
               public int deleteUser(int id)
        {
            SqlConnection connection = new SqlConnection(conn);
            string query = $"DELETE FROM Users WHERE UserId = {id}";
            SqlCommand cmd = new SqlCommand(query, connection);

            connection.Open();
            int n = cmd.ExecuteNonQuery();
            connection.Close();
            return n;
        }
    }
}
