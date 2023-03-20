using System;

namespace DIP
{
    class Program
    {
        public static void Main()
        {
            //Before DIP
            Console.WriteLine("Before DIP");

            //creating object of automobile class and calling methods
            //to display wheels of car and bike.
            //these methods are directly dependent on the child class objects
            Automobile automobile = new Automobile();
            automobile.DisplayWheelsCar();
            automobile.DisplayWheelsBike();
            
            Console.WriteLine("------------");

            //After DIP
            Console.WriteLine("After DIP");

            //creating object of automobile1 class and calling only one method DisplayWheels.
            //the method is not dependent on its child classes rather uses interface.
            Automobile1 automobile1 = new Automobile1(new Car1());
            automobile1.DisplayWheels();

            //creating new refrence for automobile1 using bike1 class object.
            automobile1 = new Automobile1(new Bike1());
            automobile1.DisplayWheels();
        }
    }
}