using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using NetCommon.ElasticSearch.Model;
using NetCommon.ElasticSearch.Model.Config;
using Microsoft.Extensions.DependencyInjection;

namespace NetCommon.ElasticSearch.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 ElasticSearch 服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="elasticSearchConfig"></param>
        /// <returns></returns>
        public static IServiceCollection AddElasticSearch(this IServiceCollection services, ElasticSearchConfig elasticSearchConfig)
        {
            var singleNodePool = new SingleNodePool(new Uri(elasticSearchConfig.HostUrl));

            var elasticsearchClientSettings = new ElasticsearchClientSettings(singleNodePool)
                // 配置默认匹配项
                //.DefaultMappingFor<AccessRecord>(x => x.IndexName(nameof(AccessRecord).ToLowerInvariant()).IdProperty(p => p.Date_IP_UserAgent))
                .DefaultMappingFor<AccessStatisticsIndex>(x => x.IdProperty(p => p.Date_IP_UserAgent))
                .DefaultMappingFor<AccessIdentifyIndex>(x => x.IdProperty(p => p.IP))
                .DefaultMappingFor<IPStatisticsIndex>(x => x.IdProperty(p => p.Date_IP))
                .DefaultMappingFor<IPSegmentStatisticsIndex>(x => x.IdProperty(p => p.Date_IPSegment))
                .Authentication(new BasicAuthentication(elasticSearchConfig.UserName, elasticSearchConfig.Password));

            services.AddSingleton<ElasticsearchClient>(new ElasticsearchClient(elasticsearchClientSettings));

            return services;
        }
    }
}