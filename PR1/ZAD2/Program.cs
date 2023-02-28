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
            int num = Convert.ToInt32(Console.ReadLine());

            int firstNum = num / 1000;
            int secondNum = (num / 100) % 10;
            int thirdNum = (num / 10) % 10;
            int fourthNum = num % 10;

            int result = firstNum * 1000 + thirdNum * 100 + secondNum * 10 + fourthNum;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
