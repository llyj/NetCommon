using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ToolsMenuByTypeParam
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        [JsonPropertyName("TypeName")]
        public string TypeName { get; set; }

    }
}