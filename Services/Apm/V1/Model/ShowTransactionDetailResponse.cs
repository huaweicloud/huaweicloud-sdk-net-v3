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
    /// Response Object
    /// </summary>
    public class ShowTransactionDetailResponse : SdkResponse
    {

        /// <summary>
        /// 组件节点列表。
        /// </summary>
        [JsonProperty("tx_node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TxNode> TxNodeList { get; set; }

        /// <summary>
        /// 组件之间调用指向线列表。
        /// </summary>
        [JsonProperty("tx_line_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TxLine> TxLineList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTransactionDetailResponse {\n");
            sb.Append("  txNodeList: ").Append(TxNodeList).Append("\n");
            sb.Append("  txLineList: ").Append(TxLineList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTransactionDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTransactionDetailResponse input)
        {
            if (input == null) return false;
            if (this.TxNodeList != input.TxNodeList || (this.TxNodeList != null && input.TxNodeList != null && !this.TxNodeList.SequenceEqual(input.TxNodeList))) return false;
            if (this.TxLineList != input.TxLineList || (this.TxLineList != null && input.TxLineList != null && !this.TxLineList.SequenceEqual(input.TxLineList))) return false;

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
                if (this.TxNodeList != null) hashCode = hashCode * 59 + this.TxNodeList.GetHashCode();
                if (this.TxLineList != null) hashCode = hashCode * 59 + this.TxLineList.GetHashCode();
                return hashCode;
            }
        }
    }
}
