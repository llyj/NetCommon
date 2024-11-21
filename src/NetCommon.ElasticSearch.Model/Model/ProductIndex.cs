namespace NetCommon.ElasticSearch.Model
{
    public class ProductIndex
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public int? ProductID { get; set; }

        /// <summary>
        /// 型号
        /// </summary>
        public string PartNo { get; set; }

        /// <summary>
        /// 自定义型号
        /// </summary>
        public string JakPartNo { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        public int? MFGID { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string MFG { get; set; }

        /// <summary>
        ///  品牌别名
        /// </summary>
        public string CMFG { get; set; }

        /// <summary>
        /// 封装
        /// </summary>
        public string Package { get; set; }

        public string DateCode { get; set; }

        public int CategoryID { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string PicUrl { get; set; }

        public string PdfUrl { get; set; }

        public int? MallQty { get; set; }

        public int? MOQ { get; set; } = 1;

        public int? SPQ { get; set; } = 1;

        public string Currency { get; set; }

        /// <summary>
        /// 货期
        /// </summary>
        public string LeadTime { get; set; }

        /// <summary>
        /// 是否启用期货库存
        /// </summary>
        public bool EnabledLeadTimeQty { get; set; }

        /// <summary>
        /// 期货数量
        /// </summary>
        public int LeadTimeQty { get; set; }

        public bool? IsRoHS { get; set; }

        /// <summary>
        ///  父级分类
        /// </summary>
        public string ParentCategory { get; set; }

        /// <summary>
        ///  分类自定义
        /// </summary>
        public string CategoryCustomName { get; set; }
    }
}