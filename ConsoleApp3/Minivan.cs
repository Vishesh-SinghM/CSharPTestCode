using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Minivan:Van
    {

        public int _cargo_Net;
        public int dual_Sliding_Doors;

        public void SetCargoNet(int k)
        {
            this._cargo_Net = k;
        }

        public void SetDualSlidingDoors(int l)
        {
            this.dual_Sliding_Doors = l;
        }
        public void miniVan(string y)
        {
            Console.WriteLine(y);
        }
    }
}
