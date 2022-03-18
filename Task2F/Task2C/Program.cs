// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using TestFarsh;

namespace Task2C // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sum = Farsh.sum(10);
            Console.WriteLine($"Sum of first 10 numbers = {sum}");

            Farsh.Shape s = Farsh.Shape.NewCircle(10);
            double area = Farsh.area(s);
            Console.WriteLine($"Area of circle with radius 10 = {area}");
        }
    }
}