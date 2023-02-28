using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y = Math.Log(2 * x) + (Math.Pow(Math.Sin(x + 1), 2));

            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
