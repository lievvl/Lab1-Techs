using System;
using System.Runtime.InteropServices;

namespace DllTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        [DllImport("MyDll.dll")]
        static extern int Sum(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(1, 2));
        }
    }
}