using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class MfgDetailsThree
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [JsonPropertyName("MFGID")]
        public int? MFGID { get; set; }

        /// <summary>
        /// 制造商log路径
        /// </summary>
        [JsonPropertyName("MfgIconPath")]
        public string MfgIconPath { get; set; }

        /// <summary>
        /// 商业和政府机构代码
        /// </summary>
        [JsonPropertyName("CAGECode")]
        public string CAGECode { get; set; }

        /// <summary>
        /// 企业编码
        /// </summary>
        [JsonPropertyName("DUNSNumber")]
        public string DUNSNumber { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        [JsonPropertyName("Fax")]
        public string Fax { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// 制造商别名（分号;间隔）
        /// </summary>
        [JsonPropertyName("MfgAlias")]
        public string MfgAlias { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("Address")]
        public string Address { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 制造商
        /// </summary>
        [JsonPropertyName("MfgName")]
        public string MfgName { get; set; }

        /// <summary>
        /// 制造商标准化名
        /// </summary>
        [JsonPropertyName("MfgCustomName")]
        public string MfgCustomName { get; set; }

        /// <summary>
        /// 制造商产品Url
        /// </summary>
        [JsonPropertyName("MfgUrl")]
        public string MfgUrl { get; set; }

        /// <summary>
        /// 旗下分销商
        /// </summary>
        [JsonPropertyName("Distributors")]
        public string Distributors { get; set; }

        /// <summary>
        /// 品牌Twitter
        /// </summary>
        [JsonPropertyName("Twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// 品牌Facebook
        /// </summary>
        [JsonPropertyName("Facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// 品牌Youtube
        /// </summary>
        [JsonPropertyName("Youtube")]
        public string Youtube { get; set; }

        /// <summary>
        /// 图片前缀
        /// </summary>
        [JsonPropertyName("PrefixImg")]
        public string PrefixImg { get; set; }

        /// <summary>
        /// 内容描述
        /// </summary>
        [JsonPropertyName("ContentDescription")]
        public string ContentDescription { get; set; }

    }
}