using System.Collections.Generic;
using System.Linq;

namespace OpenRastaDigestDemo.Domain
{
    /// <summary>
    /// Faked source of account details, no database involved
    /// </summary>
    public class Accounts : IAccounts
    {
        private List<Account> accounts;

        public Accounts()
        {
            accounts = new List<Account>();
            accounts.Add(new Account("david", 100.00m));
            accounts.Add(new Account("fred", 150.00m));
            accounts.Add(new Account("geoff", 200.00m));
        }

        public Account GetForUser(string username)
        {
            return accounts.SingleOrDefault(a => a.AccountHolder == username);
        }
    }
}