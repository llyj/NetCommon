using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NetCommon.Https
{
    public static class HttpContextExtension
    {
        /// <summary>
        /// 获取客户端Ip
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetClientIp(this HttpContext context)
        {
            if (context.Request.Headers.TryGetValue("X-Forwarded-For", out var xForwardFor))
            {
                return xForwardFor.ToString();
            }

            if (context.Request.Headers.TryGetValue("X-Real-IP", out var xRealIp))
            {
                return xRealIp.ToString();
            }

            if (context.Connection.RemoteIpAddress != null)
            {
                return context.Connection.RemoteIpAddress.ToString();
            }

            context.Request.Headers.TryGetValue("REMOTE_ADDR", out var RemoteAddr);

            return RemoteAddr.ToString();
        }

        public static bool IsLocalIp(this HttpContext context)
        {
            var contextConnection = context.Connection;
            if (contextConnection.RemoteIpAddress is not null)
            {
                if (contextConnection.LocalIpAddress is not null)
                {
                    return contextConnection.LocalIpAddress.Equals(contextConnection.RemoteIpAddress);
                }
                else
                {
                    return IPAddress.IsLoopback(contextConnection.RemoteIpAddress);
                }
            }

            if (contextConnection.LocalIpAddress is null && contextConnection.RemoteIpAddress is null)
            {
                return true;
            }

            return context.GetClientIp() is "127.0.0.1" or "::1";
        }
    }
}