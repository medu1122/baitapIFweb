using System;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hei : ");
            double hei = double.Parse(Console.ReadLine());
            Console.Write("wei : ");
            double wei = double.Parse(Console.ReadLine());
            double bmi = wei / (hei*hei);
            if (bmi<18.5)
            {
                Console.WriteLine("Underweight ");
            }
            else if (bmi<25)
            {
                Console.WriteLine("Normal ");

            }
            else if (bmi<30)
            {
                Console.WriteLine("Overweight");

            }
            else { Console.WriteLine("obese"); }
        }
    }
}