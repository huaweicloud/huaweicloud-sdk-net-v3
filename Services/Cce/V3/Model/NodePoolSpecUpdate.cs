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
        /// **参数解释：** 节点池期望节点个数。 **约束限制：** 更新节点池时，此字段为必填字段。 &gt; 注意：如果更新节点池时不填此字段，节点池期望节点个数将取默认值0，如果此时节点池节点个数大于0将导致节点池缩容。  **取值范围：** 大于0，小于集群节点规模。 **默认取值：** 0
        /// </summary>
        [JsonProperty("initialNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialNodeCount { get; set; }

        /// <summary>
        /// **参数解释：** 该参数用于控制更新节点池时 **节点池期望节点个数(spec.initialNodeCount)** 的默认行为。当该参数未设置或者为false时，如果用户请求Body体中未设置spec.initialNodeCount，更新时将自动初始化spec.initialNodeCount为0。当该参数为true时，将忽略spec.initialNodeCount参数。 &gt; 当用户不需要更新节点池spec.initialNodeCount时，必须显示的设置该参数为true，同时在更新节点池Body体中不设置spec.initialNodeCount。  **约束限制：** 不涉及 **取值范围：** - false：更新节点池时，如果spec.initialNodeCount参数未设置，将初始化spec.initialNodeCount为0。 &gt; 如果节点池当前spec.initialNodeCount 不等于0将导致节点池缩容。  - true：更新节点池时，忽略spec.initialNodeCount参数，节点池spec.initialNodeCount参数将保持原样。  **默认取值：** false
        /// </summary>
        [JsonProperty("ignoreInitialNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreInitialNodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public NodePoolNodeAutoscaling Autoscaling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeManagementUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeManagement NodeManagementUpdate { get; set; }

        /// <summary>
        /// **参数解释：** 是否同步K8S污点。 **约束限制**： 不涉及 **取值范围：** - 填写为refresh，K8S污点的改动将会被同步更新到存量节点上。 - 填写为ignore，节点池K8S污点将不会同步更新到存量节点上。  **默认取值：** 无
        /// </summary>
        [JsonProperty("taintPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string TaintPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释：** 是否同步K8S标签。 **约束限制**： 不涉及 **取值范围：** - 填写为refresh，K8S标签的改动将会被同步更新到存量节点上。 - 填写为ignore，K8S标签将不会同步更新到存量节点上。  **默认取值：** 无
        /// </summary>
        [JsonProperty("labelPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释：** 是否同步节点池资源标签。 **约束限制**： 不涉及 **取值范围：** - 填写为refresh，节点池资源标签标签的改动将会被同步更新到存量节点上。 - 填写为ignore，节点池资源标签标签将不会同步更新到存量节点上。  **默认取值：** 无
        /// </summary>
        [JsonProperty("userTagsPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string UserTagsPolicyOnExistingNodes { get; set; }

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
            sb.Append("  ignoreInitialNodeCount: ").Append(IgnoreInitialNodeCount).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  nodeManagementUpdate: ").Append(NodeManagementUpdate).Append("\n");
            sb.Append("  taintPolicyOnExistingNodes: ").Append(TaintPolicyOnExistingNodes).Append("\n");
            sb.Append("  labelPolicyOnExistingNodes: ").Append(LabelPolicyOnExistingNodes).Append("\n");
            sb.Append("  userTagsPolicyOnExistingNodes: ").Append(UserTagsPolicyOnExistingNodes).Append("\n");
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
            if (this.IgnoreInitialNodeCount != input.IgnoreInitialNodeCount || (this.IgnoreInitialNodeCount != null && !this.IgnoreInitialNodeCount.Equals(input.IgnoreInitialNodeCount))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;
            if (this.NodeManagementUpdate != input.NodeManagementUpdate || (this.NodeManagementUpdate != null && !this.NodeManagementUpdate.Equals(input.NodeManagementUpdate))) return false;
            if (this.TaintPolicyOnExistingNodes != input.TaintPolicyOnExistingNodes || (this.TaintPolicyOnExistingNodes != null && !this.TaintPolicyOnExistingNodes.Equals(input.TaintPolicyOnExistingNodes))) return false;
            if (this.LabelPolicyOnExistingNodes != input.LabelPolicyOnExistingNodes || (this.LabelPolicyOnExistingNodes != null && !this.LabelPolicyOnExistingNodes.Equals(input.LabelPolicyOnExistingNodes))) return false;
            if (this.UserTagsPolicyOnExistingNodes != input.UserTagsPolicyOnExistingNodes || (this.UserTagsPolicyOnExistingNodes != null && !this.UserTagsPolicyOnExistingNodes.Equals(input.UserTagsPolicyOnExistingNodes))) return false;
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
                if (this.IgnoreInitialNodeCount != null) hashCode = hashCode * 59 + this.IgnoreInitialNodeCount.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.NodeManagementUpdate != null) hashCode = hashCode * 59 + this.NodeManagementUpdate.GetHashCode();
                if (this.TaintPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.TaintPolicyOnExistingNodes.GetHashCode();
                if (this.LabelPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.LabelPolicyOnExistingNodes.GetHashCode();
                if (this.UserTagsPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.UserTagsPolicyOnExistingNodes.GetHashCode();
                if (this.ExtensionScaleGroups != null) hashCode = hashCode * 59 + this.ExtensionScaleGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
