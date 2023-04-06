using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class CentralFlat : Flat
    {
        private string districtName;
        string DistrictName
        {
            get { return districtName; }
            set { districtName = value; }
        }
        public CentralFlat(int square, decimal cost, string name, string districtName) : base(square, cost, name)
        {
            this.districtName = districtName;
        }
        public decimal FlatCost()
        {
            return base.FlatCost() + base.FlatCost() / 100;
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"Район: {districtName}");
        }
    }
}
