using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace EasyBom.DataCenter.HttpApi.Attribute
{
    public class CustomLoggingAttribute : LoggingFilterAttribute
    {
        protected override Task WriteLogAsync(ApiResponseContext context, LogMessage logMessage)
        {
            return base.WriteLogAsync(context, logMessage);
        }
    }
}