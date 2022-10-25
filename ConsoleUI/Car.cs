using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public bool HasTrunk { get; set; }

        public bool CleanEnergy { get; set; }   

        public override void DriveAbstract()
        {
        }
    }  
}
