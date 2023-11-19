namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double length = numbers.Count;
            Console.WriteLine(SumAdjacent(length, numbers));

        }
        static string SumAdjacent(double length, List<double> numbers)
        {


            for (int i = 0; i < length; i++)
            {
                if (i == numbers.Count - 1)
                {
                    break;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            return (string.Join(" ", numbers));
        }
    }
}
