using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();

            // s1, s2, s5, s6, s7 
            // c.s1(); //A::s1, A::v1, A::s3
            //c.s2(); //A::s2, A::s1, A::v1, A::s3
            //c.s5(); //B::s5, B::s3
            //c.s6(); //C::s6, B::v1
            //c.s7();//C::s7, B::v2,B::v1


            Console.ReadKey();

        }
        
    }
}
