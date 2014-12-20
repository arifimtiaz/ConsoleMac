using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacDonaldsInterview1
{
    class Program
    {
        public void getdata()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
       public void getdata1()
       {
            for (int k = 1; k <= 9; k++)
            {
                for (int l = 9; l >= k; l--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.getdata1();
            p.getdata();
            Console.ReadLine();
        }
    }
}
