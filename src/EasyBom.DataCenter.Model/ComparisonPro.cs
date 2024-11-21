using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 对比产品实体
    /// </summary>
    public class ComparisonPro
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
        /// 制造商     (关联-Manufacturer表MfgName) dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// 制造商中文名
        /// </summary>
        [JsonPropertyName("ChineseMFG")]
        public string ChineseMFG { get; set; }

        /// <summary>
        /// 制造商ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 标准名
        /// </summary>
        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

        /// <summary>
        /// 产品说明 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 分类名
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 父级分类ID
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// 父级分类名
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [JsonPropertyName("AttributeDetails")]
        public List<AttributesModel> AttributeDetails { get; set; }

        /// <summary>
        /// 图片url	通过Pid和PicTypeID=1 查询Part_Pic表获取第一条的URL
        /// </summary>
        [JsonPropertyName("PicList")]
        public List<string> PicList { get; set; }

        /// <summary>
        /// pdfurl 通过Pid和ResTypeID=1 查询Part_ResFile表获取第一条的Name
        /// </summary>
        [JsonPropertyName("PdfName")]
        public string PdfName { get; set; }

        /// <summary>
        /// PdfUrl 通过Pid和ResTypeID=1 查询Part_ResFile表获取第一条的URL
        /// </summary>
        [JsonPropertyName("PdfUrl")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 是否符合RoHS
        /// </summary>
        [JsonPropertyName("IsRoHS")]
        public bool? IsRoHS { get; set; }

        /// <summary>
        /// 封装
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

    }
}