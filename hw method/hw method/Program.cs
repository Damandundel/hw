﻿namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = RectArea(width, height);
            Console.WriteLine(area);
        }
        static double RectArea(double width, double height)
        {
            return width * height;
        }
    }
}

