using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany //classes
    {
        

        public SUV()
        {

        }

        public double AmountOfWheels { get; set; } = 4.0;
        public int AmountOfSeats { get; set; } = 8;
        public double AmountOfWindows { get; set; } = 8.0;
        public double NumberOfDoors { get; set; } = 5.0;
        public string Name { get; set; } = "Chevy";
        public string Logo { get; set; } = "Long Lasting";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public bool FitsEightPeople { get; set; }
        public bool HasFitEightPeople { get; set; }


        public void Drive()
        {
            if (HasFourWheelDrive == true)
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

        public void Park()
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
        public void HasFitsEightPeople()
        {
            if (FitsEightPeople == true)
            {
                Console.WriteLine($"The {GetType().Name} SUV fits 8 people. . .");
                FitsEightPeople = false;
            }
            else
            {
                Console.WriteLine("SUV fits only 6");
            }


        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void HasFitsEightPeople(bool isFitsEightPeople)
        {
            FitsEightPeople = isFitsEightPeople;
        }

        public void park()
        {
            throw new NotImplementedException();
        }
    }
}






















