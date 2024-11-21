using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_CategoryAttribute
    {
        [JsonPropertyName("AttributeName")]
        public string AttributeName { get; set; }

        [JsonPropertyName("Number")]
        public long? Number { get; set; }

        [JsonPropertyName("Values")]
        public List<Info_CategoryAttributeValues> Values { get; set; }

    }
}