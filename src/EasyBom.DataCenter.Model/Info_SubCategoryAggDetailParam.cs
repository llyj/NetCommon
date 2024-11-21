using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_SubCategoryAggDetailParam
    {
        /// <summary>
        /// 二级聚合自定义名称
        /// </summary>
        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

    }
}