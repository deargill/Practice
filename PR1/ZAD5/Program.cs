using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int versts = Convert.ToInt32(Console.ReadLine());


            double kilometers = versts * 1066.8 / 1000;

            Console.WriteLine(kilometers);
        }
    }
}
