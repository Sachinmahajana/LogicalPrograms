using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Couponnumber
    {
        public void FindCouponNumber()
        {
            // Random number to generate coupon number
            Console.WriteLine("How many coupon number you required");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Genereted Coupon number");

            for(int i = 0; i< Number; i++)
            {
                Random random = new Random();
                int coupon = random.Next(10000, 100000);
                Console.WriteLine(coupon);
            }
        }
    }
}
