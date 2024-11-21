using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 用户表请求参数实体
    /// </summary>
    public class UserParam
    {
        [JsonPropertyName("userParamItems")]
        public List<UserParamItem> UserParamItems { get; set; }

    }
}