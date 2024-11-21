using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class AIPartNoResultModel_V2
    {
        [JsonPropertyName("LastPID")]
        public int? LastPID { get; set; }

        [JsonPropertyName("aiPartNoResultLists")]
        public List<AIPartNoResultList> AiPartNoResultLists { get; set; }

    }
}