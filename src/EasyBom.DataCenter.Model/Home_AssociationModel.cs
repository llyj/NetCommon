using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    /// <summary>
    /// 首页联想查询实体
    /// </summary>
    public class Home_AssociationModel
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [JsonPropertyName("Keyword")]
        public string Keyword { get; set; }

    }
}