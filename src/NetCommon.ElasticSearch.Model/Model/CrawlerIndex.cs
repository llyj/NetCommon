using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    public class CrawlerIndex
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid? ID { get; set; }

        /// <summary>
        /// type=1白,type=2黑
        /// </summary>
        public int? Type { get; set; }

        public string IP { get; set; }

        public string UserAgent { get; set; }
        public DateTime? CreateTime { get; set; }

        public string Remark { get; set; }
    }
}