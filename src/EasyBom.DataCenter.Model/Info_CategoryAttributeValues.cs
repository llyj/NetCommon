using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class Info_CategoryAttributeValues
    {
        [JsonPropertyName("AttributeValue")]
        public string AttributeValue { get; set; }

        [JsonPropertyName("Number")]
        public long? Number { get; set; }

    }
}