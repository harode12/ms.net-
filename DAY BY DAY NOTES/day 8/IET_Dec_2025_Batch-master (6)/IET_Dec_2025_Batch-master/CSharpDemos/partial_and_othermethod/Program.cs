namespace Linq_featuree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            ////Partial class : uses multiple files(multiple physical
            ///paths of the files) to define a single class

            // Class1 math = new Class1();
            //Console.WriteLine($"Multiply result = {math.Multiply(1, 2)}");
            // Console.WriteLine($"Multiply result = {math.Add(2, 3)}");
            // int mul=math.Multiply(2, 1);
            // Console.WriteLine($"multiplication is {mul}");

            #endregion

            #region nullable
            //DateTime? a = null;
            //int? deptId = null;
            //if (deptId.HasValue)
            //{
            //    Console.WriteLine(deptId.Value);
            //}
            //else
            //{
            //    Console.WriteLine("deptId = null");
            //}

            #endregion


            #region Object Initializer :{}
            //Demo demo = new Demo() { _id=100};
            //Console.WriteLine(demo._id);
            //demo._id=101;
            //Console.WriteLine(demo._id);


            //Console.WriteLine("Enter name:");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter description:");
            //string des = Console.ReadLine();
            //Demo demo2 = new Demo() { _name = nm, _description = des };

            //Console.WriteLine($"Name = {demo2._name}, Description= {demo2._description}");

            #endregion


            List<Demo> listDemoObjects = new List<Demo>() {
                new Demo(){ _id = 1, _name= "Hugh Jackman", _description="Australian Actor"},
                 new Demo(){ _id = 2, _name= "Tom Ellis", _description="Wellish Actor"},
            };


            listDemoObjects.Select(demo => demo._id)
                .ToList()
                .ForEach(Console.WriteLine); 
    //            .ToList()
    //.ForEach(Console.WriteLine);



            //foreach (Demo dm in listDemoObjects)
            //{
            //    Console.WriteLine($"Id= {dm._id}, Name = {dm._name}, Description = {dm._description}");
            //}


        }

    }

    public class Demo
    {
        public int _id;
        public string _name;
        public string _description;
    }
    }
