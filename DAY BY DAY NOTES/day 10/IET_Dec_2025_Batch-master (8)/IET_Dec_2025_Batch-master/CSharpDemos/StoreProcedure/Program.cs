using Microsoft.Data.SqlClient;

namespace StoreProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conSt = "Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog = TestDB; Integrated Security = True";



            //  InsertDept(conSt, "abc");

            //InsertDept(conSt, "marketing");


            //InsertEmployee(conSt, "pk", 4);
            //InsertEmployee(conSt, "pt", 2);
            //InsertEmployee(conSt, "Rc", 4);

          //  GetEmployeeById(conSt, 4);
            GetEmployeeById(conSt, 1);
            Console.WriteLine("Done");

        }

        public static void InsertDept(string constr, string deptName)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType= System.Data.CommandType.StoredProcedure;
                    cmd.CommandText="InsertDepartment";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@DepartmentName", deptName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertEmployee(string constr, string empName, int deptId)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (var command = new SqlCommand("InsertEmployee", con))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", empName);
                    command.Parameters.AddWithValue("@DepartmentId", deptId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void GetEmployeeById(string constr, int id)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                using (var command = new SqlCommand("GetEmployeeByDepartment", connection))
                {
                    command.CommandType=System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DepartmentId", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["EmployeeId"]}, Name: {reader["EmployeeName"]}");
                        }
                    }
                }
            }
        }
    }
}
