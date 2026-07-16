using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PreferredSchedulingTerm 
    {

        /// <summary>
        /// **参数解释**：与匹配相应 nodeSelectorTerm 相关的权重 **约束限制**：不涉及。 **取值范围**：范围为 1-100。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("preference", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSelectorTerm Preference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreferredSchedulingTerm {\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  preference: ").Append(Preference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreferredSchedulingTerm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreferredSchedulingTerm input)
        {
            if (input == null) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.Preference != input.Preference || (this.Preference != null && !this.Preference.Equals(input.Preference))) return false;

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
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Preference != null) hashCode = hashCode * 59 + this.Preference.GetHashCode();
                return hashCode;
            }
        }
    }
}
