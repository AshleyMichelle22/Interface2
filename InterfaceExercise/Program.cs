using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -done

            //Create 3 classes called Car , Truck , & SUV -done

            //In your IVehicle -done

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - done

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - almost done

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            //instansiating below , because classes are blueprints.
            //instansiate is putting furntire in the house
            // type IVehicle/ICompany
            Car car1 = new Car() { AmountOfSeats = 6, AmountOfWheels = 4, HasTrunk = true };
            
            
            // set properties of instance

            
            Truck truck1 = new Truck();
            truck1.AmountOfSeats = 6;
            truck1.AmountOfWheels = 4;
            truck1.AmountOfWindows = 4;





             // dot notation
            SUV sUV1 = new SUV();
            sUV1.AmountOfWindows = 6;
            sUV1.AmountOfSeats = 4;
            sUV1.AmountOfWheels = 4;
            


            //instatiate list
            List<IVehicle> listOfVehicles = new List<IVehicle>(); //  {car1, truck1, sUV1}; can be added instead
            // of this
            listOfVehicles.Add(car1);
            listOfVehicles.Add(truck1);
            listOfVehicles.Add(sUV1);
           

            //add instance of your vehicles to this list
            //loop through list with a foreach loop
            //display property members in scope of foreach loop

            foreach (var v in listOfVehicles)
            {
                Console.WriteLine($"Amount of wheels{v.AmountOfWindows}");
                Console.WriteLine($"Number of doors{v.NumberOfDoors}");
                Console.WriteLine($"Amount of seats{v.AmountOfSeats}");
                Console.WriteLine($"Amount of windows{v.AmountOfWindows}");


                Console.WriteLine(); // makes space in between
                Console.WriteLine();

                // not printing make and model bc i didnt add make and model = blah :(

            } 
               

        }
    }
}
