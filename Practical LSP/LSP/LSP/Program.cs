using System;

namespace LSP
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Before using LSP");
            //creating parent refrence using child constructor
            //the properties of parent are overridden in the child
            Bird bird = new Duck();
            bird.Voice();
            Duck duck = new Duck();
            duck.Voice();

            //after using LSP 
            Console.WriteLine("\nAfter using LSP :");
            //creating refrence of parent using first child constructor
            //the properties of Bird class in not overridden
            Aves bird1 = new Bird1();
            bird1.Voice();
            //creating new refrence for parent using second child constructor
            bird1 = new Duck1();
            bird1.Voice();
        }
    }
}