using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class BlogCategoryTitleModel
    {
        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

        [JsonPropertyName("IsParent")]
        public bool? IsParent { get; set; }

    }
}