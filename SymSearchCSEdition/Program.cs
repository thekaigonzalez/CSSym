using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SymSearchCSEdition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Search (Symbol Searcher in C#)!");
            Console.WriteLine("Type the name of a DLL Below.");
            string dll = Console.ReadLine();
            Assembly assembly = Assembly.LoadFrom(dll);

            if (Directory.Exists(dll))
            {
                while (true)
                {
                    Console.WriteLine("Type the name of a DLL class below. (example: System.Runtime OR System.Linq)");
                    Console.Write(">>> ");
                    string classs = Console.ReadLine();
                    Type type = assembly.GetType(classs);
                    object instance = Activator.CreateInstance(type); 
                    MethodInfo[] methods = type.GetMethods();
                    if (classs == "methods-available")
                    {
                        Console.WriteLine(methods);
                    }
                    else
                    {


                        //main
                        object result = methods[0].Invoke(instance, new object[] { });

                    }

                }
            }
        }
    }
}
