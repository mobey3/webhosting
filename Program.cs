using System;

namespace _0323
{
    class Program
    {
        static void Main(string[] args)
        {
            string inch = Console.ReadLine();
            double a = (double.Parse(inch));
            double cm = 2.54;
            Console.WriteLine("inch: " + inch);
            Console.WriteLine(double.Parse(inch) * cm);

            string kg = Console.ReadLine();
            double b = (double.Parse(kg));
            double pound = 2.20462262;
            Console.WriteLine("kg: " + kg);
            Console.WriteLine(double.Parse(kg) * pound);

            string radius = Console.ReadLine();
            double c = (double.Parse(radius));
            double num = 3.14;

            Console.WriteLine("반지름: " + radius);
            Console.WriteLine(2*double.Parse(radius) * num );
            Console.WriteLine(num * double.Parse(radius) * double.Parse(radius));*

        }
    }
}
