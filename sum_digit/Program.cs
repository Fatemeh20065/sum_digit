using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("sum_digit : "+sumdigit(num));
            Console.ReadKey();
        }
        static int sumdigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return n % 10 + sumdigit(n / 10);
            }
        }
    }
}
