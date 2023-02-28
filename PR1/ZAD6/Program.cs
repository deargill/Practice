using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int firstNum = num / 100;
            int secondNum = (num / 10) % 10;

            int sum = firstNum + secondNum;

            Console.WriteLine(sum);
        }
    }
}
