using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Default Year";
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";


        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Default Drive Virtual");
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Year: {Year} | Make: {Make} | Model: {Model}");
        }

    }
}
