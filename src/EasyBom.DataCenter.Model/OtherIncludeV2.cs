using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class OtherIncludeV2
    {
        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonPropertyName("Products")]
        public List<Products> Products { get; set; }

    }
}