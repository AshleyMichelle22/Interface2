using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public double AmountOfWheels { get; set; }
        public int AmountOfSeats { get; set; }    

        public double AmountOfWindows { get; set; }
        public double NumberOfDoors { get; set; }
        public bool HasChangedGears { get; set; }
        // method below, has no scope bc its an interface
        public void Drive();
   
        public void park();
        public void ChangeGears(bool isChanged);
        public bool Reverse();
    }
}
