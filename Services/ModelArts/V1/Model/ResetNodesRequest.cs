using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResetNodesRequest 
    {

        /// <summary>
        /// **参数解释**：需要重置的节点名称列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("nodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rollingConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ResetNodesRequestRollingConfig RollingConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ResetNodesRequestNodeConfig NodeConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetNodesRequest {\n");
            sb.Append("  nodeNames: ").Append(NodeNames).Append("\n");
            sb.Append("  rollingConfig: ").Append(RollingConfig).Append("\n");
            sb.Append("  nodeConfig: ").Append(NodeConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetNodesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetNodesRequest input)
        {
            if (input == null) return false;
            if (this.NodeNames != input.NodeNames || (this.NodeNames != null && input.NodeNames != null && !this.NodeNames.SequenceEqual(input.NodeNames))) return false;
            if (this.RollingConfig != input.RollingConfig || (this.RollingConfig != null && !this.RollingConfig.Equals(input.RollingConfig))) return false;
            if (this.NodeConfig != input.NodeConfig || (this.NodeConfig != null && !this.NodeConfig.Equals(input.NodeConfig))) return false;

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
                if (this.NodeNames != null) hashCode = hashCode * 59 + this.NodeNames.GetHashCode();
                if (this.RollingConfig != null) hashCode = hashCode * 59 + this.RollingConfig.GetHashCode();
                if (this.NodeConfig != null) hashCode = hashCode * 59 + this.NodeConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
