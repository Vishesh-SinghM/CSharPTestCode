using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Vehicle
    {
        public string _make;
        public string _model;
        public int _year;

        public string Make
        {
            set { _make = value; }
            get { return _make; }
        }

        public string Model
        {
            set { _model = value; }
            get { return _model; }
        }

        public int Year
        {
            set { _year = value; }
            get { return _year; }
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerate speed Displaying");
        }

        public void Decelerate()
        {
            Console.WriteLine("Decelerate speed Displaying");
        }

        public void Drive()
        {
            Console.WriteLine("Going to start Drive");
        }

        public void Start()
        {
            Console.WriteLine("Driving is start");
        }

        public void Stop()
        {
            Console.WriteLine("Driving is stop");
        }

        public void VehicleM(string d)
        {
            Console.WriteLine(d);
        }
    }

   

 }
