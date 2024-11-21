using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class GetProductParam
    {
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        [JsonPropertyName("ParentName")]
        public string ParentName { get; set; }

        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        [JsonPropertyName("AttributeName")]
        public string AttributeName { get; set; }

        [JsonPropertyName("AttributeValue")]
        public string AttributeValue { get; set; }

        [JsonPropertyName("LastPID")]
        public int? LastPID { get; set; }

        [JsonPropertyName("Limit")]
        public int? Limit { get; set; }

    }
}