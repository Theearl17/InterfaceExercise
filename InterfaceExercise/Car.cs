using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany 
    {
        public bool IsSedan {get; set; }
        public int MPG { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Tires { get; set; }
        public double TotalMiles { get; set; }
        public bool HasFuel { get; set; }
        public int Windows { get; set; }
        public string Logo { get; set; }
        public bool Warranty { get; set; }
        // Default//
        public Car()
        {

        }
        // Setting the members //
        public Car(bool isSedan, int mPG, string model, string make, int tires, double totalMiles, bool hasFuel, int windows, string logo, bool warranty)
        {
            IsSedan = isSedan;
            MPG = mPG;
            Model = model;
            Make = make;
            Tires = tires;
            TotalMiles = totalMiles;
            HasFuel = hasFuel;
            Windows = windows;
            Logo = logo;
            Warranty = warranty;
        }

        public string GoFast()
        {
            return "Vroom";
        }

        
    }
}
