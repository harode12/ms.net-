using System.Runtime.Serialization.Formatters.Binary;

namespace _27Demo_BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\pratik.net\DAY BY DAY NOTES\day 6\IET_Dec_2025_Batch-master (4)\IET_Dec_2025_Batch-master\CSharpDemos\26Demo_FileIO\Files\sample2.txt";

            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "pratik";
            emp.Address = "kaspate wasti wakad";

            //Serialization is the process of converting an object into a format that can be saved or transferred (like a file or network).
            #region BinaryFormatter : Serialize
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    //       fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, emp);// emp, book, customer
            //fs.Close();
            //Console.WriteLine("Done");
            #endregion

            #region BinaryFormatter : Deserialize

            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

            BinaryFormatter bf = new BinaryFormatter();
            Emp empData = bf.Deserialize(fs) as Emp;
            fs.Close();

            Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address= {empData.Address}");

            #endregion
        }
    }

    // Gives permission to serialize the class to CLR
    [Serializable]
    public class Emp
    {
        private int _Id;
        private string _Name;

        [NonSerialized]// do not have permission to serialize this field
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }
}



//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace _27Demo_BinarySerialization
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string filePath = @"D:\pratik.net\DAY BY DAY NOTES\day 6\IET_Dec_2025_Batch-master (4)\IET_Dec_2025_Batch-master\CSharpDemos\26Demo_FileIO\Files\sample2.txt";


//            Emp emp = new Emp
//            {
//                Id = 101,
//                Name = "pratik",
//                Address = "kaspate wasti wakad"
//            };

//            #region Serialize
//            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                bf.Serialize(fs, emp);
//            }
//            Console.WriteLine("Serialization Done");
//            #endregion

//            #region Deserialize
//            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//            {
//                BinaryFormatter bf = new BinaryFormatter();
//                Emp empData = (Emp)bf.Deserialize(fs);

//                Console.WriteLine(
//                    $"Id = {empData.Id}, Name = {empData.Name}, Address = {empData.Address}"
//                );
//            }
//            #endregion
//        }
//    }

//    [Serializable]
//    public class Emp
//    {
//        private int _Id;
//        private string _Name;

//        [NonSerialized]
//        private string _Address;

//        public int Id { get => _Id; set => _Id = value; }
//        public string Name { get => _Name; set => _Name = value; }
//        public string Address { get => _Address; set => _Address = value; }
//    }
//}

