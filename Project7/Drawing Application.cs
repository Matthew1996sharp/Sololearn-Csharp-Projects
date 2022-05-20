using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{
    // Вы создаете приложение для рисования и в данный момент имеете один инструмент - карандаш
    // Вы хотите добавить кисть и спрей на панель инструментов рисования
    // Данная программа объявляет интерфейс IDraw с методом StartDraw() и класс Draw,
    // который выполняет рисование карандашом, реализуя интерфейс IDraw. Он выводит "Using pencil"
    // Завершите классы Brush и Spray, унаследовав их из класса Draw и реализовав метод StartDraw()

    internal class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

            Console.ReadKey();
        }
    }

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    class Brush : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }
    }

    class Spray : Draw
    {
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }
    }
}
