using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an instance of the SampleCollection type.
            SampleCollection<string> stringCollection = new SampleCollection<string>();

            // Use [] notation on the type.
            stringCollection[0] = "Hello, World";
            System.Console.WriteLine(stringCollection[0]);

            Console.ReadLine();

            SampleCollection<int> intCollection = new SampleCollection<int>();
            intCollection[0] = 1;
            intCollection[1] = 2;
            intCollection[2] = 3;
            intCollection[3] = 5;
            intCollection[4] = 7;
            intCollection[5] = 11;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(intCollection[i]);
            }

            Console.ReadLine();

            SampleCollection<MyClass> myCollection = new SampleCollection<MyClass>();
            myCollection[0] = new MyClass { Id = 3, Name = "Stam" };
            myCollection[1] = new MyClass { Id = 23, Name = "Twenty Three" };

            //foreach statement cannot operate on variables of type SampleCollection<MyClass> 
            // because SampleCollection<MyClass> does not contain a public definition for 
            // 'GetEnumerator'
            //foreach (MyClass m in myCollection)
            //{

            //}

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(myCollection[i].Id + " - " + myCollection[i].Name);
            }

            Console.ReadLine();
        }
    }

    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[10];

        // Define the indexer, which will allow client code
        // to use [] notation on the class instance itself.
        // (See line 2 of code in Main below.)        
        public T this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }

    class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
