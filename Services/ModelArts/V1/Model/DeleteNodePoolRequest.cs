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
    /// Request Object
    /// </summary>
    public class DeleteNodePoolRequest 
    {

        /// <summary>
        /// **参数解释**：资源池名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("pool_name", IsPath = true)]
        [JsonProperty("pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// **参数解释**：节点池名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("nodepool_name", IsPath = true)]
        [JsonProperty("nodepool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodepoolName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNodePoolRequest {\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("  nodepoolName: ").Append(NodepoolName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNodePoolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNodePoolRequest input)
        {
            if (input == null) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;
            if (this.NodepoolName != input.NodepoolName || (this.NodepoolName != null && !this.NodepoolName.Equals(input.NodepoolName))) return false;

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
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.NodepoolName != null) hashCode = hashCode * 59 + this.NodepoolName.GetHashCode();
                return hashCode;
            }
        }
    }
}
