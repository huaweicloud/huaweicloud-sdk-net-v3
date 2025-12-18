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
    /// 同步点池请求详细参数
    /// </summary>
    public class NodePoolUpgradeSpec 
    {

        /// <summary>
        /// **参数解释**： 每批最大同步节点。节点升级时，允许节点不可用的最大数量。节点重置方式进行同步时节点将不可用，请合理设置该参数，尽量避免出现集群节点不可用数量过多导致Pod无法调度的情况。 **约束限制**： 不涉及 **取值范围**： 取值范围[1-20] **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("maxUnavailable", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxUnavailable { get; set; }

        /// <summary>
        /// Pod无法驱逐时，是否强制重置。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("retryTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("skippedNodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SkippedNodes { get; set; }

        /// <summary>
        /// **参数解释**： 本次操作同步的节点池中选择的节点ID列表，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("nodeIDs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeIDs { get; set; }

        /// <summary>
        /// **参数解释**： 节点池ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("nodePoolID", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePoolID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplate NodeTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolUpgradeSpec {\n");
            sb.Append("  maxUnavailable: ").Append(MaxUnavailable).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  retryTimes: ").Append(RetryTimes).Append("\n");
            sb.Append("  skippedNodes: ").Append(SkippedNodes).Append("\n");
            sb.Append("  nodeIDs: ").Append(NodeIDs).Append("\n");
            sb.Append("  nodePoolID: ").Append(NodePoolID).Append("\n");
            sb.Append("  nodeTemplate: ").Append(NodeTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolUpgradeSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolUpgradeSpec input)
        {
            if (input == null) return false;
            if (this.MaxUnavailable != input.MaxUnavailable || (this.MaxUnavailable != null && !this.MaxUnavailable.Equals(input.MaxUnavailable))) return false;
            if (this.Force != input.Force || (this.Force != null && !this.Force.Equals(input.Force))) return false;
            if (this.RetryTimes != input.RetryTimes || (this.RetryTimes != null && !this.RetryTimes.Equals(input.RetryTimes))) return false;
            if (this.SkippedNodes != input.SkippedNodes || (this.SkippedNodes != null && input.SkippedNodes != null && !this.SkippedNodes.SequenceEqual(input.SkippedNodes))) return false;
            if (this.NodeIDs != input.NodeIDs || (this.NodeIDs != null && input.NodeIDs != null && !this.NodeIDs.SequenceEqual(input.NodeIDs))) return false;
            if (this.NodePoolID != input.NodePoolID || (this.NodePoolID != null && !this.NodePoolID.Equals(input.NodePoolID))) return false;
            if (this.NodeTemplate != input.NodeTemplate || (this.NodeTemplate != null && !this.NodeTemplate.Equals(input.NodeTemplate))) return false;

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
                if (this.MaxUnavailable != null) hashCode = hashCode * 59 + this.MaxUnavailable.GetHashCode();
                if (this.Force != null) hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.RetryTimes != null) hashCode = hashCode * 59 + this.RetryTimes.GetHashCode();
                if (this.SkippedNodes != null) hashCode = hashCode * 59 + this.SkippedNodes.GetHashCode();
                if (this.NodeIDs != null) hashCode = hashCode * 59 + this.NodeIDs.GetHashCode();
                if (this.NodePoolID != null) hashCode = hashCode * 59 + this.NodePoolID.GetHashCode();
                if (this.NodeTemplate != null) hashCode = hashCode * 59 + this.NodeTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
