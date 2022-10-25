using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } 
        public string Make { get; set; }    
        public string Model { get; set; }   

        public abstract void DriveAbstract(); 

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I like to drive my Car in cyberland");
        }

    }
}
