using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class BlogRelatedPartsParam
    {
        [JsonPropertyName("CategoryTitleModels")]
        public List<BlogCategoryTitleModel> CategoryTitleModels { get; set; }

        [JsonPropertyName("PartsLimt")]
        public int? PartsLimt { get; set; }

    }
}