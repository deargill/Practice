using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass
{
    interface Prototype
    {
        object DeepCopy();
        Prototype Clone();
        public void GetInfo();
        public void AddFish(string fish);
    }
}
