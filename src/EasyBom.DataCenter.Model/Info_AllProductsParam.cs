using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_AllProductsParam
    {
        /// <summary>
        /// 二级分类名
        /// </summary>
        [JsonPropertyName("SubCategoryName")]
        public string SubCategoryName { get; set; }

    }
}