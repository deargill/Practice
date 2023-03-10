using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3.Class
{
    public class RailwayStation
    {
        private Train[] trains;

        public RailwayStation(Train[] trains)
        {
            this.trains = trains;
        }

        public Train this[int trainNumber]
        {
            get
            {
                return trains.FirstOrDefault(t => t.TrainNumber == trainNumber);
            }
        }

        public void PrintTrainsAfter(DateTime time)
        {
            var trainsAfterTime = trains.Where(t => t.DepartureTime > time);
            Console.WriteLine("Поезда после {0}:", time);
            foreach (var train in trainsAfterTime)
            {
                Console.WriteLine(train);
            }
        }
    }
}