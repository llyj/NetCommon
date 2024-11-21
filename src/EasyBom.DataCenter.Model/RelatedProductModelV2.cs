using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class RelatedProductModelV2
    {
        /// <summary>
        /// 替代零件，10个
        /// </summary>
        [JsonPropertyName("RelatedProductInfos")]
        public List<RelatedProductInfo> RelatedProductInfos { get; set; }

    }
}