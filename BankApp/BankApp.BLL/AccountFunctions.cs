using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BLL
{
  public  class AccountFunctions
    {
      public static AccountFunctions NewAccount(string firstName, string lastName)
      {
          Account newAccount = new Account(firstName, lastName);

          newAccount.AccountID = AccountDatabase.AccountDictionary.Count + 1;
          return newAccount;


      }

      public void CloseAccount(Account currentAccount)
      {
          
      }

      public void FindAccount()
      {
          
      }


    }
}
