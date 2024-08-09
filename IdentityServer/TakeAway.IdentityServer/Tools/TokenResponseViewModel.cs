using System;

namespace TakeAway.IdentityServer.Tools
{
    public class TokenResponseViewModel
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }

        public TokenResponseViewModel(string token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }
    }
}
