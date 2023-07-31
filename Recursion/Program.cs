using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int RecursiveSum(int a, int b)
            {
                int total = a;
                while(a < b)
                {
                    a++;
                    total += a;
                    RecursiveSum(a, b);
                }
                return total;
            }

            int DivisibleByTwo(int a)
            {
                int counter = 0;
                while(a % 2 == 0)
                {
                    counter++; 
                    a = a / 2;
                    DivisibleByTwo(a);
                }
                return counter;
            }

            Console.WriteLine("Addition");

            Console.WriteLine("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Entere number m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine(RecursiveSum(n,m));

            Console.WriteLine("Division");
            Console.WriteLine("Enter your number");
            int foo = int.Parse(Console.ReadLine());
            Console.WriteLine(DivisibleByTwo(foo));
            Console.Read();
        }
    }
}
