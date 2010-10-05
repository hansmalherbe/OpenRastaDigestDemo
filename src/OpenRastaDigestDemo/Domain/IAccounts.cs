namespace OpenRastaDigestDemo.Domain
{
    public interface IAccounts
    {
        Account GetForUser(string username);
    }
}