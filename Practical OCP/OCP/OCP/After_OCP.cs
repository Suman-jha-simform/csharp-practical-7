using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Accounts
    {
        string? _accountType;

        public Accounts(string accounttype)
        {
            this._accountType = accounttype;
        }

        public string GetAccountType()
        {
            return this._accountType;
        }
    }

    // business account
    internal class Business : Accounts
    {
        static string _accountType = "Business";
        public Business(): base(_accountType)
        {
            
        }
    }

    //personal account
    internal class Personal : Accounts
    {

        static string _accountType = "Personal";
        public Personal() : base(_accountType)
        {

        }
    }

    // blog account
    internal class Blog : Accounts
    {
        static string _accountType = "Blog";
        public Blog() : base(_accountType)
        {

        }
    }


}
