using SRP;
using System;

namespace ProgramSRP
{
    class SRP
    {
        public static void Main()
        {
            //Before SRP
            //the emailservice class has register method , making it multipurpose
            EmailServices emailServices = new EmailServices();
            Console.WriteLine("Before SRP. ");
            Console.WriteLine("Enter your email to register : ");
            string email = Console.ReadLine()!;
            emailServices.SendEmail(email);

            Console.WriteLine("---------------------------");

            //After SRP
            //here in the emailservicesm class their is only functionality related to emails
            //for register operation it makes use of the crud class 
            EmailServicesM emailServices1 = new EmailServicesM();
            Console.WriteLine("\nAfter SRP .");
            Console.WriteLine("Enter your email to register : ");
            string email1 = Console.ReadLine()!;
            emailServices1.SendEmail(email1);
        }
    }
}