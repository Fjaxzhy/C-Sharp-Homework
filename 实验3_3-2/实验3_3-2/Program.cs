using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验3_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.ReadKey();
            }
        }
    }
}
