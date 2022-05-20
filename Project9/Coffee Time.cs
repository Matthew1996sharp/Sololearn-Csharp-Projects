using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    // Менеджер кофейни проводит рекламную акцию и хочет предоставить скидку на кофейные напитки
    // Вам данак программа, которая принимает на входе размер скидки и определяет словарь,
    // в котором названия кофейных напитков заданы в качестве ключей, а их цена в качестве значений
    // Напишите программу, которая будет применять скидку ко всем ценам
    // и выводимть новый прайс-лист в формате указанном ниже

    internal class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Amricano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (KeyValuePair<string, int> line in coffee)
            {
                Console.WriteLine(line.Key + " " + line.Value * discount / 100);
            }

            Console.ReadKey();
        }
    }
}
