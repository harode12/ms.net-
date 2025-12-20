namespace Delegate
{
    public delegate void MyDelegate();
    public delegate void MyDelegate1(string name);
    public delegate int MyDelegateAdd(int a,int b);
    internal class Program
    {
        static void Main(string[] args)
        {
           // Greet g=new Greet();
            MyDelegate d = new MyDelegate(Greet.sayHi);
            d();
            MyDelegate1 d1 = new MyDelegate1(Greet.sayHello);
            d1("angel");
        }
    }
            
    public class Greet
    {
        public static void sayHi()
        {
            Console.WriteLine("hii ");
        }
        public static void sayHello(string name)
        {
            Console.WriteLine($"hello from {name}");
        }
    }
}
