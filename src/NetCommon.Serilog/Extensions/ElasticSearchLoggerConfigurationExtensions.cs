using Elastic.Ingest.Elasticsearch;
using Elastic.Serilog.Sinks;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elastic.Channels;
using Elastic.CommonSchema.Serilog;
using Elastic.Ingest.Elasticsearch.DataStreams;
using Elastic.Transport;
using NetCommon.Serilog.Config;

namespace NetCommon.Serilog.Extensions
{
    public static class ElasticSearchLoggerConfigurationExtensions
    {
        /// <summary>
        /// 输出日志到 ElasticSearch
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="logToElasticSearch">ElasticSearch 配置</param>
        /// <returns></returns>
        public static LoggerConfiguration UseElasticSinks(this LoggerConfiguration configuration, LogToElasticSearch logToElasticSearch)
        {
            var elasticNodeUris = new List<Uri>() { new Uri(logToElasticSearch.HostUrl) };

            return configuration
                .WriteTo.Elasticsearch(elasticNodeUris, opts =>
                {
                    opts.DataStream = new DataStreamName(logToElasticSearch.DataStreamType, logToElasticSearch.DataStreamDataSet, logToElasticSearch.DataStreamNameSpace);
                    opts.BootstrapMethod = BootstrapMethod.Failure;
                    opts.ConfigureChannel = channelOpts =>
                    {
                        channelOpts.BufferOptions = new BufferOptions
                        {
                            // 最大并发数?
                            ExportMaxConcurrency = 10
                        };
                    };
                }, transport =>
                {
                    if (!string.IsNullOrWhiteSpace(logToElasticSearch.UserName) && !string.IsNullOrWhiteSpace(logToElasticSearch.Password))
                    {
                        transport.Authentication(new BasicAuthentication(logToElasticSearch.UserName, logToElasticSearch.Password));
                    }
                });
        }

        /// <summary>
        /// 输出日志到 ElasticSearch
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="logToElasticSearch">ElasticSearch 配置</param>
        /// <param name="transport">ElasticSearch 传输</param>
        /// <returns></returns>
        public static LoggerConfiguration UseElasticSinks(this LoggerConfiguration configuration, LogToElasticSearch logToElasticSearch, ITransport transport)
        {
            return configuration.WriteTo.Elasticsearch(new ElasticsearchSinkOptions(transport)
            {
                DataStream = new DataStreamName(logToElasticSearch.DataStreamType, logToElasticSearch.DataStreamDataSet, logToElasticSearch.DataStreamNameSpace),
                BootstrapMethod = BootstrapMethod.Failure,
                ConfigureChannel = channelOpts =>
                {
                    channelOpts.BufferOptions = new BufferOptions
                    {
                        ExportMaxConcurrency = 10
                    };
                }
            });
        }
    }
}