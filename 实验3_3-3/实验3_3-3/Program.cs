using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验3_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2, n = 3 , a ;
            a = m;
            m = n;
            n = a;
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
