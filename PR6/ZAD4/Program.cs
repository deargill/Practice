using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] salaries = new int[20, 12];
            int totalSalaryInFebruary = 0;
            int totalSalaryInOctober = 0;

            for (int i = 0; i < 20; i++)
            {
                totalSalaryInFebruary += salaries[i, 1];
            }

            for (int i = 0; i < 20; i++)
            {
                totalSalaryInOctober += salaries[i, 9];
            }

            if (totalSalaryInFebruary < totalSalaryInOctober)
            {
                Console.WriteLine("Общая заработная плата в феврале была меньше, чем в октябре.");
            }
            else
            {
                Console.WriteLine("Общая заработная плата в феврале была не меньше, чем в октябре.");
            }
        }
    }
}
