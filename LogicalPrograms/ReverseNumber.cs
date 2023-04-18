using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void FindReverseNumber(int number)
        {
            
            int reverse = 0;
            while (number != 0)
            {
                int rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;
            }
            Console.WriteLine("After reverse the number is: " + reverse);    
        }
    }
}
