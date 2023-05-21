using System;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

            Console.Write(" a = ");
            double a =double.Parse(Console.ReadLine());
            Console.Write(" b = ");
            double b=double.Parse(Console.ReadLine());
            
            if (a!=0)
            {
                double x = -b / a;
                Console.WriteLine(" x = " + x);
            }
            else if (b==0 )
            {
                Console.WriteLine(" vo so nghiem ");
            }
            else
            {
                Console.WriteLine(" vo nghiem ");
            }
        }
    }
}
