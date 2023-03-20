using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //high level module
    internal class Automobile1
    {
        private IAutomobile _automobile;

        public Automobile1(IAutomobile automobile)
        {
            _automobile = automobile;
        }

        public void DisplayWheels()
        {
            Console.WriteLine(_automobile.Wheels());
        }

    }

    //interface to get refrence from
    interface IAutomobile
    {
        string Wheels();
    }

    //low level module
    internal class Car1 : IAutomobile
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
    internal class Bike1 : IAutomobile
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
