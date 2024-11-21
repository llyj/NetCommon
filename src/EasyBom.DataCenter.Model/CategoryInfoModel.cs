using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CategoryInfoModel
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [JsonPropertyName("ApplicationCategory")]
        public string ApplicationCategory { get; set; }

        /// <summary>
        /// 子分类
        /// </summary>
        [JsonPropertyName("CategoryInfoModels")]
        public List<CategoryInfoModel> CategoryInfoModels { get; set; }

    }
}