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
    public class AttackEvent 
    {

        /// <summary>
        /// **参数解释**： 变化数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("changed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Changed { get; set; }

        /// <summary>
        /// **参数解释**： 阻断数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("deny", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deny { get; set; }

        /// <summary>
        /// **参数解释**： 总数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttackEvent {\n");
            sb.Append("  changed: ").Append(Changed).Append("\n");
            sb.Append("  deny: ").Append(Deny).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttackEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttackEvent input)
        {
            if (input == null) return false;
            if (this.Changed != input.Changed || (this.Changed != null && !this.Changed.Equals(input.Changed))) return false;
            if (this.Deny != input.Deny || (this.Deny != null && !this.Deny.Equals(input.Deny))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Changed != null) hashCode = hashCode * 59 + this.Changed.GetHashCode();
                if (this.Deny != null) hashCode = hashCode * 59 + this.Deny.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
