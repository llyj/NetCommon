using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ManufacturerList
    {
        /// <summary>
        /// 品牌名
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        /// <summary>
        /// 品牌自定义名称
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

        /// <summary>
        /// 品牌图标
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

    }
}