namespace OpenRastaDigestDemo.Domain
{
    public class Account
    {
        public decimal Balance { get; private set; }
        public string AccountHolder { get; private set; }

        public Account(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }
    }
}