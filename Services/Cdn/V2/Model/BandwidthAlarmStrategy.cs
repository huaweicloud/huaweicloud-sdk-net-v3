using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 带宽告警策略，当带宽达到告警阈值时，发送告警通知 **约束限制：** 不涉及
    /// </summary>
    public class BandwidthAlarmStrategy 
    {

        /// <summary>
        /// **参数解释：** 带宽告警开关 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭  **默认取值：** off: 关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 带宽告警阈值，单位：bit/s **约束限制：** - status为on时必填  **取值范围：** 1000000-10000000000000 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthAlarmStrategy {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthAlarmStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthAlarmStrategy input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
