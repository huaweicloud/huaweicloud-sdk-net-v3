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
    /// 扩展伸缩组弹性伸缩配置
    /// </summary>
    public class ScaleGroupAutoscaling 
    {

        /// <summary>
        /// 伸缩组弹性扩缩容启用开关，默认不开启
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 伸缩组优先级，未设置则默认为0，数值越大优先级越高
        /// </summary>
        [JsonProperty("extensionPriority", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtensionPriority { get; set; }

        /// <summary>
        /// 弹性伸缩时，伸缩组最少应保持的节点数量，必须大于0
        /// </summary>
        [JsonProperty("minNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinNodeCount { get; set; }

        /// <summary>
        /// 弹性伸缩时，伸缩组最多可保持的节点数量，应大于等于 **minNodeCount**, 不可大于集群规格所允许的节点上限，不可大于节点池节点数量上限
        /// </summary>
        [JsonProperty("maxNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxNodeCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleGroupAutoscaling {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  extensionPriority: ").Append(ExtensionPriority).Append("\n");
            sb.Append("  minNodeCount: ").Append(MinNodeCount).Append("\n");
            sb.Append("  maxNodeCount: ").Append(MaxNodeCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleGroupAutoscaling);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleGroupAutoscaling input)
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
                    this.ExtensionPriority == input.ExtensionPriority ||
                    (this.ExtensionPriority != null &&
                    this.ExtensionPriority.Equals(input.ExtensionPriority))
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
                if (this.ExtensionPriority != null)
                    hashCode = hashCode * 59 + this.ExtensionPriority.GetHashCode();
                if (this.MinNodeCount != null)
                    hashCode = hashCode * 59 + this.MinNodeCount.GetHashCode();
                if (this.MaxNodeCount != null)
                    hashCode = hashCode * 59 + this.MaxNodeCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
