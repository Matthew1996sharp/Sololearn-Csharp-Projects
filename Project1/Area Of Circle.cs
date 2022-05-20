using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    // Вам нужно написать программу, которая будет рассчитывать площадь круга
    // Данная программа объявляет постоянную переменную pi со значением 3.14
    // Дополните программу, чтобы она принимала радиус в качестве входных данных,
    // затем рассчитывала и выводила площадь круга

    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;

            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pi * radius * radius);
            Console.ReadKey();
        }
    }
}
