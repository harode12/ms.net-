using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace _28Demo_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"D:\IET_Dec_25_Batch\CSharpDemos\28Demo_Serialization\Files\data.xml";

            //string filePath1 = @"D:\IET_Dec_25_Batch\CSharpDemos\28Demo_Serialization\Files\data.json";
            string filePath = @"D:\pratik.net\DAY BY DAY NOTES\day 6\IET_Dec_2025_Batch-master (4)\IET_Dec_2025_Batch-master\CSharpDemos\26Demo_FileIO\Files\data.xml";

            string filePath1 = @"D:\pratik.net\DAY BY DAY NOTES\day 6\IET_Dec_2025_Batch-master (4)\IET_Dec_2025_Batch-master\CSharpDemos\26Demo_FileIO\Files\data.json";


            Emp emp = new Emp();
            emp.Id = 101;
            emp.Name = "elon musk";
            emp.Address = "Mars";


            XmlSerializer xr = new XmlSerializer(typeof(Emp));
            //Type type = emp.GetType();
            //XmlSerializer xr = new XmlSerializer(type);

            #region XML Serialization 
            FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            //XmlSerializer xr = new XmlSerializer(typeof(Emp));
            xr.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Done");
            #endregion

            #region XML DeSerialization
            FileStream fsl = null;

            if (File.Exists(filePath))
            {
                fsl = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }

          //  XmlSerializer xr = new XmlSerializer(typeof(Emp));
            Emp empData = xr.Deserialize(fsl) as Emp;
            fsl.Close();
            Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address= {empData.Address}");
            #endregion

            #region JSON Serialization 

            //FileStream js = null;

            //if (File.Exists(filePath1))
            //{
            //    js = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    js = new FileStream(filePath1, FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //JsonSerializer.Serialize<Emp>(js, emp);
            //js.Close();
            //Console.WriteLine("Done");
            #endregion

            #region JSON DeSerialization
            //FileStream jsd = null;

            //if (File.Exists(filePath1))
            //{
            //    jsd = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist!");
            //}

            //Emp empData = JsonSerializer.Deserialize<Emp>(jsd);
            //jsd.Close();
            //Console.WriteLine($"Id = {empData.Id}, Name = {empData.Name}, Address= {empData.Address}");
            #endregion


        }
    }
    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Address;
        
        [XmlIgnore]
        [JsonIgnore]
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
