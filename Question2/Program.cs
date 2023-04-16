using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Clac(x);
        }
        private static void Clac(int x)
        {
            double result = (Math.Pow(x, 2)) + (x * 2) - 4;
            Console.WriteLine("The Result is:" + result);
        }

    }
}
