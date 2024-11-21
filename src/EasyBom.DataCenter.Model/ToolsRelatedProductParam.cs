using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ToolsRelatedProductParam
    {
        /// <summary>
        /// 工具相关分类
        /// </summary>
        [JsonPropertyName("ToolLinkCategoryModels")]
        public List<ToolLinkCategoryModel> ToolLinkCategoryModels { get; set; }

    }
}