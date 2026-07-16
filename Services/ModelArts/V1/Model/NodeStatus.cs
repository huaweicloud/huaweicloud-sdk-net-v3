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
    /// 节点状态数据模型。
    /// </summary>
    public class NodeStatus 
    {

        /// <summary>
        /// **参数解释**：节点当前状态。 **取值范围**：可选值如下： - Available：节点可用。 - Creating：节点创建中。 - Deleting：节点删除中。 - Abnormal：节点异常。 - Checking: 节点自检中。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// **参数解释**：节点所在的az。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// **参数解释**：节点的IP地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("privateIp", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public NodeResource Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("availableResources", NullValueHandling = NullValueHandling.Ignore)]
        public NodeResource AvailableResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  availableResources: ").Append(AvailableResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.Az != input.Az || (this.Az != null && !this.Az.Equals(input.Az))) return false;
            if (this.PrivateIp != input.PrivateIp || (this.PrivateIp != null && !this.PrivateIp.Equals(input.PrivateIp))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && !this.Resources.Equals(input.Resources))) return false;
            if (this.AvailableResources != input.AvailableResources || (this.AvailableResources != null && !this.AvailableResources.Equals(input.AvailableResources))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Az != null) hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.PrivateIp != null) hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.AvailableResources != null) hashCode = hashCode * 59 + this.AvailableResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
