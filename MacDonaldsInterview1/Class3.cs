using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDonaldsInterview1
{
    class Class3
    {
        public void Geteven()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
    class Class4
    {
        static void Main()
        {
            Class3 c3 = new Class3();
            c3.Geteven();
            Console.Read();
        }
    }
}
