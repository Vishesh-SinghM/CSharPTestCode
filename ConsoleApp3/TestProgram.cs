using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TestProgram
    {

        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Car c = new Car();
            SportsCar sc = new SportsCar();
            Van vn = new Van();
            ExcursionVan exv = new ExcursionVan();
            Minivan mvn = new Minivan();

            v.Make = "Maruti";
            v.Model = "Swift";
            v.Year = 1992;
            Console.WriteLine("My care is make by: {0}",v._make);
            Console.WriteLine("My care model is : {0}", v._model);
            Console.WriteLine("My care is made in year : {0}", v._year);
            v.VehicleM("I am a vehicle class method");
            c.CarClass();
            sc.SportsCarClass();
            vn.vanClass();
            exv.excursionVanClass();
            mvn.SetCargoNet(10);
            mvn.SetDualSlidingDoors(2);
            Console.WriteLine("Net Cargo In My Mini Van is: {0}",mvn._cargo_Net);
            Console.WriteLine("Number of Dual Sliding Doors in My Mini Van is: {0}", mvn.dual_Sliding_Doors);
            mvn.miniVan("I am a minivan class method inheriting Van Class");
            Console.ReadKey();
        }
    }
}
