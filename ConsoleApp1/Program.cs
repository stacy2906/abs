using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivetClass derivetClass = new DerivetClass();

            derivetClass.Method1();
            derivetClass.Method2();
            derivetClass.Method3();
            derivetClass.Method4();
            AClass aclass = new DerivetClass();
            aclass.Method1();
            aclass.Method2();
            aclass.Method3();
            aclass.Method4();


        }
    }
}
