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
    /// 
    /// </summary>
    public class NodePoolSpecUpdate 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSpecUpdate NodeTemplate { get; set; }

        /// <summary>
        /// 节点池初始化节点个数。查询时为节点池目标节点数量。默认值为0。
        /// </summary>
        [JsonProperty("initialNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialNodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public NodePoolNodeAutoscaling Autoscaling { get; set; }

        /// <summary>
        /// 节点池扩展伸缩组配置列表，详情参见ExtensionScaleGroup类型定义
        /// </summary>
        [JsonProperty("extensionScaleGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionScaleGroup> ExtensionScaleGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolSpecUpdate {\n");
            sb.Append("  nodeTemplate: ").Append(NodeTemplate).Append("\n");
            sb.Append("  initialNodeCount: ").Append(InitialNodeCount).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  extensionScaleGroups: ").Append(ExtensionScaleGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolSpecUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolSpecUpdate input)
        {
            if (input == null) return false;
            if (this.NodeTemplate != input.NodeTemplate || (this.NodeTemplate != null && !this.NodeTemplate.Equals(input.NodeTemplate))) return false;
            if (this.InitialNodeCount != input.InitialNodeCount || (this.InitialNodeCount != null && !this.InitialNodeCount.Equals(input.InitialNodeCount))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;
            if (this.ExtensionScaleGroups != input.ExtensionScaleGroups || (this.ExtensionScaleGroups != null && input.ExtensionScaleGroups != null && !this.ExtensionScaleGroups.SequenceEqual(input.ExtensionScaleGroups))) return false;

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
                if (this.NodeTemplate != null) hashCode = hashCode * 59 + this.NodeTemplate.GetHashCode();
                if (this.InitialNodeCount != null) hashCode = hashCode * 59 + this.InitialNodeCount.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.ExtensionScaleGroups != null) hashCode = hashCode * 59 + this.ExtensionScaleGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
