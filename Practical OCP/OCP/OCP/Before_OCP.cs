using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Account
    {
        internal string? accountType;

        public Account(string accountType)
        {
            if (accountType == "Business")
            {
                this.accountType = accountType;

            }
            else if (accountType == "Personal")
            {
                this.accountType = accountType;
            } 
            else if(accountType == "Blog")
            {
                this.accountType = accountType;
            }
        }
    }
}
