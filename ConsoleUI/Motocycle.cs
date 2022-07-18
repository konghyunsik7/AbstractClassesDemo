using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motocycle : Vehicle

    {   
        public override void DriveAbstract()
        {
            Console.WriteLine("This motocyle is in Drive");
        }
        public bool HasSideCart { get; set; } = false;

        public string Handles { get; set; } = "black";

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcyle Drive Vitrual");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"| {HasSideCart} | {Handles}");
        }
    }
}
