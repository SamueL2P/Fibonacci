using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTerms, temp1 = 0, temp2 = 1, nextNum = 0;
            Console.WriteLine("Enter the number of Terms");
            numberOfTerms = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfTerms; i++)
            {
                if (i == 1)
                {
                    Console.Write(temp1 + " ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(temp2 + " ");
                    continue;
                }
                nextNum = temp1 + temp2;
                temp1 = temp2;
                temp2 = nextNum;

                Console.Write(nextNum + " ");

            }
        }
    }
}
