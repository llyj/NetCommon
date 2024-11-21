using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SeriesModelDetails
    {
        /// <summary>
        /// 系列ID
        /// </summary>
        [JsonPropertyName("SeriesID")]
        public int? SeriesID { get; set; }

        /// <summary>
        /// 系列名称
        /// </summary>
        [JsonPropertyName("SeriesName")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 系列自定义名
        /// </summary>
        [JsonPropertyName("CountryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// 图标路径
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("PicUrlList")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// 系列概述
        /// </summary>
        [JsonPropertyName("SeriesOverview")]
        public string SeriesOverview { get; set; }

        /// <summary>
        /// 系列规格
        /// </summary>
        [JsonPropertyName("SeriesSpecification")]
        public string SeriesSpecification { get; set; }

        /// <summary>
        /// 系列应用（描述）
        /// </summary>
        [JsonPropertyName("SeriesApplication")]
        public string SeriesApplication { get; set; }

        /// <summary>
        /// 父级分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

    }
}