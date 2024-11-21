using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_SubcategoryParam
    {
        /// <summary>
        /// 分类自定义名称
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        /// <summary>
        /// 父级分类自定义名称
        /// </summary>
        [JsonPropertyName("ParentCustomName")]
        public string ParentCustomName { get; set; }

    }
}