using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   
    public class Car : IVehicle, ICompany //class //blue print
    {
        public Car()
        {
        
        }
        // property
        public double AmountOfWheels { get; set; } = 4.0;
        public int AmountOfSeats { get; set; } = 6;
        public double AmountOfWindows { get; set; } = 6.0;
        public double NumberOfDoors { get; set; } = 4.0;
        public string Name { get; set; } = "Toyota";
        public string Logo { get; set; } = "Never Dies";
        public bool HasChangedGears { get; set; }
        public bool HasReverse { get; set; }
        public bool HasTrunk { get; set; }
        public void Drive() //stubbed out
        {
            Console.WriteLine($"The {GetType().Name} is now drving forward. . .");
        }
        public bool Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now in reverse. . .");
                HasReverse = true;
            }
            else
            {
                Console.WriteLine("Can reverse when you change gears");
                HasReverse = false; 
            }
                return HasReverse;

        }
           
       public void park() 
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now in park. . .");
                HasChangedGears |= false;
            }
            else
            {
                Console.WriteLine("Can reverse when you change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged; 
        }

       
    }
}
