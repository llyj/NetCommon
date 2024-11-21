using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace EasyBom.DataCenter.Model
{
    public class SpotStockDto
    {
        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("PartNo")]
        public string PartNo { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("MFGPartNo")]
        public string MFGPartNo { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("MFG")]
        public string MFG { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("Package")]
        public string Package { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("Distributor")]
        public string Distributor { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("DistributorPartUrl")]
        public string DistributorPartUrl { get; set; }

        /// <summary>
        /// Int32:
        /// </summary>
        [JsonPropertyName("StockNum")]
        public int? StockNum { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// List:
        /// </summary>
        [JsonPropertyName("StepPrice")]
        public List<StepPriceModel> StepPrice { get; set; }

        /// <summary>
        /// Int32:
        /// </summary>
        [JsonPropertyName("MOQ")]
        public int? MOQ { get; set; }

        /// <summary>
        /// Int32:
        /// </summary>
        [JsonPropertyName("Multiples")]
        public int? Multiples { get; set; }

        /// <summary>
        /// Int32:
        /// </summary>
        [JsonPropertyName("MPQ")]
        public int? MPQ { get; set; }

        /// <summary>
        /// String:
        /// </summary>
        [JsonPropertyName("Warehouse")]
        public string Warehouse { get; set; }

    }
}