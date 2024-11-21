using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using NetCommon.ElasticSearch.Model;
using NetCommon.ElasticSearch.Model.Config;
using NetCommon.ElasticSearch.Model.Model;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace NetCommon.ElasticSearchV6.Nest.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 注册 低版本的 ElasticSearch 服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="elasticSearchConfig"></param>
        /// <returns></returns>
        public static IServiceCollection AddElasticSearchNest(this IServiceCollection services, ElasticSearchConfig elasticSearchConfig)
        {
            var nodes = new Uri[] { new Uri(elasticSearchConfig.HostUrl) };

            var staticConnectionPool = new StaticConnectionPool(nodes);
            var connectionSettings = new ConnectionSettings(staticConnectionPool);
            connectionSettings.DefaultFieldNameInferrer((name) => name);
            connectionSettings.DisableDirectStreaming();
            connectionSettings.DefaultIndex(nameof(ProductIndex).ToLowerInvariant());
            // 配置默认映射
            connectionSettings.DefaultMappingFor<ProductIndex>(x =>
                x.IndexName(nameof(ProductIndex).ToLowerInvariant())
                    .TypeName(nameof(ProductIndex).Replace("Index", ""))
                    .IdProperty(p => p.ProductID));

            connectionSettings.DefaultMappingFor<AccessRecordIndex>(x =>
                x.IndexName(nameof(AccessRecordIndex).ToLowerInvariant())
                    .TypeName(nameof(AccessRecordIndex).Replace("Index", "")));

            connectionSettings.DefaultMappingFor<AccessStatisticsIndex>(x =>
                x.IndexName(nameof(AccessStatisticsIndex).ToLowerInvariant())
                    .TypeName(nameof(AccessStatisticsIndex).Replace("Index", ""))
                    .IdProperty(p => p.Date_IP_UserAgent));

            connectionSettings.DefaultMappingFor<AccessIdentifyIndex>(x =>
                x.IndexName(nameof(AccessIdentifyIndex).ToLowerInvariant())
                    .TypeName(nameof(AccessIdentifyIndex).Replace("Index", ""))
                    .IdProperty(p => p.IP));

            connectionSettings.DefaultMappingFor<IPStatisticsIndex>(x =>
                x.IndexName(nameof(IPStatisticsIndex).ToLowerInvariant())
                    .TypeName(nameof(IPStatisticsIndex).Replace("Index", ""))
                    .IdProperty(p => p.Date_IP));

            connectionSettings.DefaultMappingFor<IPSegmentStatisticsIndex>(x =>
                x.IndexName(nameof(IPSegmentStatisticsIndex).ToLowerInvariant())
                    .TypeName(nameof(IPSegmentStatisticsIndex).Replace("Index", ""))
                    .IdProperty(p => p.Date_IPSegment));

            connectionSettings.DefaultMappingFor<CrawlerIndex>(x =>
                x.IndexName(nameof(CrawlerIndex).ToLowerInvariant())
                    .TypeName(nameof(CrawlerIndex).Replace("Index", ""))
                    .IdProperty(p => p.ID));

            connectionSettings.DefaultMappingFor<ProductPriceIndex>(x =>
                x.IndexName(nameof(ProductPriceIndex).ToLowerInvariant())
                    .TypeName(nameof(ProductPriceIndex).Replace("Index", ""))
                    .IdProperty(p => p.ID_Distributor));

            connectionSettings.DefaultMappingFor<StockPriceIndex>(x =>
                x.IndexName(nameof(StockPriceIndex).ToLowerInvariant())
                    .TypeName(nameof(StockPriceIndex).Replace("Index", ""))
                    .IdProperty(p => p.ID_Distributor));

            connectionSettings.DefaultMappingFor<ViewedRecordIndex>(x =>
                x.IndexName(nameof(ViewedRecordIndex).ToLowerInvariant())
                    .TypeName(nameof(ViewedRecordIndex).Replace("Index", ""))
                    .IdProperty(p => p.PID_UID));

            services.AddSingleton<ElasticClient>(new ElasticClient(connectionSettings));

            return services;
        }
    }
}