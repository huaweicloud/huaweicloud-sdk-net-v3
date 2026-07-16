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
    /// 资源池资源规格资源量及节点池配置数据模型。
    /// </summary>
    public class PoolResource 
    {

        /// <summary>
        /// **参数解释**：资源规格名称，比如：modelarts.vm.gpu.t4u8。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：规格保障使用量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：资源规格的弹性使用量，物理池该值和count相同[，逻辑池该值大于等于count](tag:hcs,hcso)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("maxCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// **参数解释**：资源池中节点的AZ信息。
        /// </summary>
        [JsonProperty("azs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolNodeAz> Azs { get; set; }

        /// <summary>
        /// **参数解释**：节点池名称。比如：nodePool-1。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("nodePool", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePool { get; set; }

        /// <summary>
        /// **参数解释**：支持给创建出来的节点加taints来设置反亲和性，非特权池不能指定。
        /// </summary>
        [JsonProperty("taints", NullValueHandling = NullValueHandling.Ignore)]
        public List<Taints> Taints { get; set; }

        /// <summary>
        /// **参数解释**：k8s标签，格式为key/value键值对。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// **参数解释**：资源标签，非特权池不能指定。
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
        /// 
        /// </summary>
        [JsonProperty("creatingStep", NullValueHandling = NullValueHandling.Ignore)]
        public CreatingStep CreatingStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rootVolume", NullValueHandling = NullValueHandling.Ignore)]
        public RootVolume RootVolume { get; set; }

        /// <summary>
        /// **参数解释**：自定义数据盘（云硬盘）列表信息。
        /// </summary>
        [JsonProperty("dataVolumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataVolumeItem> DataVolumes { get; set; }

        /// <summary>
        /// **参数解释**：磁盘高级配置。存在自定义数据盘时必须指定对应的高级配置。
        /// </summary>
        [JsonProperty("volumeGroupConfigs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeGroupConfig> VolumeGroupConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public Os Os { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolResource {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  maxCount: ").Append(MaxCount).Append("\n");
            sb.Append("  azs: ").Append(Azs).Append("\n");
            sb.Append("  nodePool: ").Append(NodePool).Append("\n");
            sb.Append("  taints: ").Append(Taints).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  creatingStep: ").Append(CreatingStep).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  volumeGroupConfigs: ").Append(VolumeGroupConfigs).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolResource input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.MaxCount != input.MaxCount || (this.MaxCount != null && !this.MaxCount.Equals(input.MaxCount))) return false;
            if (this.Azs != input.Azs || (this.Azs != null && input.Azs != null && !this.Azs.SequenceEqual(input.Azs))) return false;
            if (this.NodePool != input.NodePool || (this.NodePool != null && !this.NodePool.Equals(input.NodePool))) return false;
            if (this.Taints != input.Taints || (this.Taints != null && input.Taints != null && !this.Taints.SequenceEqual(input.Taints))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Network != input.Network || (this.Network != null && !this.Network.Equals(input.Network))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;
            if (this.CreatingStep != input.CreatingStep || (this.CreatingStep != null && !this.CreatingStep.Equals(input.CreatingStep))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.VolumeGroupConfigs != input.VolumeGroupConfigs || (this.VolumeGroupConfigs != null && input.VolumeGroupConfigs != null && !this.VolumeGroupConfigs.SequenceEqual(input.VolumeGroupConfigs))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.MaxCount != null) hashCode = hashCode * 59 + this.MaxCount.GetHashCode();
                if (this.Azs != null) hashCode = hashCode * 59 + this.Azs.GetHashCode();
                if (this.NodePool != null) hashCode = hashCode * 59 + this.NodePool.GetHashCode();
                if (this.Taints != null) hashCode = hashCode * 59 + this.Taints.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Network != null) hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                if (this.CreatingStep != null) hashCode = hashCode * 59 + this.CreatingStep.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.VolumeGroupConfigs != null) hashCode = hashCode * 59 + this.VolumeGroupConfigs.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                return hashCode;
            }
        }
    }
}
