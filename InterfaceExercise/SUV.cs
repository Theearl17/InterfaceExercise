using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int MPG { get; set; }
        public bool HasV8 { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Tires { get; set; }
        public double TotalMiles { get; set; }
        public bool HasFuel { get; set; }
        public int Windows { get; set; }
        public string Logo { get; set; }
        public bool Warranty { get; set; }

        public SUV()
        {
            
        }

        public SUV(int mPG, bool hasV8, string model, string make, int tires, double totalMiles, bool hasFuel, int windows, string logo, bool warranty)
        {
            MPG = mPG;
            HasV8 = hasV8;
            Model = model;
            Make = make;
            Tires = tires;
            TotalMiles = totalMiles;
            HasFuel = hasFuel;
            Windows = windows;
            Logo = logo;
            Warranty = warranty;
        }

        public void DisplaySUVInformation()
        {
            Console.WriteLine($" This {Make}, {Model} SUV has {Tires} new tires. {HasV8} that it has v8 and gets {MPG} MPG." );
        }


        public int MilesPerGallon ()
        {
            return MPG;
        }
    }
}
