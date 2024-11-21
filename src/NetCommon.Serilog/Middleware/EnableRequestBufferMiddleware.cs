using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace NetCommon.Serilog.Middleware
{
    /// <summary>
    /// 开启请求缓冲
    /// </summary>
    public class EnableRequestBufferMiddleware
    {
        private readonly RequestDelegate _next;

        public EnableRequestBufferMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 开启请求缓冲，确保能多次读取请求体
            context.Request.EnableBuffering();

            await _next(context);

            // 重置请求体流
            //context.Request.Body.Position = 0;
            //context.Request.Body.Seek(0, SeekOrigin.Begin);
        }
    }
}