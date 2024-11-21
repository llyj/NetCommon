using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 客户表请求实体
    /// </summary>
    public class CompanyParam
    {
        [JsonPropertyName("CompanyParamItems")]
        public List<CompanyParamItem> CompanyParamItems { get; set; }

    }
}