using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Flat
    {
        private int square;
        private decimal cost;
        private string name;
        int Square
        {
            get { return square; }
            set { square = value; }
        }
        decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Flat(int square, decimal cost, string name)
        {
            this.square = square;
            this.cost = cost;
            this.name = name;
        }
        public decimal FlatCost()
        {
            return cost * square;
        }
        public void Info()
        {
            Console.WriteLine($"Площадь: {square}");
            Console.WriteLine($"Цена: {cost}");
            Console.WriteLine($"Название: {name}");
        }
    }
}
