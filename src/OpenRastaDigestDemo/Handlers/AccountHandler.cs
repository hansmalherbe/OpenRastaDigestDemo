using OpenRasta.Security;
using OpenRasta.Web;
using OpenRastaDigestDemo.Domain;

namespace OpenRastaDigestDemo.Handlers
{
    /// <summary>
    /// Force the user to provide authentication for ALL operations on this handler
    /// </summary>
    [RequiresAuthentication]
    public class AccountHandler
    {
        private readonly IAccounts _accounts;

        // will be injected by the IoC built in to openrasta
        public ICommunicationContext Context { get; set; }

        // OpenRasta will inject these dependancies
        public AccountHandler(IAccounts accounts)
        {
            _accounts = accounts;
        }

        public OperationResult Get()
        {
            // get the account for the logged in user
            var username = Context.User.Identity.Name;
            var account = _accounts.GetForUser(username);

            var accountResource = new AccountResource(account);

            if (account == null)
                return new OperationResult.NotFound();

            // return their bank account balance
            return new OperationResult.OK(account);
        }
    }
}