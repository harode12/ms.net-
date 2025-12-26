using SampleAttribute;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
namespace RunAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"";   

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] types = asm.GetTypes();
            for (int i = 0; i < types.Length; i++) { 
                Type type= types[i];
                Attribute[] allAttributes=type.GetCustomAttributes().ToArray();
                for (int j = 0; j<allAttributes.Length; j++) { 
                    Attribute attr= allAttributes[j];
                    if(attr is PKAttribute)
                    {
                        PKAttribute pkAtt = attr as PKAttribute;
                        Console.WriteLine($"Class {type.Name} is developed by {pkAtt.DeveloperName} of (c) {pkAtt.CompanyName}");
                    }
                    //if(pkAtt is Serizab)
                    //{
                    //    Console.WriteLine();
                    //}
                }
            }


        }
    }
}
