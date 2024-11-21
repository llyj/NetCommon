using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 分类页-产品列表
    /// </summary>
    public class Info_Products
    {
        /// <summary>
        /// 主键 自增列 产品ID dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 制造商型号 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 制造商     (关联-Manufacturer表MfgName) dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 标准品牌
        /// </summary>
        [JsonPropertyName("StandMFG")]
        public string StandMFG { get; set; }

        /// <summary>
        /// 标准型号
        /// </summary>
        [JsonPropertyName("StandPartNo")]
        public string StandPartNo { get; set; }

        /// <summary>
        /// PDF路径
        /// </summary>
        [JsonPropertyName("PdfUrl")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("PicUrlList")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// 子分类名称
        /// </summary>
        [JsonPropertyName("SubCategory")]
        public string SubCategory { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Follow
        /// </summary>
        [JsonPropertyName("Follow")]
        public bool? Follow { get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonPropertyName("PassiveParamShow")]
        public string PassiveParamShow { get; set; }

    }
}