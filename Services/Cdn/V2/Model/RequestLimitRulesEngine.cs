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
    /// **参数解释：** 请求限速，将用户请求速度限制在指定范围内，一定程度上减少突发高带宽风险，节省成本 **约束限制：** 不涉及
    /// </summary>
    public class RequestLimitRulesEngine 
    {

        /// <summary>
        /// **参数解释：** 限速条件 &gt; 例如：type&#x3D;size，limit_rate_after&#x3D;50表示从传输50个字节后开始限速且限速值为limit_rate_value  **约束限制：** 不涉及 **取值范围：** 0-1073741824，单位：byte **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("limit_rate_after", NullValueHandling = NullValueHandling.Ignore)]
        public long? LimitRateAfter { get; set; }

        /// <summary>
        /// **参数解释：** 限速值，即达到限速条件后的最大访问速度 **约束限制：** 不涉及 **取值范围：** 0-104857600，单位：Bps **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("limit_rate_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitRateValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestLimitRulesEngine {\n");
            sb.Append("  limitRateAfter: ").Append(LimitRateAfter).Append("\n");
            sb.Append("  limitRateValue: ").Append(LimitRateValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestLimitRulesEngine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequestLimitRulesEngine input)
        {
            if (input == null) return false;
            if (this.LimitRateAfter != input.LimitRateAfter || (this.LimitRateAfter != null && !this.LimitRateAfter.Equals(input.LimitRateAfter))) return false;
            if (this.LimitRateValue != input.LimitRateValue || (this.LimitRateValue != null && !this.LimitRateValue.Equals(input.LimitRateValue))) return false;

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
                if (this.LimitRateAfter != null) hashCode = hashCode * 59 + this.LimitRateAfter.GetHashCode();
                if (this.LimitRateValue != null) hashCode = hashCode * 59 + this.LimitRateValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
