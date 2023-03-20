using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //class inheriting Animal interface are forced to implement all its method
    interface Animal
    {
        void Eat();
        void Roar();
        void Chrip();
    }

    //class lion forced to implement chrip method
    class Lion : Animal
    {
        /// <summary>
        /// This methods prints the food of lion.
        /// </summary>
        /// <returns>void</returns>
        public void Eat()
        {
            Console.WriteLine("Lion eats flesh");
        }

        /// <summary>
        /// This methods prints the voice of lion.
        /// </summary>
        /// <returns>void</returns>
        public void Roar()
        {
            Console.WriteLine("Lion Roars : rrrr rrrr");
        }

        /// <summary>
        /// This methods prints whether lion chrips or not.
        /// </summary>
        /// <returns>void</returns>
        public void Chrip()
        {
            Console.WriteLine("Lion do not chrips\n");
        }


    }

    //class sparrow forced to implement roar method
    class Sparrow : Animal
    {
        /// <summary>
        /// This methods prints the eating habit of sparrow.
        /// </summary>
        /// <returns>void</returns>
        public void Eat()
        {
            Console.WriteLine("Sparrow eats insects");
        }

        /// <summary>
        /// This methods prints the whather sparrow roars or not.
        /// </summary>
        /// <returns>void</returns>
        public void Roar()
        {
            Console.WriteLine("Sparrow does not Roars");
        }

        /// <summary>
        /// This methods prints the voice of the sparrow.
        /// </summary>
        /// <returns>void</returns>
        public void Chrip()
        {
            Console.WriteLine("Sparrow  chrips : chi chi");
        }
    }
}
