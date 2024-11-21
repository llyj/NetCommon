using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class FaqModels
    {
        /// <summary>
        /// 问答拓展属性
        /// </summary>
        [JsonPropertyName("FaqExts")]
        public IDictionary<string, string> FaqExts { get; set; }

        [JsonPropertyName("ProductFaqs")]
        public List<ProductFaqsModel> ProductFaqs { get; set; }

    }
}