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
    public class ClusterUpgradeAction 
    {

        /// <summary>
        /// 插件配置列表
        /// </summary>
        [JsonProperty("addons", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeAddonConfig> Addons { get; set; }

        /// <summary>
        /// 节点池内节点升级顺序配置。 &gt; key表示节点池ID，默认节点池取值为\&quot;DefaultPool\&quot; 
        /// </summary>
        [JsonProperty("nodeOrder", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<NodePriority>> NodeOrder { get; set; }

        /// <summary>
        /// 节点池升级顺序配置，key/value对格式。 &gt; key表示节点池ID，默认节点池取值为\&quot;DefaultPool\&quot; &gt; value表示对应节点池的优先级，默认值为0，优先级最低，数值越大优先级越高 
        /// </summary>
        [JsonProperty("nodePoolOrder", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> NodePoolOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeStrategy Strategy { get; set; }

        /// <summary>
        /// 目标集群版本，例如\&quot;v1.23\&quot;
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterUpgradeAction {\n");
            sb.Append("  addons: ").Append(Addons).Append("\n");
            sb.Append("  nodeOrder: ").Append(NodeOrder).Append("\n");
            sb.Append("  nodePoolOrder: ").Append(NodePoolOrder).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterUpgradeAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterUpgradeAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addons == input.Addons ||
                    this.Addons != null &&
                    input.Addons != null &&
                    this.Addons.SequenceEqual(input.Addons)
                ) && 
                (
                    this.NodeOrder == input.NodeOrder ||
                    this.NodeOrder != null &&
                    input.NodeOrder != null &&
                    this.NodeOrder.SequenceEqual(input.NodeOrder)
                ) && 
                (
                    this.NodePoolOrder == input.NodePoolOrder ||
                    this.NodePoolOrder != null &&
                    input.NodePoolOrder != null &&
                    this.NodePoolOrder.SequenceEqual(input.NodePoolOrder)
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Addons != null)
                    hashCode = hashCode * 59 + this.Addons.GetHashCode();
                if (this.NodeOrder != null)
                    hashCode = hashCode * 59 + this.NodeOrder.GetHashCode();
                if (this.NodePoolOrder != null)
                    hashCode = hashCode * 59 + this.NodePoolOrder.GetHashCode();
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
