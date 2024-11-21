using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class UtmelProductIndexListDto
    {
        [JsonPropertyName("LastID")]
        public int? LastID { get; set; }

        [JsonPropertyName("utmelProductIndexDtos")]
        public List<UtmelProductIndexDto> UtmelProductIndexDtos { get; set; }

    }
}