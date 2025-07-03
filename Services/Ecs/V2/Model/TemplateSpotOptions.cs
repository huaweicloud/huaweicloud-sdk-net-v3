using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 竞价计费信息
    /// </summary>
    public class TemplateSpotOptions 
    {

        /// <summary>
        /// 用户愿意为竞价实例每小时支付的最高价格
        /// </summary>
        [JsonProperty("spot_price", NullValueHandling = NullValueHandling.Ignore)]
        public float? SpotPrice { get; set; }

        /// <summary>
        /// 购买的竞价实例时长
        /// </summary>
        [JsonProperty("block_duration_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockDurationMinutes { get; set; }

        /// <summary>
        /// 竞价实例中断策略，当前支持immediate
        /// </summary>
        [JsonProperty("instance_interruption_behavior", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceInterruptionBehavior { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSpotOptions {\n");
            sb.Append("  spotPrice: ").Append(SpotPrice).Append("\n");
            sb.Append("  blockDurationMinutes: ").Append(BlockDurationMinutes).Append("\n");
            sb.Append("  instanceInterruptionBehavior: ").Append(InstanceInterruptionBehavior).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateSpotOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateSpotOptions input)
        {
            if (input == null) return false;
            if (this.SpotPrice != input.SpotPrice || (this.SpotPrice != null && !this.SpotPrice.Equals(input.SpotPrice))) return false;
            if (this.BlockDurationMinutes != input.BlockDurationMinutes || (this.BlockDurationMinutes != null && !this.BlockDurationMinutes.Equals(input.BlockDurationMinutes))) return false;
            if (this.InstanceInterruptionBehavior != input.InstanceInterruptionBehavior || (this.InstanceInterruptionBehavior != null && !this.InstanceInterruptionBehavior.Equals(input.InstanceInterruptionBehavior))) return false;

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
                if (this.SpotPrice != null) hashCode = hashCode * 59 + this.SpotPrice.GetHashCode();
                if (this.BlockDurationMinutes != null) hashCode = hashCode * 59 + this.BlockDurationMinutes.GetHashCode();
                if (this.InstanceInterruptionBehavior != null) hashCode = hashCode * 59 + this.InstanceInterruptionBehavior.GetHashCode();
                return hashCode;
            }
        }
    }
}
