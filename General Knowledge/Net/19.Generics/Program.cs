using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Generics
{
    public class GenericList<T>
    {
        public void Add(T input) { }
    }

    class Program
    {
        private class ExampleClass { }

        static void Main(string[] args)
        {
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(5);
            list1.Add(21);

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();

            Console.ReadLine();
        }
    }
}
