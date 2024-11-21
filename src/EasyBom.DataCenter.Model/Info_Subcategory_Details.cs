using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_Subcategory_Details
    {
        /// <summary>
        /// 导航栏信息
        /// </summary>
        [JsonPropertyName("SubCategoryNavigationBar")]
        public SubCategoryNavigationBar SubCategoryNavigationBar { get; set; }

        /// <summary>
        /// 子分类信息
        /// </summary>
        [JsonPropertyName("Info_SubCateogry")]
        public Info_SubCateogry Info_SubCateogry { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

    }
}