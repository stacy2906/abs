using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DerivetClass:AClass
    {
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("fhejkf");
        }

        public override void Method3()
        {
            Console.WriteLine("uhfuiehf");
        }
        public override void Method4()
        {
            Console.WriteLine("fygjjf");
        }
    }
}
