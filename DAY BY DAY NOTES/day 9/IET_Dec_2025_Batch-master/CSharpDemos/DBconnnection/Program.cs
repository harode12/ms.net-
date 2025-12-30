using DBconnnection.DAL;

namespace DBconnnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii");
            DBcontext dbcontext=new DBcontext();
            while (true) 
            {
                Console.WriteLine("Enter Db Operation Choice: 1. Login, 2. create user, 3.delete user");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        { 
                            Console.WriteLine("enter username");
                            string uname = Console.ReadLine();
                            Console.WriteLine("enter password");
                            string pass = Console.ReadLine();
                            var user = dbcontext.checkUser(uname, pass);
                            if (user!=null)
                            {
                                Console.WriteLine($"welcome {uname}");
                            }
                            else
                            {
                                Console.WriteLine($"invalid {uname}");
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("enter id");
                            int id=Convert.ToInt32(Console.ReadLine()); 
                            Console.WriteLine("enter username");
                            string name = Console.ReadLine();
                            Console.WriteLine("enter password");
                            string pass = Console.ReadLine();
                            var user=dbcontext.insertUser(id,name,pass);
                            if (user>0)
                            {
                                Console.WriteLine($"User Added");
                            }
                            else
                            {
                                Console.WriteLine($"Error");
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("enter id");
                            int id = Convert.ToInt32(Console.ReadLine());
                           
                            var user = dbcontext.deleteUser(id);
                            if (user>0)
                            {
                                Console.WriteLine($"User deleted");
                            }
                            else
                            {
                                Console.WriteLine($"Error");
                            }
                            break;
                        }
                }
               

            }
           
            
        }
    }
}
