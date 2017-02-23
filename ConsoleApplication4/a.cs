using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    public class A

    {
        public void s1()
        {
            Console.WriteLine("A::s1");v1();
        }

        protected void v1()
        {
            Console.WriteLine("A::v1");s3();
        }

        public void s2()
        {
            Console.WriteLine("A::s1"); s1();
        }

        private void s3()
        {
            Console.WriteLine("A::s3"); 
        }
    }
}