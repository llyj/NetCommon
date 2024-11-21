using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SiteMapValidateModel
    {
        [JsonPropertyName("URL")]
        public string URL { get; set; }

        [JsonPropertyName("IsIncluded")]
        public bool? IsIncluded { get; set; }

        [JsonPropertyName("UpdateTime")]
        public System.DateTimeOffset? UpdateTime { get; set; }

    }
}