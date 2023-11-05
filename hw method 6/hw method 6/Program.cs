namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            SignOfIntegerNumbers(n);
        }
        static void SignOfIntegerNumbers(int num)
        {
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");

            }

        }
    }
}

