using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    public class TwoDimensionalArray
    {
        private int[,] array;

        public TwoDimensionalArray(int[,] array)
        {
            this.array = array;
        }

        public int GetMultOfPosElLessThTen()
        {
            int product = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0 && array[i, j] < 10)
                    {
                        product *= array[i, j];
                    }
                }
            }
            return product;
        }
    }
}