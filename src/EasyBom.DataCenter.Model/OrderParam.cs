using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 订单表请求实体
    /// </summary>
    public class OrderParam
    {
        [JsonPropertyName("orderParamItems")]
        public List<OrderParamItem> OrderParamItems { get; set; }

    }
}