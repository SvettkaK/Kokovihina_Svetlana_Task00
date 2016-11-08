using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans = '+';
            do
                try
                {
                    Console.Write("Введите число h: ");
                    double h = Double.Parse(Console.ReadLine());

                    double a = Math.Sqrt((Math.Abs(Math.Sin(8 * h)) + 17) / Math.Pow(1 - Math.Sin(4 * h) * Math.Cos(h * h + 18), 2));
                    double b = Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h))));
                    double c = (a * h * h * Math.Sin(b * h)) + (b * h * h * h * Math.Cos(a * h));

                    double D = b * b - 4 * a * c;
                    Console.WriteLine("\na = {0:0.##}", a);
                    Console.WriteLine("b = {0:0.##}", b);
                    Console.WriteLine("c = {0:0.##}", c);
                    Console.WriteLine("D = {0:0.##}\n", D);

                    if (D < 0) Console.WriteLine("D<0 Уравнение не имеет корней");

                    if (D == 0) Console.WriteLine("D=0 Уравнение имеет 2 одинаковых корня, X =" + (-b / (2 * a)));

                    if (D > 0)
                    {
                        Console.Write("D>0 Уравнение имеет 2 различных корня: ");
                        Console.Write("X1 = {0:0.##};", ((-b + Math.Sqrt(D)) / (2 * a)));
                        Console.Write(" X2 = {0:0.##}\n", ((-b - Math.Sqrt(D)) / (2 * a)));
                    }

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                }
                catch
                {
                    Console.WriteLine("Введены недопустимые символы. Повторите попытку...\n");
                    ans = '+';
                }
            while (ans == '+');


                    
        }
    }
}
