using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Serilog;

namespace NetCommon.Serilog.Enricher
{
    public static class LogEnricher
    {
        /// <summary>
        /// Http 请求日志丰富器
        /// </summary>
        /// <param name="diagnosticContext">Serilog diagnostic context</param>
        /// <param name="httpContext">当前 HTTP 上下文</param>
        public static void EnrichFromRequest(IDiagnosticContext diagnosticContext, HttpContext httpContext)
        {
            var request = httpContext.Request;

            // 记录IP
            //diagnosticContext.Set("client.ip", request.Headers["X-Forwarded-For"].FirstOrDefault() ?? httpContext.Connection.RemoteIpAddress.ToString()); // elastic日志标准输出
            diagnosticContext.Set("ClientIP", request.Headers["X-Forwarded-For"].FirstOrDefault() ?? httpContext.Connection.RemoteIpAddress.ToString());
            // 记录UA
            diagnosticContext.Set("UserAgent", request.Headers["User-Agent"].FirstOrDefault());
            // 记录请求链接
            diagnosticContext.Set("RequestUrl", request.GetDisplayUrl());

            // 记录请求体数据
            if (request.ContentLength != null && request.ContentLength > 0)
            {
                request.Body.Position = 0;

                // 读取请求体
                using StreamReader reader = new(
                    request.Body,
                    encoding: Encoding.UTF8,
                    detectEncodingFromByteOrderMarks: false);

                string body = reader.ReadToEndAsync().Result;
                diagnosticContext.Set("RequestBody", body);

                request.Body.Position = 0;
            }

            //var response = httpContext.Response;
            // 记录请求响应数据
            /*if (response.ContentLength != null && response.ContentLength > 0)
            {
                var responseBody = new StreamReader(response.Body, Encoding.UTF8).ReadToEndAsync().Result;
                diagnosticContext.Set("ResponseBody", responseBody);
            }*/

            //diagnosticContext.Set("Resource", httpContext.GetMetricsCurrentResourceName());
        }
    }
}