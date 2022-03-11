using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_Override
{
    class DerivedClass :BaseClass
    {
        //public void Method2()
        //{
        //    Console.WriteLine("Derived - Method2");
        //}
        //public new void Method2()
        //{
        //    Console.WriteLine("Derived - Method2");
        //}
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }

        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
        
    }
}
