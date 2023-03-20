using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //High level module
    internal class Automobile
    {

        /// <summary>
        /// This method displays the wheels of car.
        /// </summary>
        /// <returns>void</returns>
        public void DisplayWheelsCar()
        {
            Car car = new Car();
            Console.WriteLine(car.Wheels());
        }

        /// <summary>
        /// This method displays the wheels of bike.
        /// </summary>
        /// <returns>void</returns>
        public void DisplayWheelsBike()
        {
            Bike bike = new Bike();
            Console.WriteLine(bike.Wheels());
        }

    }

    //low level module
    internal class Car
    {
        /// <summary>
        /// This method displays the wheels of car.
        /// </summary>
        /// <returns>void</returns>
        public string Wheels()
        {
            return "4 wheeler";
        }
    }

    //low level module
    internal class Bike
    {
        /// <summary>
        /// This method displays the wheels of bike.
        /// </summary>
        /// <returns>void</returns>
        public string Wheels()
        {
            return "2 wheeler";
        }
    }
}
