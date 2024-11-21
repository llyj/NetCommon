using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 分类-品牌列表
    /// </summary>
    public class Home_Mfgs
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        /// <summary>
        /// 标准名
        /// </summary>
        [JsonPropertyName("EnName")]
        public string EnName { get; set; }

        /// <summary>
        /// 品牌自定义名称
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

    }
}