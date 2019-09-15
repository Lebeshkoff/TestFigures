using System;
using Figures;

namespace FigureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] Figures = new Figure[5]; //new объект

            Figures[0] = new Circle(3);
            Figures[1] = new Rectangle(1, 2);
            Figures[2] = new Rectangle(2, 3);
            Figures[3] = new Circle(5);
            Figures[4] = new Circle(1);

            double P = 0;
            double S = 0;

            foreach (Figure figure in Figures) // foreach извлекает элемент из коллекции и помещает его в объект
            {
                P += figure.CalcP(); //полиморфизм/ позднее связывание
                S += figure.CalcS(); //вызовет метод в котором нахолится фигура\
                Console.WriteLine(figure); //будет вызван метод
            }

            double AvgP = P / Figures.Length;
            double AvgS = S / Figures.Length;

            Console.WriteLine("+==============================================================+");
            Console.WriteLine("AvgP = " + Convert.ToString(AvgP));
            Console.WriteLine("AvgS = " + Convert.ToString(AvgS));




            Console.ReadLine();
        }
    }
}
