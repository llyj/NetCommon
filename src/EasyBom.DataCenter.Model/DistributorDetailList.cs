using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class DistributorDetailList
    {
        /// <summary>
        /// 库存价格ID
        /// </summary>
        [JsonPropertyName("SID")]
        public long? SID { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 分销商型号
        /// </summary>
        [JsonPropertyName("PartNo")]
        public string PartNo { get; set; }

        /// <summary>
        /// 封装 根据PID和AttributeName查询AttributeValue
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 分销商
        /// </summary>
        [JsonPropertyName("Distributor")]
        public string Distributor { get; set; }

        /// <summary>
        /// 分销商购买详情页
        /// </summary>
        [JsonPropertyName("DistributorPartUrl")]
        public string DistributorPartUrl { get; set; }

        /// <summary>
        /// 国别
        /// </summary>
        [JsonPropertyName("CountryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// 分销商等级
        /// </summary>
        [JsonPropertyName("DistributorGrade")]
        public string DistributorGrade { get; set; }

        /// <summary>
        /// 是否授权
        /// </summary>
        [JsonPropertyName("ISAuthorizeddealer")]
        public bool? ISAuthorizeddealer { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("StockNum")]
        public int? StockNum { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 阶梯价
        /// </summary>
        [JsonPropertyName("StepPrice")]
        public string StepPrice { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [JsonPropertyName("Warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("UpdateTime")]
        public System.DateTimeOffset? UpdateTime { get; set; }

    }
}