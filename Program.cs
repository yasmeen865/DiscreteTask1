using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("enter frist number");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            n2 = int.Parse(Console.ReadLine());

            bool result = true;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                        result = false;
                }

                if (result == true && i != 1)
                {
                    Console.WriteLine(i);
                }
                result = true;
            }
        }
    }
}
