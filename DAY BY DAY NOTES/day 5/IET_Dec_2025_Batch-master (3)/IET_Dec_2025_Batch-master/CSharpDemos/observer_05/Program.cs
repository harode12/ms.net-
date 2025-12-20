using System.Diagnostics.Tracing;

namespace observer_05
{
    public delegate void NotifyEveHandler(string invitation);
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();  
            Subscriber subscriber = new Subscriber();

            publisher.Notify += subscriber.MtdA;
            publisher.Notify += subscriber.MtdB;
            publisher.NotifySubscribers("you are invided to the grand new year party for just only 2000!!!");
                publisher.Notify -= subscriber.MtdB;
            publisher.NotifySubscribers("Free food along with great lakes view!!!");
        }

        public class Subscriber
        {
            public void MtdA(string invitation)
            {
                Console.WriteLine($"mtdA received:{invitation} via Subs");
            }

            
            public void MtdB(string invitation)
            {
                Console.WriteLine($"MtdB received: {invitation} via publish");
            }
        }

        public class Publisher
        {

            public event NotifyEveHandler Notify;

            public void NotifySubscribers(string invitation) {
                Notify?.Invoke(invitation);
        }
    }
}
    }   
