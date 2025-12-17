using one;

namespace _02_assign_net_practice
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int number = 10;
            switch (number)
            {
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");
                    break;
                case 30:
                    Console.WriteLine("case 30");
                    break;
                default:
                    Console.WriteLine("none matches");
                    break;
            }
            Home obj= new Home();
            Home.home();

        }
    }
}
