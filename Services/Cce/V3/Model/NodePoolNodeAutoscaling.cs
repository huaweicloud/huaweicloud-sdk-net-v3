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
    /// 节点池自动伸缩相关配置
    /// </summary>
    public class NodePoolNodeAutoscaling 
    {

        /// <summary>
        /// 是否开启自动扩缩容
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 若开启自动扩缩容，最小能缩容的节点个数。不可大于集群规格所允许的节点上限
        /// </summary>
        [JsonProperty("minNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinNodeCount { get; set; }

        /// <summary>
        /// 若开启自动扩缩容，最大能扩容的节点个数，应大于等于 minNodeCount，且不超过集群规格对应的节点数量上限。
        /// </summary>
        [JsonProperty("maxNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNodeCount { get; set; }

        /// <summary>
        /// 节点保留时间，单位为分钟，扩容出来的节点在这个时间内不会被缩掉
        /// </summary>
        [JsonProperty("scaleDownCooldownTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScaleDownCooldownTime { get; set; }

        /// <summary>
        /// 节点池权重，更高的权重在扩容时拥有更高的优先级
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释**： 缩容非必要时间。单位为分钟，该参数用于指定在确定可以进行缩容操作之前，节点处于不需要状态的持续时间。 当节点在指定的这段时间内一直处于不需要的状态时，autoscaler 插件才会考虑对其进行缩容操作。 这样可以避免因资源的短暂波动而频繁触发缩容，增强系统的稳定性。如果未设置该参数，autoscaler 插件插件会使用默认的时间阈值。 **约束限制**： 不涉及 **取值范围**： 0-2147483647。 &gt; 注意：如果传值为-1，代表取值为空。  **默认取值**： 默认为空
        /// </summary>
        [JsonProperty("scaleDownUnneededTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScaleDownUnneededTime { get; set; }

        /// <summary>
        /// **参数解释**： 缩容利用率阈值。运行在该节点上的所有 Pod 的 CPU 或内存总和除以该节点相应的可分配资源， 当该比值低于此阈值时，该节点可被考虑进行缩容。例如，设置为 0.3 表示当资源利用率低于 30% 时， 会触发缩容操作的评估。如果未设置该参数，autoscaler 插件会使用默认的利用率阈值。 **约束限制**： 不涉及 **取值范围**： 0-1。 &gt; 注意：如果传值为-1，代表取值为空。  **默认取值**： 默认为空
        /// </summary>
        [JsonProperty("scaleDownUtilizationThreshold", NullValueHandling = NullValueHandling.Ignore)]
        public float? ScaleDownUtilizationThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolNodeAutoscaling {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  minNodeCount: ").Append(MinNodeCount).Append("\n");
            sb.Append("  maxNodeCount: ").Append(MaxNodeCount).Append("\n");
            sb.Append("  scaleDownCooldownTime: ").Append(ScaleDownCooldownTime).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  scaleDownUnneededTime: ").Append(ScaleDownUnneededTime).Append("\n");
            sb.Append("  scaleDownUtilizationThreshold: ").Append(ScaleDownUtilizationThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolNodeAutoscaling);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolNodeAutoscaling input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.MinNodeCount != input.MinNodeCount || (this.MinNodeCount != null && !this.MinNodeCount.Equals(input.MinNodeCount))) return false;
            if (this.MaxNodeCount != input.MaxNodeCount || (this.MaxNodeCount != null && !this.MaxNodeCount.Equals(input.MaxNodeCount))) return false;
            if (this.ScaleDownCooldownTime != input.ScaleDownCooldownTime || (this.ScaleDownCooldownTime != null && !this.ScaleDownCooldownTime.Equals(input.ScaleDownCooldownTime))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.ScaleDownUnneededTime != input.ScaleDownUnneededTime || (this.ScaleDownUnneededTime != null && !this.ScaleDownUnneededTime.Equals(input.ScaleDownUnneededTime))) return false;
            if (this.ScaleDownUtilizationThreshold != input.ScaleDownUtilizationThreshold || (this.ScaleDownUtilizationThreshold != null && !this.ScaleDownUtilizationThreshold.Equals(input.ScaleDownUtilizationThreshold))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.MinNodeCount != null) hashCode = hashCode * 59 + this.MinNodeCount.GetHashCode();
                if (this.MaxNodeCount != null) hashCode = hashCode * 59 + this.MaxNodeCount.GetHashCode();
                if (this.ScaleDownCooldownTime != null) hashCode = hashCode * 59 + this.ScaleDownCooldownTime.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ScaleDownUnneededTime != null) hashCode = hashCode * 59 + this.ScaleDownUnneededTime.GetHashCode();
                if (this.ScaleDownUtilizationThreshold != null) hashCode = hashCode * 59 + this.ScaleDownUtilizationThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
