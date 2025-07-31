using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttackTrendRespBody 
    {

        /// <summary>
        /// **参数解释**： 阻断次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? DenyCount { get; set; }

        /// <summary>
        /// **参数解释**： 放行次数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("permit_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermitCount { get; set; }

        /// <summary>
        /// **参数解释**： 聚合时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackTrendRespBody {\n");
            sb.Append("  denyCount: ").Append(DenyCount).Append("\n");
            sb.Append("  permitCount: ").Append(PermitCount).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackTrendRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackTrendRespBody input)
        {
            if (input == null) return false;
            if (this.DenyCount != input.DenyCount || (this.DenyCount != null && !this.DenyCount.Equals(input.DenyCount))) return false;
            if (this.PermitCount != input.PermitCount || (this.PermitCount != null && !this.PermitCount.Equals(input.PermitCount))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;

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
                if (this.DenyCount != null) hashCode = hashCode * 59 + this.DenyCount.GetHashCode();
                if (this.PermitCount != null) hashCode = hashCode * 59 + this.PermitCount.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
