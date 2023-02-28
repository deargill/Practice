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
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            int windowWidth = Convert.ToInt32(Console.ReadLine());
            int windowHeight = Convert.ToInt32(Console.ReadLine());
            int doorWidth = Convert.ToInt32(Console.ReadLine());
            int doorHeight = Convert.ToInt32(Console.ReadLine());

            
            int wallArea = (2 * width * height) - (windowWidth * windowHeight) - (doorWidth * doorHeight);

            Console.WriteLine(wallArea);
            Console.ReadLine();
        }
    }
}
