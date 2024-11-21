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
    //[Header("X-Auth-External", "")]
    [LoggingFilter(LogResponse = false)]
    [OAuthToken]
    [HttpHost("http://localdb.easybom.com:8109/api/")]
    public interface IDataCenterProductApi : IHttpApi
    {
        /// <summary>
        /// 获取对比产品
        /// </summary>
        /// <param name="productParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/comparison")]
        ITask<ComparisonModel> GetComparisonAsync([Required][JsonContent] ProductParameters productParameters, CancellationToken cancellationToken = default);

        [HttpPost("api/v1/product/popproducts")]
        ITask<PopProductsModel> PopProductsAsync([Required][JsonContent] PopParameters popParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 热门商品-分页获取
        /// </summary>
        /// <param name="hotParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/hotproducts")]
        ITask<HotProductsModel> GetHotProductsAsync([Required][JsonContent] HotParameters hotParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取对应产品列表
        /// </summary>
        /// <param name="productRequstModel">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [JsonReturn]
        [HttpPost("api/v1/product/getproducts")]
        ITask<List<ProductResponse>> GetProductsAsync([Required][JsonContent] ProductRequstModel productRequstModel, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取对应产品列表 带属性
        /// </summary>
        /// <param name="productRequstModel">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductsandattr")]
        ITask<List<ProductAndAttrResponse>> GetProductsAndAttrAsync([Required][JsonContent] ProductRequstModel productRequstModel, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取对应产品列表 带价格
        /// </summary>
        /// <param name="productRequstModel">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductsandprice")]
        ITask<List<ProductAndPriceResponse>> GetProductsAndPriceAsync([Required][JsonContent] ProductRequstModel productRequstModel, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据型号品牌获取产品信息
        /// </summary>
        /// <param name="productNoPidParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductbypartnoandmfg")]
        ITask<ProductNoPidRespModel> GetProductByPartNoAndMFGAsync([Required][JsonContent] ProductNoPidParameters productNoPidParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据型号品牌获取产品信息
        /// </summary>
        /// <param name="productNoPidParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductbypartnoandmfgv2")]
        ITask<ProductNoPidRespModel> GetProductByPartNoAndMFGV2Async([Required][JsonContent] ProductNoPidParameters productNoPidParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据型号品牌列表批量获取产品信息
        /// </summary>
        /// <param name="productNoPidListParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductbypartnoandmfglist")]
        ITask<List<ProductResponse>> GetProductByPartNoAndMFGListAsync([Required][JsonContent] ProductNoPidListParameters productNoPidListParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 详情产品URL厂商字段校验
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/productvalidation")]
        ITask<string> ProductValidationAsync([Required][JsonContent] ProductValidationParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 博客相关型号
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/blogrelatedparts")]
        ITask<BlogRelatedProductModel> BlogRelatedPartsAsync([Required][JsonContent] BlogRelatedPartsParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 拉取产品索引
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/pullproductindex")]
        ITask<PullProductIndexRespModel> PullProductIndexAsync([Required][JsonContent] PullProductIndexParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 拉取产品根据分类ID
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/pullproductbycategory")]
        ITask<PullProductByCategoryRespModel> PullProductByCategoryAsync([Required][JsonContent] PullProductByCategoryParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据属性名和属性值关键字去获取产品列表
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getpartsbyattr")]
        ITask<PartsByAttrDto> GetPartsByAttrAsync([Required][JsonContent] GetPartsByAttrParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取产品信息列表【Kynix】
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/productskynix")]
        ITask<ProductKynixRespModel> GetProductsKynixAsync([Required][JsonContent] ProductsKynixParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据url获取产品信息
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductbyurlsync")]
        ITask<List<ProductByUrlModel>> GetProductByUrlSyncAsync([Required][JsonContent] IEnumerable<string> urls, CancellationToken cancellationToken = default);

        /// <summary>
        /// pdf路径加密
        /// </summary>
        /// <param name="pathParam"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getpdfauth")]
        ITask<PdfAuthPathModel> GetPdfAuthAsync([Required][JsonContent] PdfPathParam pathParam, CancellationToken cancellationToken = default);

        /// <summary>
        /// 根据厂商ID、分类ID获取产品信息
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getproductbymfgandcategory")]
        ITask<ProductByMFGAndCategoryModel> GetProductByMFGAndCategoryAsync([Required][JsonContent] ProductByMFGAndCategoryParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// Utmel拉取产品索引
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/product/getutmelproductindex")]
        ITask<UtmelProductIndexListDto> GetUtmelProductIndexAsync([Required][JsonContent] UtmelProductIndexParam param, CancellationToken cancellationToken = default);
    }
}