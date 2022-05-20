using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    // За прохождение первого уровня видеоигры игрок получает 1 очко.
    // За каждый последующий пройденный уровень получаемы очки увеличиваются на 1
    // Вам дана программа, которая принимает на входе количество пройденных уровней
    // Дополните данную функцию, чтобы она принимала количество уровней в качестве аргумента,
    // затем рекурсивно вычисляла и возвращала общее количество очков, полученное за пройденные уровни

    internal class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));
            Console.ReadKey();
        }

        static int Points(int levels)
        {
            if (levels == 1) return 1;
            else return levels + Points(levels - 1);
        }
    }
}
