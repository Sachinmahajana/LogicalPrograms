using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void FindPrimeNumber(int number)
        {
            int count = 0;
            for(int i = 1; i<=number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("Number is Prime Number");
            }
            else
            {
                Console.WriteLine("Number is not a prime");
            }
        }
    }
}
