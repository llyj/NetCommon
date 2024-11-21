using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 可替换商品实体
    /// </summary>
    public class ProReplacementModel
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 品牌自定义名称
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

        /// <summary>
        /// 均价
        /// </summary>
        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        /// <summary>
        /// 分销商
        /// </summary>
        [JsonPropertyName("Distributor")]
        public string Distributor { get; set; }

        /// <summary>
        /// 封装
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        [JsonPropertyName("AttributesDetails")]
        public IDictionary<string, string> AttributesDetails { get; set; }

        /// <summary>
        /// Follow
        /// </summary>
        [JsonPropertyName("Follow")]
        public bool? Follow { get; set; }

        /// <summary>
        /// 分销商数量
        /// </summary>
        [JsonPropertyName("DistributorNumber")]
        public int? DistributorNumber { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("Stock")]
        public int? Stock { get; set; }

    }
}