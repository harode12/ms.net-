using _1SampleAttribute;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"D:\pratik.net\DAY BY DAY NOTES\day 7\IET_Dec_2025_Batch-master (5)\IET_Dec_2025_Batch-master\CSharpDemos\1EmpLib\bin\Debug\net8.0\1EmpLib.dll";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] types = asm.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j<allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is PKAttribute)
                    {
                        PKAttribute pkAtt = attr as PKAttribute;
                        Console.WriteLine($"Class {type.Name} is developed by {pkAtt.DeveloperName} of (c) {pkAtt.CompanyName}");
                    }
                    if (attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Class {type.Name} is marked as Serializable");
                    }
                }
            }


        }
    }
}
