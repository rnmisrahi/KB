using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    class Program
    {


        static void Main(string[] args)
        {
            MC mc = new MC();
            mc.DoIt();
            Console.ReadLine();
        }
    }

    public class MC
    {
        //1.decalre delegate
        public delegate void MyDelegate();
        private void Method1()
        {
            Console.WriteLine("Method1 Invoked");
        }
        //lock code start
        private void Method2()
        {
            Console.WriteLine("Method2 Invoked");
        }
        //lock code End
        public void DoIt()
        {
            //2.create delegate referance
            MyDelegate myptr = null;
            //3.point the referance to Add function
            myptr += this.Method1;
            ////lock code start
            myptr += this.Method2;
            ////lock code end
            //4.invoke the method through delegate object
            myptr.Invoke();
        }

    }

}
