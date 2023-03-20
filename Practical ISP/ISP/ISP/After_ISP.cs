using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //we have nowe segreggated the interfaces 
    interface Animal1
    {
        void Eat();
    }

    interface Lion1
    {
        void Roar();
    }

    interface Sparrow1
    {
        void Chrip();
    }

    //implementing interfaces that are useful for Lion
    class Lion2 : Animal1, Lion1
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
            Console.WriteLine("Lion Roars : rrrrr rrrrr\n");
        }
    }

    //implementing interfaces that are useful for Sparrow
    class Sparrow2 : Animal1, Sparrow1
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
        /// This methods prints the voice of the sparrow.
        /// </summary>
        /// <returns>void</returns>
        public void Chrip()
        {
            Console.WriteLine("Sparrow  chrips : chiii chiii");
        }
    }
}
