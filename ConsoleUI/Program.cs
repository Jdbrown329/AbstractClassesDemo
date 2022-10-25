using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
             * Create an abstract class called Vehicle- DONE
             * The vehicle class shall have three string properties Year, Make, and Model- done
             * Set the defaults to something generic in the Vehicle class- done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation- done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.- done 
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle- done 
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle- done 
             * Provide the implementations for the abstract methods- done 
             * Only in the Motorcycle class will you override the virtual drive method- done
            */

          var vehicles = new List<Vehicle>();




            // Create a list of Vehicle called vehicles

            Vehicle motorcycle1 = new Motorcycle()
            {
                Year= 1997,
                Make= "Hyundai",
                Model="speedster",
                HasSidecar=false,
                HighestSpeed=100
            };

            Vehicle car1 = new Car()
            {
                Year= 2016,
                Make= "Toyota",
                Model="Camry",
                CleanEnergy=true,
                HasTrunk=true,
            };

            Vehicle vehicles3 = new Car()
            {
                Year = 1999,
                Make = "Buick",
                Model = "Century",
                CleanEnergy = false,
                HasTrunk = true,
            };

            Vehicle vehicles4 = new Motorcycle()
            {
                Year = 1999,
                Make = "Buick",
                Model = "Century",
                HasSidecar = false,
                HighestSpeed = 100
            };
            


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            vehicles.Add(motorcycle1);
            vehicles.Add(car1);
            vehicles.Add(vehicles3);
            vehicles.Add(vehicles4);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             * 
             */
            foreach ( var vehicle in vehicles)
            {
                Console.WriteLine($"Year:{vehicle.Year}");
                Console.WriteLine($"Make:{vehicle.Make}");
                Console.WriteLine($"Model:{vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
