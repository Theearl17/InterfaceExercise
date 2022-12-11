using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myFirstCar = new Car();
            myFirstCar.HasFuel = true;
            myFirstCar.Windows = 6;
            myFirstCar.Make = "ford";
            myFirstCar.MPG = 5;
            myFirstCar.Tires = 4;
            myFirstCar.IsSedan = true;
            myFirstCar.Model = "Fastback";
            myFirstCar.TotalMiles = 5000;
            myFirstCar.Logo = "Horse";
            myFirstCar.Warranty= true;

           Car braydonsCar = new Car(true, 32, "Ford", "Exp", 4, 60000, false, 4, "ram", true);

           SUV mySUV= new SUV(20, true, "Ford", "Exp", 4, 60000, true, 6, "ram", true);

            Truck myTruck = new Truck();
            myTruck.HasSnorkel = false;
            myTruck.MPG = 15;
            myTruck.Model = "Trex";
            myTruck.Make = "Tesla";
            myTruck.Tires = 4;
            myTruck.TotalMiles = 4500;
            myTruck.HasFuel = true;
            myTruck.Windows = 6;
            myTruck.Logo = " Goofy Looking T";
            myTruck.Warranty = true;


            IVehicle.Call(SUV);



        //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

        //Create 2 Interfaces called IVehicle & ICompany
        //DONEEEEEEEEE

        //Create 3 classes called Car , Truck , & SUV
        //DONEEEEEEEEEEE

        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */
        //DONEEEEEEEEEEEE

        //In ICompany

        /*Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         * 

         */
        // DONEEEEEEEEEEEE


        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        //DONEEEEEEEEEEEEEE

        //Now, create objects of your 3 classes and give their members values;
        //Creatively display and organize their values

        //Doneeee???
    }
    }
}
