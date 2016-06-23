using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data
{
   public class Account
    {
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }

        public Account() { }

       public Account(string firstName, string lastName)
       {
           FirstName = firstName;
           LastName = lastName;
           Balance = 0;

       }



    }
}
