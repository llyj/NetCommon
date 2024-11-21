using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 人气商品Dto
    /// </summary>
    public class PopProductsDto
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        /// <summary>
        /// 制造商型号 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// 标准品牌名
        /// </summary>
        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

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
        /// 厂商图标
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

        /// <summary>
        /// 封装 根据PID和AttributeName查询AttributeValue
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 父级分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 产品说明 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 图片url	通过Pid和PicTypeID=1 查询Part_Pic表获取第一条的URL
        /// </summary>
        [JsonPropertyName("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("PicUrlList")]
        public List<string> PicUrlList { get; set; }

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

    }
}