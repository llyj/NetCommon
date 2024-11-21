using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCommon.ElasticSearch.Model
{
    /// <summary>
    /// 抽象价格
    /// </summary>
    public class AbstractPrice
    {
        public int ProductID { get; set; }
        public int? MallQty { get; set; }
        public string Currency { get; set; }
        public int? Qty1 { get; set; }
        public decimal? Price1 { get; set; }
        public int? Qty2 { get; set; }
        public decimal? Price2 { get; set; }
        public int? Qty3 { get; set; }
        public decimal? Price3 { get; set; }
        public int? Qty4 { get; set; }
        public decimal? Price4 { get; set; }
        public int? Qty5 { get; set; }
        public decimal? Price5 { get; set; }
        public int? Qty6 { get; set; }
        public decimal? Price6 { get; set; }
        public int? Qty7 { get; set; }
        public decimal? Price7 { get; set; }
        public int? Qty8 { get; set; }
        public decimal? Price8 { get; set; }

        /// <summary>
        /// 最小起订量
        /// </summary>
        public int? MOQ { get; set; } = 1;

        /// <summary>
        /// 标准包装数
        /// </summary>
        public int? SPQ { get; set; } = 1;

        /// <summary>
        /// 启用最小起订量
        /// </summary>
        public bool EnabledMOQ { get; set; }

        /// <summary>
        /// 启用标准包装数
        /// </summary>
        public bool EnabledSPQ { get; set; }
    }
}