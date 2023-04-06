using System;
using System.Collections.Generic;
using MyLibraryClasses;

namespace PolymorphismExample
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Quadrilateral> quadrilaterals = new List<Quadrilateral>();

            quadrilaterals.Add(new Rectangle("Прямоугольник 1", 10, 5));
            quadrilaterals.Add(new Square("Квадрат 1", 7));
            quadrilaterals.Add(new Rectangle("Прямоугольник 2", 3, 8));
            quadrilaterals.Add(new Square("Квадрат 2", 4.5));

            foreach (Quadrilateral q in quadrilaterals)
            {
                q.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
