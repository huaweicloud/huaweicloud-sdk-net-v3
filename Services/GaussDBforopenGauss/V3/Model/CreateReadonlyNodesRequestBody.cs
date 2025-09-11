using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateReadonlyNodesRequestBody 
    {

        /// <summary>
        /// **参数解释**: 新创建只读节点在各可用区的分布情况。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("node_distribution", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeDistributionOption> NodeDistribution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReadonlyNodesRequestBody {\n");
            sb.Append("  nodeDistribution: ").Append(NodeDistribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateReadonlyNodesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateReadonlyNodesRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeDistribution != input.NodeDistribution || (this.NodeDistribution != null && input.NodeDistribution != null && !this.NodeDistribution.SequenceEqual(input.NodeDistribution))) return false;

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
                if (this.NodeDistribution != null) hashCode = hashCode * 59 + this.NodeDistribution.GetHashCode();
                return hashCode;
            }
        }
    }
}
