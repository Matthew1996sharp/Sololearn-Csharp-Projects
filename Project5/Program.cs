using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    // Вам дана программа, которая задает массив из 10 слов и принимает букву в качестве вводных данных
    // Напишите программу для перебора массива и вывода слов, содержащих принятую букву
    // При отсутствии подходящих слов, программа должна выводить "No match"

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = 
                { "home", "programming", "victory", "C#", "football", 
                "sport", "book", "learn", "dream", "fun" };
            string letter = Console.ReadLine();
            int count = 0;

            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }

            if (count == 0) Console.WriteLine("No match");
            Console.ReadKey();
        }
    }
}
