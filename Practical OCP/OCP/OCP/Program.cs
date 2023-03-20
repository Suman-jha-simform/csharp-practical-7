using System;

namespace OCP
{
    class OCP
    {
        public static void Main()
        {
            //Before OCP
            //we need to create object of Account class everytime we have different account types
            Console.WriteLine("Before OCP ");

            Account account = new Account("Business");
            Console.WriteLine(account.accountType);

            Account account1 = new Account("Personal");
            Console.WriteLine(account1.accountType);

            Account account2 = new Account("Blog");
            Console.WriteLine(account2.accountType);
            Console.WriteLine("---------------------");


            //After OCP
            //We do not need to create accounts class for different account types
            Console.WriteLine("After OCP");
            Business business = new Business();
            Console.WriteLine(business.GetAccountType());

            Personal personal = new Personal();
            Console.WriteLine(personal.GetAccountType());

            Blog blog = new Blog();
            Console.WriteLine(blog.GetAccountType());
        }
    }
}