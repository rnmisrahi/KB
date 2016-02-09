using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            A b = new B();
            b.Id = 11;
            b.Name = "Eleven";
            b.X();
            b.Y();

            Console.ReadLine();
        }
    }

    abstract class A
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void X()
        {
            Console.WriteLine("A.X");
        }

        public virtual void Y()
        {
            Console.WriteLine("A.X");
        }
    }

    class B : A
    {
        public override void Y()
        {
            base.Y();
            Console.WriteLine("A:A.Y");
        }
    }
}
