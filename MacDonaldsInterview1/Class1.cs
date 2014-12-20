using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDonaldsInterview1
{
    class Class1
    {
        public void getvalue()
        {
            int i;
            Console.WriteLine("enter the value of i");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("not a even number");
            }
        }
    }
    class Class2
    {
        static void Main()
        {
            Class1 c = new Class1();
            c.getvalue();
            Console.Read();
        }
    }
}
