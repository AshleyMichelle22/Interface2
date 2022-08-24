using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany   //classes
    {
        public Truck()
        {

        }

        public double AmountOfWheels { get; set; } = 4.0;
        public int AmountOfSeats { get; set; } = 4;
        public double AmountOfWindows { get; set; } = 6.0;
        public double NumberOfDoors { get; set; } = 4.0;
        public string Name { get; set; } = "Toyota";
        public string Logo { get; set; } = "Never Dies";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public void Drive()//stubbed out
        {   if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} is now drving forward. . .");

            }
            
            else
            {

                Console.WriteLine($"{GetType().Name} truck is now drving forward. . .");
            }
        }
        public bool Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now in reverse. . .");
                HasChangedGears = false;
                return HasChangedGears;
            }
            else
            {
                Console.WriteLine("Can reverse when you change gears");
                return HasChangedGears;
            }


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



    

