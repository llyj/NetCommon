using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class PopularPartsList
    {
        /// <summary>
        /// 主键 自增列 产品ID dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        [JsonPropertyName("PassiveParamShow")]
        public string PassiveParamShow { get; set; }

        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        /// <summary>
        /// 封装 根据PID和AttributeName查询AttributeValue
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

    }
}