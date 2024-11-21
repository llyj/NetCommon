using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Huaqiang_DataDto
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        [JsonPropertyName("lot_number")]
        public string Lot_number { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 封装
        /// </summary>
        [JsonPropertyName("encapsulation")]
        public string Encapsulation { get; set; }

        /// <summary>
        /// 产品参数
        /// </summary>
        [JsonPropertyName("product_parameters")]
        public string Product_parameters { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [JsonPropertyName("warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// 交易说明
        /// </summary>
        [JsonPropertyName("transaction_description")]
        public string Transaction_description { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("update_date")]
        public string Update_date { get; set; }

        /// <summary>
        /// 爬取时间
        /// </summary>
        [JsonPropertyName("spider_time")]
        public double? Spider_time { get; set; }

        /// <summary>
        /// 来源url
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

    }
}