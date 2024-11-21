using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MfgCategorys
    {
        [JsonPropertyName("ParentName")]
        public string ParentName { get; set; }

        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        [JsonPropertyName("SEOTitle")]
        public string SEOTitle { get; set; }

        [JsonPropertyName("CustomName")]
        public string CustomName { get; set; }

        [JsonPropertyName("Info_MfgCategorys")]
        public List<Info_MfgCategorys> Info_MfgCategorys { get; set; }

    }
}