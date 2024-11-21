using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace NetCommon.Web.Authentication.CustomToken
{
    public class CustomTokenAuthenticationHandler : IAuthenticationHandler
    {
        private readonly ILogger<CustomTokenAuthenticationHandler> _logger;
        private AuthenticationScheme _scheme;
        private HttpContext _context;

        public CustomTokenAuthenticationHandler(ILogger<CustomTokenAuthenticationHandler> logger)
        {
            _logger = logger;
        }

        public Task InitializeAsync(AuthenticationScheme scheme, HttpContext context)
        {
            _scheme = scheme;
            _context = context;
            return Task.CompletedTask;
        }

        public Task<AuthenticateResult> AuthenticateAsync()
        {
            try
            {
                var authentication = _context.Request.Headers["Authorization"].FirstOrDefault();

                if (authentication is null)
                {
                    return Task.FromResult(AuthenticateResult.Fail(""));
                }

                var token = authentication.Substring(authentication.IndexOf(' ') + 1);

                // 校验 token
                if (TokenHandler.ValidateTokenExpired(token))
                {
                    return Task.FromResult(AuthenticateResult.NoResult());
                }

                UserIdentity userAccount = TokenHandler.GetUserInfoByAuth(token);

                var customIdentity = new CustomIdentity(userAccount, token, JakTokenDefaults.AuthenticationScheme, JwtClaimTypes.Name, JwtClaimTypes.Role);
                customIdentity.AddClaim(new Claim(JwtClaimTypes.Id, userAccount.UserID.ToString()));
                customIdentity.AddClaim(new Claim(JwtClaimTypes.Name, userAccount.UserName));
                customIdentity.AddClaim(new Claim(JwtClaimTypes.Role, userAccount.UserType.ToString()));

                var customPrincipal = new ClaimsPrincipal(customIdentity);

                //var claimsIdentity = new ClaimsIdentity(JakTokenDefaults.AuthenticationScheme, JwtClaimTypes.Name, JwtClaimTypes.Role);
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.Id, userAccount.UserID.ToString()));
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.Name, userAccount.UserName));
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.NickName, userAccount.NickName));
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.Role, userAccount.UserType.ToString()));
                //claimsIdentity.AddClaim(new Claim());

                return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(customPrincipal, JakTokenDefaults.AuthenticationScheme)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Task.FromResult(AuthenticateResult.Fail("Authenticate Failure!"));
            }
        }

        public Task ChallengeAsync(AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }

        public Task ForbidAsync(AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }
    }
}