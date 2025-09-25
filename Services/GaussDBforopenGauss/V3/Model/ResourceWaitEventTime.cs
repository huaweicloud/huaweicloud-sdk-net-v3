using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceWaitEventTime 
    {

        /// <summary>
        /// **参数解释**: 总耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("all_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_wait_event_time_details", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceWaitEvenTimeDetails ResourceWaitEventTimeDetails { get; set; }

        /// <summary>
        /// **参数解释**: 资源类等待事件外耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("other_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceWaitEventTime {\n");
            sb.Append("  allTime: ").Append(AllTime).Append("\n");
            sb.Append("  resourceWaitEventTimeDetails: ").Append(ResourceWaitEventTimeDetails).Append("\n");
            sb.Append("  otherTime: ").Append(OtherTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceWaitEventTime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceWaitEventTime input)
        {
            if (input == null) return false;
            if (this.AllTime != input.AllTime || (this.AllTime != null && !this.AllTime.Equals(input.AllTime))) return false;
            if (this.ResourceWaitEventTimeDetails != input.ResourceWaitEventTimeDetails || (this.ResourceWaitEventTimeDetails != null && !this.ResourceWaitEventTimeDetails.Equals(input.ResourceWaitEventTimeDetails))) return false;
            if (this.OtherTime != input.OtherTime || (this.OtherTime != null && !this.OtherTime.Equals(input.OtherTime))) return false;

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
                if (this.AllTime != null) hashCode = hashCode * 59 + this.AllTime.GetHashCode();
                if (this.ResourceWaitEventTimeDetails != null) hashCode = hashCode * 59 + this.ResourceWaitEventTimeDetails.GetHashCode();
                if (this.OtherTime != null) hashCode = hashCode * 59 + this.OtherTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
