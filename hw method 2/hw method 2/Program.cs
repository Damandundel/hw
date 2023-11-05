namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine(rectangleshort(side1, side2));           

        }

        static int rectangleshort(int a, int b) => a * b;
    }
}

