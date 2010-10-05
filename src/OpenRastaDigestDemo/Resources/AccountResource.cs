using OpenRastaDigestDemo.Domain;

namespace OpenRastaDigestDemo.Resources
{
    public class AccountResource
    {
        public decimal Balance { get; private set; }
        public string AccountHolder { get; private set; }

        public AccountResource(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public AccountResource(Account account)
        {
            Balance = account.Balance;
            AccountHolder = account.AccountHolder;
        }
    }
}