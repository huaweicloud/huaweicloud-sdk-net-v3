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
    /// 跨资源池迁移节点时目标资源池中节点的配置。
    /// </summary>
    public class MigrateResourceSpec 
    {

        /// <summary>
        /// **参数解释**：资源规格名称，跨资源池迁移时该参数必传。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creatingStep", NullValueHandling = NullValueHandling.Ignore)]
        public CreatingStep CreatingStep { get; set; }

        /// <summary>
        /// **参数解释**：资源迁移的目标节点池名称。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("nodePool", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rootVolume", NullValueHandling = NullValueHandling.Ignore)]
        public RootVolume RootVolume { get; set; }

        /// <summary>
        /// **参数解释**：目标节点池的数据盘盘信息，新建节点池时有效。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("dataVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataVolumeItem> DataVolumes { get; set; }

        /// <summary>
        /// **参数解释**：磁盘高级配置。存在自定义数据盘时必须指定对应的高级配置，新建节点池时有效。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("volumeGroupConfigs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeGroupConfig> VolumeGroupConfigs { get; set; }

        /// <summary>
        /// **参数解释**：k8s标签，格式为key/value键值对，非特权池不能指定。新建节点池时有效。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// **参数解释**：支持给创建出来的节点加taints来设置反亲和性，非特权池不能指定。新建节点池时有效。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taints> Taints { get; set; }

        /// <summary>
        /// **参数解释**：资源标签。新建节点池时有效。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTags> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public NodeNetwork Network { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParams", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceExtendParams ExtendParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateResourceSpec {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  creatingStep: ").Append(CreatingStep).Append("\n");
            sb.Append("  nodePool: ").Append(NodePool).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  volumeGroupConfigs: ").Append(VolumeGroupConfigs).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateResourceSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateResourceSpec input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.CreatingStep != input.CreatingStep || (this.CreatingStep != null && !this.CreatingStep.Equals(input.CreatingStep))) return false;
            if (this.NodePool != input.NodePool || (this.NodePool != null && !this.NodePool.Equals(input.NodePool))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.VolumeGroupConfigs != input.VolumeGroupConfigs || (this.VolumeGroupConfigs != null && input.VolumeGroupConfigs != null && !this.VolumeGroupConfigs.SequenceEqual(input.VolumeGroupConfigs))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Taints != input.Taints || (this.Taints != null && input.Taints != null && !this.Taints.SequenceEqual(input.Taints))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Network != input.Network || (this.Network != null && !this.Network.Equals(input.Network))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.CreatingStep != null) hashCode = hashCode * 59 + this.CreatingStep.GetHashCode();
                if (this.NodePool != null) hashCode = hashCode * 59 + this.NodePool.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.VolumeGroupConfigs != null) hashCode = hashCode * 59 + this.VolumeGroupConfigs.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Taints != null) hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Network != null) hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
