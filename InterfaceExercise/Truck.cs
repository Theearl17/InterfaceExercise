using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasSnorkel { get; set; }
        public int MPG { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Tires { get; set; }
        public double TotalMiles { get; set; }
        public bool HasFuel { get; set; }
        public int Windows { get; set; }
        public string Logo { get; set; }
        public bool Warranty { get; set; }

        public string GoOffRoad ()
        {
            return "Go off road";
        }


        public void DisplayTruck()
        {
            Console.WriteLine($" This {Make},{Model} truck has {Windows} new windows. It is {HasSnorkel} that Snorkel is operative.");
        }







    }
        
   



}



