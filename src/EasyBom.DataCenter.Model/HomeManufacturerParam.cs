using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 首页展示的品牌(不传展示默认的8个)
    /// </summary>
    public class HomeManufacturerParam
    {
        [JsonPropertyName("MfgNameList")]
        public List<string> MfgNameList { get; set; }

    }
}