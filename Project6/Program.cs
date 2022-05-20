using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    // В соревнованиях по бальным танцам каждый танцор из пары оценивается отдельно,
    // а затем их баллы суммируются для получения обещго результата пары
    // данная программа принимает имена и баллы каждого танцора в качестве входных данных
    // и создает объект DancePoints для каждого танцора,
    // используя полученные значения name и score в качестве параметров конструктора
    // Дополните данный класс, перегрузив оператор+ для возврата нового объекта,
    // в котором имена танцоров будут находиться в одной строке,
    // а результат равняться сумму их баллов
    // Объявление данного объекта и вывод баллов уже написаны в Main()

    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);
            DancerPoints total = dancer1 + dancer2;

            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
            Console.ReadKey();
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;

        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator+(DancerPoints dancer1, DancerPoints dancer2)
        {
            string name = dancer1.name + " & " + dancer2.name;
            int points = dancer1.points + dancer2.points;
            DancerPoints total = new DancerPoints(name, points);
            return total;
        }
    }
}
