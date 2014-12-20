using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDonaldsInterview1
{
    class Class5
    {
        public void star()
        {
            Console.WriteLine("enter the size of pyramid");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                for (int j = i; j <= a; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        class Class6
        {
            public static void Main()
            {
                Class5 c5 = new Class5();
                c5.star();
                Console.ReadLine();
            }
        }
    }
}
