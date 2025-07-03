using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 数据行。
    /// </summary>
    public class FrontRow 
    {

        /// <summary>
        /// 数据单元集合。
        /// </summary>
        [JsonProperty("cell_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrontCell> CellList { get; set; }

        /// <summary>
        /// 将group by的字段拼接成过滤字符串，用于后续点网格点击使用。
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 是否是header信息。
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Header { get; set; }

        /// <summary>
        /// Url跟踪id。
        /// </summary>
        [JsonProperty("tx_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TxId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrontRow {\n");
            sb.Append("  cellList: ").Append(CellList).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  header: ").Append(Header).Append("\n");
            sb.Append("  txId: ").Append(TxId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrontRow);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrontRow input)
        {
            if (input == null) return false;
            if (this.CellList != input.CellList || (this.CellList != null && input.CellList != null && !this.CellList.SequenceEqual(input.CellList))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.Header != input.Header || (this.Header != null && !this.Header.Equals(input.Header))) return false;
            if (this.TxId != input.TxId || (this.TxId != null && !this.TxId.Equals(input.TxId))) return false;

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
                if (this.CellList != null) hashCode = hashCode * 59 + this.CellList.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Header != null) hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.TxId != null) hashCode = hashCode * 59 + this.TxId.GetHashCode();
                return hashCode;
            }
        }
    }
}
