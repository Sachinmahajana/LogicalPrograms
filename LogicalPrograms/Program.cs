namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To logical program");
            Console.WriteLine("Please select the program given below");
            Console.WriteLine("\n1:PrimeNumber");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the number");
                    int input = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber.FindPrimeNumber(input);
                    break;
                default:
                    Console.WriteLine("Please select the given below program");
                    break;
            }

        }
    }
}