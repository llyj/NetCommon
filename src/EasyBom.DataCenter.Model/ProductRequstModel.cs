using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 产品请求实体
    /// </summary>
    public class ProductRequstModel
    {
        /// <summary>
        /// 产品请求列表
        /// </summary>
        [JsonPropertyName("Pids")]
        public List<int> Pids { get; set; }

        /// <summary>
        /// 兼容请求参数
        /// </summary>
        [JsonPropertyName("ProductRequsts")]
        public List<ProductRequst> ProductRequsts { get; set; }
    }
}