using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// **参数解释**： 密级字段信息。仅在涉密环境（SM）下存在此字段，非涉密环境下无此字段。
    /// </summary>
    public class SecurityLevelResult 
    {

        /// <summary>
        /// **参数解释**： 密级字段ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 密级字段名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("display_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// **参数解释**： 用户自定义的密级字段的值。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释**： 密级编码。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 密级排序值，越大级别越高。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityLevelResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  displayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityLevelResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecurityLevelResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DisplayValue != input.DisplayValue || (this.DisplayValue != null && !this.DisplayValue.Equals(input.DisplayValue))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayValue != null) hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
