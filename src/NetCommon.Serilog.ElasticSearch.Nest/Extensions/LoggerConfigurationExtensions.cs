using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using NetCommon.Serilog.Config;
using Serilog.Formatting.Json;
using Serilog.Sinks.Elasticsearch;
using Serilog.Sinks.File;

namespace NetCommon.Serilog.ElasticSearch.Nest.Extensions
{
    public static class LoggerConfigurationExtensions
    {
        /// <summary>
        /// 输出日志到 ElasticSearch
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="logToElasticSearch">ElasticSearch 配置</param>
        /// <returns></returns>
        public static LoggerConfiguration UseElasticNestSinks(this LoggerConfiguration configuration, LogToElasticSearch logToElasticSearch)
        {
            var elasticNodeUris = new List<Uri>() { new Uri(logToElasticSearch.HostUrl) };

            var singleNodeConnectionPool = new SingleNodeConnectionPool(new Uri(logToElasticSearch.HostUrl));

            return configuration
                .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(singleNodeConnectionPool)
                {
                    // ES连接配置
                    //ModifyConnectionSettings = cfg => cfg.BasicAuthentication(elasticSearchConfig.UserName, elasticSearchConfig.Password),
                    AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv6,
                    AutoRegisterTemplate = true,
                    EmitEventFailure = EmitEventFailureHandling.WriteToSelfLog | EmitEventFailureHandling.WriteToFailureSink,
                    FailureSink = new FileSink("./logs/elastic-log-.txt", new JsonFormatter(), 1024000, Encoding.UTF8),
                    IndexFormat = $"{logToElasticSearch.DataStreamType}-{logToElasticSearch.DataStreamDataSet}-{logToElasticSearch.DataStreamNameSpace}" + "-{0:yyyy.MM.dd}"
                });
        }
    }
}