using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 品牌相关产品
    /// </summary>
    public class Info_BrandRelated
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

        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

        /// <summary>
        /// 品牌自定义名称
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

        /// <summary>
        /// 制造商产品Url dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("MFGUrl")]
        public string MFGUrl { get; set; }

        /// <summary>
        /// 分类 dbo.Mfgpart获取
        /// </summary>
        [JsonPropertyName("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 父分类
        /// </summary>
        [JsonPropertyName("ParentCategory")]
        public string ParentCategory { get; set; }

        /// <summary>
        /// 父分类
        /// </summary>
        [JsonPropertyName("ParentID")]
        public int? ParentID { get; set; }

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
        /// Follow
        /// </summary>
        [JsonPropertyName("Follow")]
        public bool? Follow { get; set; }

    }
}