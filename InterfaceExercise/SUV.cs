﻿using System;
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

        public int MilesPerGallon ()
        {
            return MPG;
        }
    }
}