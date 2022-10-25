using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }  
        
        public int HighestSpeed { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle loves abstract art.");
        }
        public override void DriveVirtual() 
        { throw new NotImplementedException(); }
        
    }  

}
