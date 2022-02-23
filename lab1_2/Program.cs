using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0; // вхідний аргумент
            double a = 0; // вхідний параметр
            double b = 0; // вхідний параметр
            double c = 0; // вхідний параметр
            double F = 0; // результат обчислення виразу
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            // спосіб 1: розгалуження в скороченій формі
            if (x + 5 < 0 && c == 0) 
            {
                F = ((1) / a * x) - b;
            }
            if (x + 5 > 0 && c != 0)
            {
                F = (x - a) / x;
            }
            if (!(x + 5 < 0 && c == 0) && !(x + 5 > 0 && c != 0))
            {
                F = (10 * x) / c - 4;
            }
            Console.WriteLine("");
            Console.WriteLine($"{Math.Round(F, 2)}");
           
        }
    }
}
