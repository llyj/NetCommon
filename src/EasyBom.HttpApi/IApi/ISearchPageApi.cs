using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EasyBom.DataCenter.Model;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace EasyBom.DataCenter.HttpApi.IApi
{
    [LoggingFilter(LogResponse = false)]
    [OAuthToken]
    [HttpHost("http://localdb.easybom.com:8109/api/")]
    public interface IDataCenterSearchPageApi : IHttpApi
    {
        /// <summary>
        /// 搜索页-检索产品 --New
        /// </summary>
        /// <param name="searchParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/searchproducts")]
        ITask<SearchListModelDto> SearchProductsToCenterAsync([Required][JsonContent] SearchParameters searchParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-检索产品 --New
        /// </summary>
        /// <param name="searchParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/searchproductsasync")]
        ITask<SearchListModelDto> SearchProductsAsync([Required][JsonContent] SearchParameters searchParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-属性表格
        /// </summary>
        /// <param name="attributeTableParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/attributetable")]
        ITask<AttributeTableModel> GetAttributeTableToCenterAsync([Required][JsonContent] AttributeTableParameters attributeTableParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-属性表格
        /// </summary>
        /// <param name="attributeTableParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/attributetableasync")]
        ITask<AttributeTableModel> GetAttributeTableAsync([Required][JsonContent] AttributeTableParameters attributeTableParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-获取父级分类
        /// </summary>
        /// <param name="categoryParameter">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/parentcategory")]
        ITask<FatherSonCategory> GetParentCategoryAsync([Required][JsonContent] CategoryParameter categoryParameter, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-获取产品总条数
        /// </summary>
        /// <param name="proCountParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/searchprototalcount")]
        ITask<ProCountRespModel> SearchProTotalCountToCenterAsync([Required][JsonContent] ProCountParameters proCountParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-异步获取属性选型
        /// </summary>
        /// <param name="attributesParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/attributesync")]
        ITask<AttributesRespModel> GetAttributeSyncAsync([Required][JsonContent] AttributeSyncParameter attributesParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-异步获取属性选型 --仅包含属性名
        /// </summary>
        /// <param name="attributesParameters"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/attributesyncv2")]
        ITask<AttributesRespModelV2> GetAttributeSyncV2Async([Required][JsonContent] AttributeSyncParameter attributesParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-异步获取属性选型 NEW
        /// </summary>
        /// <param name="attributeSyncParameter"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/attributesaggregationsyncv2")]
        ITask<AttributesOptimizeRespNewModel> GetAttributesAggregationSyncV2Async([Required][JsonContent] AttributeSyncParameter attributeSyncParameter, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-根据属性选型后的 属性名获取对应的属性值
        /// </summary>
        /// <param name="attributesParameters"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/getattrvaluebyname")]
        ITask<AttrValues> GetAttrValueByNameAsync([Required][JsonContent] AttributeSyncParameterV2 attributesParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-异步获取品牌选型
        /// </summary>
        /// <param name="mFGSyncParameter">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/mfgsync")]
        ITask<MFGRespModel> GetMFGSyncAsync([Required][JsonContent] MFGSyncParameter mFGSyncParameter, CancellationToken cancellationToken = default);

        /// <summary>
        /// 搜索页-异步获取分类选型
        /// </summary>
        /// <param name="categorySyncParameter">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/search/categorysync")]
        ITask<CategoryRespModel> GetCategorySyncAsync([Required][JsonContent] CategorySyncParameter categorySyncParameter, CancellationToken cancellationToken = default);
    }
}