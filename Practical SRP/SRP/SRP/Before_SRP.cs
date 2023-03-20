using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SRP
{
    internal class EmailServices
    {

        /// <summary>
        /// This methods sends the email to the user.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void SendEmail(string email)
        {
            if (ValidateEmail(email))
            {
                // send email
                Register(email);
                Console.WriteLine("Email has been sent to your register mail id.");

            }
            else
            {
                Console.WriteLine("Invalid Email");
            }

        }


        /// <summary>
        /// This methods validates the email the user has entered.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public bool ValidateEmail(string email)
        {
            string emailRegex = @"[a-zA-Z0-9]+(.|_)[a-zA-Z0-9]+\@[a-zA-Z]{5}(.)[a-zA-Z]{3}";
            Regex rg = new Regex(emailRegex);
            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// This methods register the user in the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void Register(string email)
        {
            string query = $"insert into user (email) value({email})";
            Console.WriteLine("User Registered Successfully ");
            //execute the query
        }

    }
}
