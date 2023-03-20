using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal abstract class Aves
    {
        /// <summary>
        /// This method is an abstract method for voice and must be implemented in the child class.
        /// </summary>
        /// <returns>void</returns>
        public abstract void Voice();
    }

    internal class Bird1 : Aves
    {
        /// <summary>
        /// This method prints the voice of the bird.The is a overridden method.
        /// </summary>
        /// <returns>void</returns>
        public override void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }

    internal class Duck1 : Aves
    {
        /// <summary>
        /// This method prints the voice of the duck.The is a overridden method.
        /// </summary>
        /// <returns>void</returns>
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
