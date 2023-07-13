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
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.MinNodeCount == input.MinNodeCount ||
                    (this.MinNodeCount != null &&
                    this.MinNodeCount.Equals(input.MinNodeCount))
                ) && 
                (
                    this.MaxNodeCount == input.MaxNodeCount ||
                    (this.MaxNodeCount != null &&
                    this.MaxNodeCount.Equals(input.MaxNodeCount))
                ) && 
                (
                    this.ScaleDownCooldownTime == input.ScaleDownCooldownTime ||
                    (this.ScaleDownCooldownTime != null &&
                    this.ScaleDownCooldownTime.Equals(input.ScaleDownCooldownTime))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.MinNodeCount != null)
                    hashCode = hashCode * 59 + this.MinNodeCount.GetHashCode();
                if (this.MaxNodeCount != null)
                    hashCode = hashCode * 59 + this.MaxNodeCount.GetHashCode();
                if (this.ScaleDownCooldownTime != null)
                    hashCode = hashCode * 59 + this.ScaleDownCooldownTime.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
