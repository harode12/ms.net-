using System.Collections;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Emp emp1 = new Emp();
            emp1.Eid = 101;
            emp1.Ename = "Hugh Jackman";
            emp1.EAddress = "Sydney, Australia";

            Emp emp2 = new Emp();
            emp2.Eid = 102;
            emp2.Ename = "Tony Stark";
            emp2.EAddress = "Shivaji Nagar";

            Emp emp3 = new Emp();
            emp3.Eid = 103;
            emp3.Ename = "Tom Ellis";
            emp3.EAddress = "L.A";

            Book book = new Book();
            book.BookName = "The Hobbit";
            book.Author = "J.R.R. Tolkien";
        }
    }

    public class Book
    {
        ///private string _Author;
          private string _BookName;
        private string _Author;

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }
    }

    public class Emp
    {
        private int _Eid;
        private string _Ename;
        private string _EAddress;

        public string EAddress
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }


        public int Eid
        {
            get { return _Eid; }
            set { _Eid = value; }
        }

    }

    }
