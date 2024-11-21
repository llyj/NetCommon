using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 信息页-品牌列表
    /// </summary>
    public class Info_Mfgs
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MfgID")]
        public int? MfgID { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        /// <summary>
        /// 制造商中文名
        /// </summary>
        [JsonPropertyName("ChineseMFG")]
        public string ChineseMFG { get; set; }

        /// <summary>
        /// 标准名
        /// </summary>
        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

        /// <summary>
        /// 品牌自定义标准名
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

        /// <summary>
        /// 品牌图片地址
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        /// <summary>
        /// 旧品牌ID
        /// </summary>
        [JsonPropertyName("OldMFGID")]
        public int? OldMFGID { get; set; }

    }
}