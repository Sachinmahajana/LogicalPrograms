﻿namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To logical program");
            Console.WriteLine("Please select the program given below");
            Console.WriteLine("\n1:PrimeNumber\n2:ReverseNumber\n3:Couponnumber\n4:Perfectnumber\n5:Fibonacciseries\n6:Monthlypayment");
            Console.WriteLine("\n7:Stopwatch\n8:Swapnib\n9:Temperatureconversion");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the number");
                    int input = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.FindPrimeNumber(input);
                    break;
                case 2:
                    Console.WriteLine("Enter the number");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.FindReverseNumber(input1);
                    break;
                case 3:
                    Couponnumber coupon = new Couponnumber();
                    coupon.FindCouponNumber();
                    break;
                case 4:
                    PerfectNumber myObj = new PerfectNumber();
                    myObj.FindperfectNo();
                    break;
                case 5:
                    Fibonacciseries myObj1 = new Fibonacciseries();
                    myObj1.FindFibo();
                    break;
                case 6:
                    MonthlyPayment myObj2 = new MonthlyPayment();
                    myObj2.monthlyPaymentfind();
                    break;
                case 7:
                    StopWatch myObj3 = new StopWatch();
                    myObj3.FindElapsedTime();
                    break;
                case 8:
                    SwapNib myObj4 = new SwapNib();
                    myObj4.SwapNibbles(100);
                    break;
                case 9:
                    Temperatureconversion myObj5 = new Temperatureconversion();
                    myObj5.TempertatureConversionFind();
                    break;
                default:
                    Console.WriteLine("Please select the given below program");
                    break;
            }

        }
    }
}