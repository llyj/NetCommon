using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NetCommon.Web.Authentication.CustomToken
{
    public class ApplicationUser : IdentityUser
    {
        public Guid UserId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string? NickName { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastSignInTime { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public string? UserRole { get; set; }

        /// <summary>
        /// 多个角色
        /// </summary>
        public List<string>? UserRoleList { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// 令牌过期时间
        /// </summary>
        public DateTime? TokenExpiredTime { get; set; }
    }
}