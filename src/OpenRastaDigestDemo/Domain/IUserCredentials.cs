using OpenRasta.Security;

namespace OpenRastaDigestDemo.Domain
{
    public interface IUserCredentials
    {
        Credentials GetCredentialsFor(string username);
    }
}