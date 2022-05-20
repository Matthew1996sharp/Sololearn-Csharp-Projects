using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    // Вы учитель начальной школы, который объясняет своим ученикам умножение
    // Вы собираетесь использовать умножение на 3 в качестве примера
    // Вам дана программа, которая принимает число N в качестве входных данных
    // напишите программу, которая будет выводить все числа от 1 до N, заменяя все числа кратные 3 на *
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0) Console.Write("*");
                else Console.Write(i);
            }

            Console.ReadKey();
        }
    }
}
