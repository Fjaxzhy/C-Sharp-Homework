using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验3_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            if (a<60)
            {
                Console.WriteLine("不及格");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("及格");
                Console.ReadKey();
            }
        }
    }
}
