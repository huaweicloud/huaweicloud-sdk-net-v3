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
    public class HyperNodeStatus 
    {

        /// <summary>
        /// **参数解释** 超节点状态 **取值范围** - provisioning: 创建中。 - active: 整体可用，代表超节点下所有节点都可用。 - partially-available: 超节点下存在不可用节点时会从 active 转成此状态。 - error: 错误状态。 - deleting: 删除中。 - reinstalling: 重置中。 - scaling: 扩容或缩容中。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// **参数解释** 超节点实例 ID
        /// </summary>
        [JsonProperty("instanceID", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceID { get; set; }

        /// <summary>
        /// **参数解释** 超节点下节点总数
        /// </summary>
        [JsonProperty("currentNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentNode { get; set; }

        /// <summary>
        /// **参数解释** 超节点下处于删除中的节点数
        /// </summary>
        [JsonProperty("deletingNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeletingNode { get; set; }

        /// <summary>
        /// **参数解释** 超节点下处于创建中的节点数
        /// </summary>
        [JsonProperty("creatingNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatingNode { get; set; }

        /// <summary>
        /// **参数解释** 超节点下处于可用状态的节点数
        /// </summary>
        [JsonProperty("activeNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveNode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperNodeStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  instanceID: ").Append(InstanceID).Append("\n");
            sb.Append("  currentNode: ").Append(CurrentNode).Append("\n");
            sb.Append("  deletingNode: ").Append(DeletingNode).Append("\n");
            sb.Append("  creatingNode: ").Append(CreatingNode).Append("\n");
            sb.Append("  activeNode: ").Append(ActiveNode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HyperNodeStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperNodeStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.InstanceID != input.InstanceID || (this.InstanceID != null && !this.InstanceID.Equals(input.InstanceID))) return false;
            if (this.CurrentNode != input.CurrentNode || (this.CurrentNode != null && !this.CurrentNode.Equals(input.CurrentNode))) return false;
            if (this.DeletingNode != input.DeletingNode || (this.DeletingNode != null && !this.DeletingNode.Equals(input.DeletingNode))) return false;
            if (this.CreatingNode != input.CreatingNode || (this.CreatingNode != null && !this.CreatingNode.Equals(input.CreatingNode))) return false;
            if (this.ActiveNode != input.ActiveNode || (this.ActiveNode != null && !this.ActiveNode.Equals(input.ActiveNode))) return false;

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
                if (this.InstanceID != null) hashCode = hashCode * 59 + this.InstanceID.GetHashCode();
                if (this.CurrentNode != null) hashCode = hashCode * 59 + this.CurrentNode.GetHashCode();
                if (this.DeletingNode != null) hashCode = hashCode * 59 + this.DeletingNode.GetHashCode();
                if (this.CreatingNode != null) hashCode = hashCode * 59 + this.CreatingNode.GetHashCode();
                if (this.ActiveNode != null) hashCode = hashCode * 59 + this.ActiveNode.GetHashCode();
                return hashCode;
            }
        }
    }
}
