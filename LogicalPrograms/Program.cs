namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To logical program");
            Console.WriteLine("Please select the program given below");
            Console.WriteLine("\n1:PrimeNumber\n2:ReverseNumber\n3:Couponnumber");
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
                default:
                    Console.WriteLine("Please select the given below program");
                    break;
            }

        }
    }
}