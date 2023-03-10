using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            TwoDimensionalArray tda = new TwoDimensionalArray(myArray);
            int product = tda.GetMultOfPosElLessThTen();
            Console.WriteLine(product);
        }
    }
}
