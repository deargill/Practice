using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    public class Train
    {
        public int TrainNumber { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }

        public Train(int trainNumber, string destination, DateTime departureTime)
        {
            TrainNumber = trainNumber;
            Destination = destination;
            DepartureTime = departureTime;
        }

        public override string ToString()
        {
            return $"Поезд {TrainNumber} в {Destination} отправляется в {DepartureTime}";
        }
    }
}