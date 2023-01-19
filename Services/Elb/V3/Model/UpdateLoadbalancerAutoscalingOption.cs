using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 弹性扩缩容配置信息。负载均衡器配置并开启弹性扩缩容后，可根据负载情况自动调整负载均衡器的规格。  使用说明： - 仅当租户白名单放开后该字段才有效 - 开启弹性扩缩容后，l4_flavor_id和l7_flavor_id表示该LB实例弹性规格的上限。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42,fcs)
    /// </summary>
    public class UpdateLoadbalancerAutoscalingOption 
    {

        /// <summary>
        /// 当前负载均衡器是否开启弹性扩缩容。  取值： - true：开启。 - false：不开启。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 弹性扩缩容的最小七层规格ID（规格类型L7_elastic），有七层监听器时，该字段不能为空。
        /// </summary>
        [JsonProperty("min_l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MinL7FlavorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoadbalancerAutoscalingOption {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  minL7FlavorId: ").Append(MinL7FlavorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoadbalancerAutoscalingOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoadbalancerAutoscalingOption input)
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
                    this.MinL7FlavorId == input.MinL7FlavorId ||
                    (this.MinL7FlavorId != null &&
                    this.MinL7FlavorId.Equals(input.MinL7FlavorId))
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
                if (this.MinL7FlavorId != null)
                    hashCode = hashCode * 59 + this.MinL7FlavorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
