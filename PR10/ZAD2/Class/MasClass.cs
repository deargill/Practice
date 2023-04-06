using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class MasClass : IComparable
    {
        private string[] masCl;
        private int indL;
        private int indR;

        public MasClass(string[] masCl, int indL, int indR)
        {
            if (indL > indR)
                throw new Exception("Индексы не логичны");
            if (masCl.Length != indR - indL + 1)
                throw new IndexOutOfRangeException();
            this.indR = indR;
            this.indL = indL;
            this.masCl = new string[indR - indL + 1];
            int j = 0;
            for (int i = indL; i <= indR; i++)
            {
                this.masCl[i] = masCl[i];
            }
        }
        public string StringByIndex(int index)
        {
            return masCl[index];
        }
        public void Print()
        {
            for (int i = indL; i <= indR; i++)
            {
                Console.WriteLine($"[{i}] = {masCl[i]}");
            }
        }
        public void PrintByIndex(int index)
        {
            Console.WriteLine($"[{index}]{masCl[index]}");
        }
        public static MasClass operator +(MasClass class1, MasClass class2)
        {
            if (class1.indL != class2.indL | class1.indR != class2.indR)
                throw new IndexOutOfRangeException();
            string[] mas = new string[class1.indR - class1.indL + 1];
            MasClass newClass = new MasClass(mas, class1.indL, class1.indR);
            for (int i = class1.indL; i <= class1.indR; i++)
            {
                newClass.masCl[i] = class1.masCl[i] + class2.masCl[i];
            }
            return newClass;
        }
        public static bool operator >(MasClass class1, MasClass class2)
        {
            return class1.indR - class1.indL > class2.indR - class2.indL;
        }
        public static bool operator <(MasClass class1, MasClass class2)
        {
            return class1.indR - class1.indL < class2.indR - class2.indL;
        }
    }
}
