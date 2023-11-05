namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintInWords(grade);

        }
        static void PrintInWords(double grade)
        {
            string performance = string.Empty;
            if (grade >= 2 && grade <= 2.99)
            {
                performance = "Fail";

            }
            if (grade >= 3 && grade <= 3.49)
            {
                performance = "Poor";

            }
            if (grade >= 3.50 && grade <= 4.49)
            {
                performance = "Good";

            }
            if (grade >= 4.50 && grade <= 5.49)
            {
                performance = "Very good";

            }
            if (grade >= 5.50 && grade <= 6)
            {
                performance = "Excellent";

            }
            Console.WriteLine(performance);
        }
    }
}

