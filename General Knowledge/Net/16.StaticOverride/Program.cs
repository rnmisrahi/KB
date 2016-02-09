using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.StaticOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            MC mc = new MC2();
            mc.overrideMe();

            Console.ReadLine();
        }
    }

    class MC
    {
        public virtual void overrideMe()
        {
            Console.WriteLine("I am MC");
        }
    }

    class MC2 : MC
    {
        //A static member cannot be marked as override, virtual or abstract
        //public static override void overrideMe()
        public override void overrideMe()
        {
            Console.WriteLine("I am MC2");
        }
    }


}
