using System.Collections.Generic;
using System.Linq;
using OpenRasta.Security;

namespace OpenRastaDigestDemo.Domain
{
    /// <summary>
    /// Faked source of user details, no database involved
    /// </summary>
    public class UserCredentials : IUserCredentials
    {
        private List<Credentials> _users;

        public UserCredentials()
        {
            _users = new List<Credentials>();
            _users.Add(new Credentials { Username = "david", Password = "david-pass" });
            _users.Add(new Credentials { Username = "fred", Password = "fred-pass" });
            _users.Add(new Credentials { Username = "bob", Password = "bob-pass" });
        }

        public Credentials GetCredentialsFor(string username)
        {
            return _users.SingleOrDefault(c => c.Username == username);
        }
    }
}