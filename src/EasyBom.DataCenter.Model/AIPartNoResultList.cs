using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AIPartNoResultList
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 产品型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 一级分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 产品说明
        /// </summary>
        [JsonPropertyName("AI_PartNoDescription")]
        public string AI_PartNoDescription { get; set; }

        /// <summary>
        /// 技术文章
        /// </summary>
        [JsonPropertyName("AI_TechnicalArticle")]
        public string AI_TechnicalArticle { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonPropertyName("CrawlingReadTime")]
        public System.DateTimeOffset? CrawlingReadTime { get; set; }

    }
}