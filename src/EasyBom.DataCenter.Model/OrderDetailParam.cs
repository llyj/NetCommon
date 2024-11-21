using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 订单详细表请求实体
    /// </summary>
    public class OrderDetailParam
    {
        [JsonPropertyName("orderDetailParamItems")]
        public List<OrderDetailParamItem> OrderDetailParamItems { get; set; }

    }
}