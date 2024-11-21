using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 主页实体
    /// </summary>
    public class HomePageModel
    {
        /// <summary>
        /// 分类列表
        /// </summary>
        [JsonPropertyName("Categorys")]
        public List<Home_Categorys> Categorys { get; set; }

        /// <summary>
        /// 品牌列表
        /// </summary>
        [JsonPropertyName("Mfgs")]
        public List<Home_Mfgs> Mfgs { get; set; }

    }
}