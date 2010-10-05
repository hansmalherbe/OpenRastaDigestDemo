using OpenRasta.Security;
using OpenRastaDigestDemo.Domain;

namespace OpenRastaDigestDemo.Security
{
    public class AccountDigestAuthenticationProvider : IAuthenticationProvider
    {
        private readonly IUserCredentials _users;

        public AccountDigestAuthenticationProvider(IUserCredentials users)
        {
            _users = users;
        }

        public Credentials GetByUsername(string username)
        {
            return _users.GetCredentialsFor(username);
        }
    }
}