using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Home_PopPorducts
    {
        /// <summary>
        /// 人气商品列表
        /// </summary>
        [JsonPropertyName("PopPorductsModels")]
        public List<Home_PopPorductsModel> PopPorductsModels { get; set; }

    }
}