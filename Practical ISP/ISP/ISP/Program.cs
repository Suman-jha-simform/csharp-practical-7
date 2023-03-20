using System;

namespace ISP
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Before ISP
            Console.WriteLine("Before ISP :");

            //creating lion class object and calling all the methods.
            Lion lion = new Lion();
            lion.Eat();
            lion.Roar();
            lion.Chrip();

            //creating sparrow class object and calling all the methods.
            Sparrow sparrow = new Sparrow();    
            sparrow.Eat();
            sparrow.Roar();
            sparrow.Chrip();

            Console.WriteLine("------------------------");
            //After ISP
            Console.WriteLine("\nAfter ISP");

            //creating lion2 class object and calling all the methods.
            //this class has only the methods that are important to it.
            Lion2 lion2 = new Lion2();
            lion2.Eat();
            lion2.Roar();

            //creating sparrow2 class object and calling all the methods.
            //this class has only the methods that are important to it.
            Sparrow2 sparrow2 = new Sparrow2();
            sparrow2.Eat();
            sparrow2.Chrip();

        }
    }
}