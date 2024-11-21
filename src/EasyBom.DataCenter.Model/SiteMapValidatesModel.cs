using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SiteMapValidatesModel
    {
        [JsonPropertyName("siteMapValidateModels")]
        public List<SiteMapValidateModel> SiteMapValidateModels { get; set; }

    }
}