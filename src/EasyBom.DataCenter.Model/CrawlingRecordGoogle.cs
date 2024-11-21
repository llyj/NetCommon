using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CrawlingRecordGoogle
    {
        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("date")]
        public System.DateTimeOffset? Date { get; set; }

    }
}