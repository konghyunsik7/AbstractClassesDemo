using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle X
             * The vehicle class shall have three string properties Year, Make, and Model x
             * Set the defaults to something generic in the Vehicle class x
             * Vehicle shall have an abstract method called DriveAbstract with no implementation x
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. x
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle x
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle x
             * Provide the implementations for the abstract methods x
             * Only in the Motorcycle class will you override the virtual drive method x
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            //List<Vehicle> vehicles = new();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var car1 = new Car()
            {
                Year = "5000",
                Make = "Tesla",
                Model = "D",
                HasTrunk = true,
                NumberOfDoors = 6
            };

            var motorcyle1 = new Motocycle()
            {
                Year = "2050",
                Make = "IDK",
                Model = "SOMETHING SUPER FAST",
                HasSideCart = true,
                Handles = "YELLOW"
            };

            Vehicle vehicle1 = new Car()
            {
                Year = "1234",
                Make = "Genisis",
                Model = "G80",
                HasTrunk = true,
                NumberOfDoors = 4

            };
            Vehicle vehicle2 = new Motocycle()
            {
                Year = "2023",
                Make = "YOYO",
                Model = "DAYUMMMM",
                HasSideCart = false,
                Handles = "Rainbow"
            };

            vehicles.Add(car1);
            vehicles.Add(motorcyle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var items in vehicles)
            {
                items.PrintInfo();
                

            items.DriveAbstract();
            Console.WriteLine();
            items.DriveVirtual();
            Console.WriteLine();

          
            }
           

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
