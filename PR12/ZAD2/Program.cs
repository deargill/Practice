using System;
using MyLibraryClasses;

class Program
{
    static void Main(string[] args)
    {
        Foundation[] foundations = new Foundation[5];
        foundations[0] = new SquareFoundation("Квадратный фундамент 1", 5.2, 7.5);
        foundations[1] = new RectangleFoundation("Прямоугольный фундамент 1", 3.1, 10.0, 2.5);
        foundations[2] = new SquareFoundation("Квадратный фундамент 2", 6.5, 6.0);
        foundations[3] = new RectangleFoundation("Прямоугольный фундамент 2", 4.2, 7.0, 4.0);
        foundations[4] = new SquareFoundation("Квадратный фундамент 3", 8.3, 8.0);

        double maxHeight = 0;
        for (int i = 0; i < foundations.Length; i++)
        {
            foundations[i].PrintInfo();
            if (foundations[i].GetHeight() > maxHeight)
            {
                maxHeight = foundations[i].GetHeight();
            }
        }

        Console.WriteLine($"Максимальная высота фундаментов составляет {maxHeight}.");
    }
}
