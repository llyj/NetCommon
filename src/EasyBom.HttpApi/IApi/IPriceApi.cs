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
    public interface IDataCenterPriceApi : IHttpApi
    {
        /// <summary>
        /// 获取分销商价格 --
        /// </summary>
        /// <param name="priceParameters">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/distributorpricenew")]
        ITask<PriceResponseDto> GetDistributorPriceNewAsync([Required][JsonContent] PriceDto priceParameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取库存价格
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/stockprice")]
        ITask<StockPriceResponseModel> GetStockPriceAsync([Required][JsonContent] StockPriceParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取库存价格 (带阶梯价)
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/stockpricev2")]
        ITask<StockPriceListDto> GetStockPriceV2Async([Required][JsonContent] StockPriceParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取有效库存价格 (带阶梯价)
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/validstockprice")]
        ITask<StockPriceListDto> GetValidStockPriceAsync([Required][JsonContent] StockPriceParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取库存价格根据PID
        /// </summary>
        /// <param name="param">参数实体</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/stockpricebypid")]
        ITask<StepPriceResponseDto> GetStockPriceByPIDAsync([Required][JsonContent] StepPriceDto param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取没有过期且有价格的PID列表
        /// </summary>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/gethavepriceofpids")]
        ITask<PIDArrayDto> GetHavePriceOfPIDsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 匹配Pid接口 --对接爬虫的
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/matchpidasync")]
        ITask<PIDResponseDto> MatchPIDAsync([Required][JsonContent] MatchPIDParam param, CancellationToken cancellationToken = default);

        /// <summary>
        /// 上传供应商价格数据
        /// </summary>
        /// <param name="paramer"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/supplierpricepush")]
        ITask<bool> SupplierPricePushAsync([Required][JsonContent] SupplierPricePushParamers paramer, CancellationToken cancellationToken = default);

        /// <summary>
        /// 拉取供应商价格数据
        /// </summary>
        /// <param name="paramers"></param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>OK</returns>
        [HttpPost("api/v1/price/supplierpricepull")]
        ITask<SupplierPricePullModel> SupplierPricePullAsync([Required][JsonContent] SupplierPricePullParamers paramers, CancellationToken cancellationToken = default);
    }
}