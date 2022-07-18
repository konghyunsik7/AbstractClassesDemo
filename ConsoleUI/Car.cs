using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in Drive");
        }
        public bool HasTrunk { get; set; } = false;
        
        public int NumberOfDoors { get; set; } = 0;

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"| {HasTrunk} | {NumberOfDoors}");
        }
    }
}
