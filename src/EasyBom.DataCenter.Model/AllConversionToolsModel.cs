using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AllConversionToolsModel
    {
        /// <summary>
        /// 工具类型列表
        /// </summary>
        [JsonPropertyName("ToolTypes")]
        public List<string> ToolTypes { get; set; }

        /// <summary>
        /// 工具菜单列表
        /// </summary>
        [JsonPropertyName("ToolMenus")]
        public List<ToolMenus> ToolMenus { get; set; }

    }
}