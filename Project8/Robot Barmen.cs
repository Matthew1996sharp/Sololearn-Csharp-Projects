using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    // У вас есть робот-бармен, который должен аккуратно раскладывать напитки на барные полки
    // Он очень умен и берет столько напитков, сколько необходимо,
    // чтобы равномерно распределить их по полкам, но у него все еще есть проблемы с делением
    // Программа, установленная в роботе, принимает количество напитков и количество полок
    // Дополните программу, чтобы равномерно распределять напитки по полкам,
    // разделив количество напитков на количество полок и выводить результат
    // Также программа должна обрабатывать следующие две возможные проблемы:
    // 1. делитель (количество полок) никогда не должен равняться нулю
    // 2. входные данные должны быть целыми числами
    // Для первого исключения программа должна выводить "At least 1 shelf",
    // а для второго "Please insert an integer"

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(drinks / shelves);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf");
            }

             catch (FormatException e)
            {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}
