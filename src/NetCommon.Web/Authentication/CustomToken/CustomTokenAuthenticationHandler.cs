using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        /// <summary>
        /// 身份认证逻辑
        /// <para>可在此处续签token</para>
        /// </summary>
        /// <returns></returns>
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
                //if (TokenHandler.ValidateTokenExpired(token))
                //{
                //    return Task.FromResult(AuthenticateResult.NoResult());
                //}

                // token 解密
                //ApplicationUser userAccount = TokenHandler.GetUserInfoByAuth(token);
                ApplicationUser user = null;

                var customIdentity = new CustomIdentity(CustomTokenDefaults.AuthenticationScheme, JwtClaimTypes.Name, JwtClaimTypes.Role)
                {
                    Token = token,
                    User = new ApplicationUser()
                    {
                    }
                };
                customIdentity.AddClaim(new Claim(JwtClaimTypes.Id, user.UserId.ToString()));
                customIdentity.AddClaim(new Claim(JwtClaimTypes.Name, user.UserName));
                customIdentity.AddClaim(new Claim(JwtClaimTypes.Role, user.UserRole ?? "Guest"));

                var customPrincipal = new ClaimsPrincipal(customIdentity);

                // 获取用户数据
                //(_context.User.Identity as CustomIdentity).User

                //var claimsIdentity = new ClaimsIdentity(JakTokenDefaults.AuthenticationScheme, JwtClaimTypes.Name, JwtClaimTypes.Role);
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.Id, userAccount.UserID.ToString()));
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.Name, userAccount.UserName));
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.NickName, userAccount.NickName));
                //claimsIdentity.AddClaim(new Claim(JwtClaimTypes.Role, userAccount.UserType.ToString()));
                //claimsIdentity.AddClaim(new Claim());

                return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(customPrincipal, CustomTokenDefaults.AuthenticationScheme)));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Task.FromResult(AuthenticateResult.Fail("Authenticate Failure!"));
            }
        }

        /// <summary>
        /// 未登录时处理
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        public Task ChallengeAsync(AuthenticationProperties? properties)
        {
            _context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            // 返回数据
            //_context.Response.WriteAsJsonAsync()
            return Task.CompletedTask;
        }

        /// <summary>
        /// 权限不足时处理
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        public Task ForbidAsync(AuthenticationProperties? properties)
        {
            _context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            return Task.CompletedTask;
        }
    }
}