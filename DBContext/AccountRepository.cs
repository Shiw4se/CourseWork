using System.Collections.Generic;
using Accounts;


namespace CourseWork.DBContexts
{
    public class AccountRepository
    {
        public List<Account> Accounts;

        public AccountRepository()
        {
            Accounts = new List<Account>();
        }
        
        public Account CreatePlayerAccountRep(string username,string password)
        {
            return new Account(username, password);
        }
        
        
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }
    }
}