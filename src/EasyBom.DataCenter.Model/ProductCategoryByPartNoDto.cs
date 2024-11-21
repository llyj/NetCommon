using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class ProductCategoryByPartNoDto
    {
        [JsonPropertyName("ParamPartNo")]
        public string ParamPartNo { get; set; }

        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        [JsonPropertyName("ParentCategoryName")]
        public string ParentCategoryName { get; set; }

        [JsonPropertyName("ParentCategoryID")]
        public int? ParentCategoryID { get; set; }

        [JsonPropertyName("CategoryName")]
        public string CategoryName { get; set; }

        [JsonPropertyName("CategoryID")]
        public int? CategoryID { get; set; }

    }
}