using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BankReceiptDict 
    {

        /// <summary>
        /// 键值对数量 
        /// </summary>
        [JsonProperty("kv_pair_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? KvPairCount { get; set; }

        /// <summary>
        /// 银行回单的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("bank_receipt_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> BankReceiptLocation { get; set; }

        /// <summary>
        /// 键值对识别结果列表。 
        /// </summary>
        [JsonProperty("kv_pair_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BankReceiptKvPair> KvPairList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankReceiptDict {\n");
            sb.Append("  kvPairCount: ").Append(KvPairCount).Append("\n");
            sb.Append("  bankReceiptLocation: ").Append(BankReceiptLocation).Append("\n");
            sb.Append("  kvPairList: ").Append(KvPairList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BankReceiptDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BankReceiptDict input)
        {
            if (input == null) return false;
            if (this.KvPairCount != input.KvPairCount || (this.KvPairCount != null && !this.KvPairCount.Equals(input.KvPairCount))) return false;
            if (this.BankReceiptLocation != input.BankReceiptLocation || (this.BankReceiptLocation != null && input.BankReceiptLocation != null && !this.BankReceiptLocation.SequenceEqual(input.BankReceiptLocation))) return false;
            if (this.KvPairList != input.KvPairList || (this.KvPairList != null && input.KvPairList != null && !this.KvPairList.SequenceEqual(input.KvPairList))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.KvPairCount != null) hashCode = hashCode * 59 + this.KvPairCount.GetHashCode();
                if (this.BankReceiptLocation != null) hashCode = hashCode * 59 + this.BankReceiptLocation.GetHashCode();
                if (this.KvPairList != null) hashCode = hashCode * 59 + this.KvPairList.GetHashCode();
                return hashCode;
            }
        }
    }
}
