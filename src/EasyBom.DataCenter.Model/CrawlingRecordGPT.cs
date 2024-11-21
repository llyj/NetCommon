using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class CrawlingRecordGPT
    {
        [JsonPropertyName("PID")]
        public int? PID { get; set; }

        [JsonPropertyName("date")]
        public System.DateTimeOffset? Date { get; set; }

    }
}