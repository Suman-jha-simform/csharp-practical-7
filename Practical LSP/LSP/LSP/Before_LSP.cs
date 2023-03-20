using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Bird
    {
        /// <summary>
        /// This method prints the voice of the bird.The method is virtual and can be overridden.
        /// </summary>
        /// <returns>void</returns>
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }

    internal class Duck : Bird
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
