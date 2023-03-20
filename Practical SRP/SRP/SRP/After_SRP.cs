using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SRP
{
    internal class EmailServicesM
    {
        private CRUD _crudOperations;

        public EmailServicesM() {
            _crudOperations = new CRUD();
        }

        /// <summary>
        /// This methods sends the email to the user after email validation.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void SendEmail(string email)
        {
            if (ValidateEmail(email))
            {
                // send email
                _crudOperations.Register(email);
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
    }


    internal class CRUD
    {
        /// <summary>
        /// This methods register the user in the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void Register(string email)
        {
            string query = $"insert into user (email) value({email})";
            //execute the query
            Console.WriteLine("User Registered Successfully. ");
        }

        /// <summary>
        /// This methods reads the detail of user from the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void Read(string email)
        {
            string query = $"select * from user where email = {email})";
            //execute the query
            Console.WriteLine("Details of User.");
        }


        /// <summary>
        /// This methods updates the user detail in the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void Update(string email)
        {
            string query = $"update user set email = {email} where email = {email}";
            //execute the query
            Console.WriteLine("User email updated successfully. ");
        }

        /// <summary>
        /// This methods delets the user from the database.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>void</returns>
        public void Delete(string email)
        {
            string query = $"delete from user where email = {email})";
            //execute the query
            Console.WriteLine("User acccount deleted .");

        }
    }
}
