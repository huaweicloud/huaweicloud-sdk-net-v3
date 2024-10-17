using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点风险来源
    /// </summary>
    public class NodeRisks 
    {

        /// <summary>
        /// 用户节点ID
        /// </summary>
        [JsonProperty("NodeID", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeRisks {\n");
            sb.Append("  nodeID: ").Append(NodeID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeRisks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeRisks input)
        {
            if (input == null) return false;
            if (this.NodeID != input.NodeID || (this.NodeID != null && !this.NodeID.Equals(input.NodeID))) return false;

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
                if (this.NodeID != null) hashCode = hashCode * 59 + this.NodeID.GetHashCode();
                return hashCode;
            }
        }
    }
}
