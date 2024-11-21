using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// Utmel商城产品实体
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 制造商型号 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("PartNo")]
        public string PartNo { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 制造商中文名
        /// </summary>
        [JsonPropertyName("ChineseMFG")]
        public string ChineseMFG { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 制造商Url
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
        /// 父级分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 封装 根据PID和AttributeName查询AttributeValue
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 产品说明 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [JsonPropertyName("AttributeDetails")]
        public List<AttributeList> AttributeDetails { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片url集合
        /// </summary>
        [JsonPropertyName("PicList")]
        public List<string> PicList { get; set; }

        /// <summary>
        /// pdfurl
        /// </summary>
        [JsonPropertyName("PdfName")]
        public string PdfName { get; set; }

        /// <summary>
        /// PdfUrl
        /// </summary>
        [JsonPropertyName("PdfUrl")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 是否符合RoHS
        /// </summary>
        [JsonPropertyName("IsRoHS")]
        public bool? IsRoHS { get; set; }

        /// <summary>
        /// 产品常见问题解答
        /// </summary>
        [JsonPropertyName("FAQs")]
        public List<ProductFaqsModel> FAQs { get; set; }

        /// <summary>
        /// 资源文件列表
        /// </summary>
        [JsonPropertyName("ResFilesGroup")]
        public List<ResFileModel> ResFilesGroup { get; set; }

        /// <summary>
        /// 是否活跃
        /// </summary>
        [JsonPropertyName("IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 厂商图标
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

    }
}