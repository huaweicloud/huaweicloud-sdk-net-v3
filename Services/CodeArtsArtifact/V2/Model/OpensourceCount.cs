using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpensourceCount 
    {

        /// <summary>
        /// **参数解释**: 危急漏洞数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public int? Critical { get; set; }

        /// <summary>
        /// **参数解释**: 高危漏洞数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
        public int? High { get; set; }

        /// <summary>
        /// **参数解释**: 中危漏洞数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public int? Medium { get; set; }

        /// <summary>
        /// **参数解释**: 低危漏洞数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)]
        public int? Low { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpensourceCount {\n");
            sb.Append("  critical: ").Append(Critical).Append("\n");
            sb.Append("  high: ").Append(High).Append("\n");
            sb.Append("  medium: ").Append(Medium).Append("\n");
            sb.Append("  low: ").Append(Low).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpensourceCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpensourceCount input)
        {
            if (input == null) return false;
            if (this.Critical != input.Critical || (this.Critical != null && !this.Critical.Equals(input.Critical))) return false;
            if (this.High != input.High || (this.High != null && !this.High.Equals(input.High))) return false;
            if (this.Medium != input.Medium || (this.Medium != null && !this.Medium.Equals(input.Medium))) return false;
            if (this.Low != input.Low || (this.Low != null && !this.Low.Equals(input.Low))) return false;

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
                if (this.Critical != null) hashCode = hashCode * 59 + this.Critical.GetHashCode();
                if (this.High != null) hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Medium != null) hashCode = hashCode * 59 + this.Medium.GetHashCode();
                if (this.Low != null) hashCode = hashCode * 59 + this.Low.GetHashCode();
                return hashCode;
            }
        }
    }
}
