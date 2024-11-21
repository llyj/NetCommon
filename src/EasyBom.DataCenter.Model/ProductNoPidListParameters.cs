using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 获取对应产品列表的参数（根据品牌和型号）
    /// </summary>
    public class ProductNoPidListParameters
    {
        [JsonPropertyName("PartNoAndMFG")]
        public List<ProductNoPidParameters> PartNoAndMFG { get; set; }

    }
}