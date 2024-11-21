using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    public class AccessRecordIndex
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        public string Vti { get; set; } = "";

        public string IP { get; set; }

        public string UserAgent { get; set; }

        public string Url { get; set; }

        public string Date_IP_UserAgent { get; set; }

        public DateTime? CreateTime { get; set; }

        public string Session { get; set; }
    }
}