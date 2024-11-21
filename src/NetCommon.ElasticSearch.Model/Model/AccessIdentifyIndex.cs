using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    public class AccessIdentifyIndex
    {
        public string IP { get; set; }

        public string VerifyCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? InvalidTime { get; set; }
        public DateTime? VerifyTime { get; set; }
        public bool? Status { get; set; }
    }
}