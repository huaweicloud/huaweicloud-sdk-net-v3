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
    /// 组件节点。
    /// </summary>
    public class TxNode 
    {

        /// <summary>
        /// 节点id。
        /// </summary>
        [JsonProperty("tx_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TxNodeId { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("tx_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TxNodeName { get; set; }

        /// <summary>
        /// 节点类型。
        /// </summary>
        [JsonProperty("tx_node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TxNodeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxNode {\n");
            sb.Append("  txNodeId: ").Append(TxNodeId).Append("\n");
            sb.Append("  txNodeName: ").Append(TxNodeName).Append("\n");
            sb.Append("  txNodeType: ").Append(TxNodeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TxNode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TxNode input)
        {
            if (input == null) return false;
            if (this.TxNodeId != input.TxNodeId || (this.TxNodeId != null && !this.TxNodeId.Equals(input.TxNodeId))) return false;
            if (this.TxNodeName != input.TxNodeName || (this.TxNodeName != null && !this.TxNodeName.Equals(input.TxNodeName))) return false;
            if (this.TxNodeType != input.TxNodeType || (this.TxNodeType != null && !this.TxNodeType.Equals(input.TxNodeType))) return false;

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
                if (this.TxNodeId != null) hashCode = hashCode * 59 + this.TxNodeId.GetHashCode();
                if (this.TxNodeName != null) hashCode = hashCode * 59 + this.TxNodeName.GetHashCode();
                if (this.TxNodeType != null) hashCode = hashCode * 59 + this.TxNodeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
