using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NetCommon.Web.Authentication.CustomToken
{
    public class CustomIdentity : ClaimsIdentity
    {
        /// <summary>
        /// 令牌
        /// </summary>
        public string Token { get; set; }

        public ApplicationUser User { get; set; }

        public CustomIdentity(string? authenticationType, string? nameType, string? roleType) : base(authenticationType, nameType, roleType)
        {
        }
    }
}