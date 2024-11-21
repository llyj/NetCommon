using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CategoryProductIndexModel
    {
        /// <summary>
        /// 索引列表
        /// </summary>
        [JsonPropertyName("CategoryProductIndexLists")]
        public List<CategoryProductIndexList> CategoryProductIndexLists { get; set; }

    }
}