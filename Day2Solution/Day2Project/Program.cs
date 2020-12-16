using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, j, flag;
            Console.WriteLine("Enter min value ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max value");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers between given {0} and {1} are: ", a, b);
            for (i = a; i <= b; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;
                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Shrishti Soni");
            Console.ReadKey();
        }
    }
}
