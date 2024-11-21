using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;

namespace NetCommon.AOP
{
    /// <summary>
    /// 日志AOP
    /// </summary>
    public class LogAOP : IInterceptor
    {
        private readonly MethodInfo _awaitResult = typeof(LogAOP).GetMethod("AwaitResult", BindingFlags.NonPublic | BindingFlags.Instance)!;

        private readonly ILoggerFactory _loggerFactory;
        private ILogger _logger;

        public LogAOP(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public async void Intercept(IInvocation invocation)
        {
            _logger = _loggerFactory.CreateLogger(invocation.TargetType);

            try
            {
                invocation.Proceed();
                var methodReturnType = invocation.Method.ReturnType;

                if (methodReturnType == typeof(Task))
                {
                    invocation.ReturnValue = Await((Task)invocation.ReturnValue);
                }
                else if (methodReturnType.IsGenericType && methodReturnType.GetGenericTypeDefinition() == typeof(Task<>))
                {
                    //await (Task)invocation.ReturnValue;
                    invocation.ReturnValue = _awaitResult.MakeGenericMethod(methodReturnType.GenericTypeArguments[0])
                        .Invoke(this, new[] { invocation.ReturnValue });
                }
                else
                {
                    //同步操作
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, ex.Message, invocation.Arguments);
                throw;
            }
        }

        private async Task Await(Task task)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        private async Task<T> AwaitResult<T>(Task<T> returnResult)
        {
            try
            {
                return await returnResult;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}