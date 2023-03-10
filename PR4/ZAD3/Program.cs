using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAD3.Class;

namespace ZAD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train[]
            {
            new Train(1, "New York", new DateTime(2023, 3, 6, 12, 0, 0)),
            new Train(2, "Washington", new DateTime(2023, 3, 6, 13, 0, 0)),
            new Train(3, "Chicago", new DateTime(2023, 3, 6, 14, 0, 0)),
            new Train(4, "San Francisco", new DateTime(2023, 3, 6, 15, 0, 0)),
            };
            var railwayStation = new RailwayStation(trains);

            var train1 = railwayStation[1];
            if (train1 != null)
            {
                Console.WriteLine(train1);
            }
            else
            {
                Console.WriteLine("Поезд не найден.");
            }

            Console.Write("Введите время: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime time))
            {
                railwayStation.PrintTrainsAfter(time);
            }
            else
            {
                Console.WriteLine("Некорректный формат времени.");
            }
        }
    }
}
