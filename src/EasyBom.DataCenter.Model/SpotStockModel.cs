using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SpotStockModel
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 制造商     (关联-Manufacturer表MfgName) dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 分销商购买详情页
        /// </summary>
        [JsonPropertyName("DistributorPartUrl")]
        public string DistributorPartUrl { get; set; }

    }
}