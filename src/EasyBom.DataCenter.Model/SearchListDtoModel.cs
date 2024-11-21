using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SearchListDtoModel
    {
        /// <summary>
        /// 主键 自增列 产品ID dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 产品图片URL
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("PicUrlList")]
        public List<string> PicUrlList { get; set; }

        /// <summary>
        /// pdfURL
        /// </summary>
        [JsonPropertyName("PdfUrl")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 制造商型号
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 标准制造商型号
        /// </summary>
        [JsonPropertyName("StandPartNo")]
        public string StandPartNo { get; set; }

        /// <summary>
        /// 分销商数量
        /// </summary>
        [JsonPropertyName("DistributorCount")]
        public int? DistributorCount { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 标准制造商
        /// </summary>
        [JsonPropertyName("StandMFG")]
        public string StandMFG { get; set; }

        /// <summary>
        /// 品牌自定义名称
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 制造商产品Url dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFGUrl")]
        public string MFGUrl { get; set; }

        /// <summary>
        /// 品牌标准名
        /// </summary>
        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 父级分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [JsonPropertyName("PassiveParamShow")]
        public string PassiveParamShow { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 均价
        /// </summary>
        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        /// <summary>
        /// 封装 根据PID和AttributeName查询AttributeValue
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 是否活跃
        /// </summary>
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 是否符合RoHS
        /// </summary>
        [JsonPropertyName("IsRoHS")]
        public bool? IsRoHS { get; set; }

        /// <summary>
        /// 分销商列表
        /// </summary>
        [JsonPropertyName("DistributorsData")]
        public List<List<DistributorDetailList>> DistributorsData { get; set; }

        /// <summary>
        /// Follow
        /// </summary>
        [JsonPropertyName("Follow")]
        public bool? Follow { get; set; }

    }
}