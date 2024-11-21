using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model.Model
{
    public class ViewedRecordIndex
    {
        public string PID_UID { get; set; }
        public int? ProductID { get; set; }
        public Guid? UID { get; set; }
        /// <summary>
        /// 型号
        /// </summary>

        public string PartNo { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>

        public string MFG { get; set; }

        public string IP { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}