using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StatisticSeverityV2 
    {

        /// <summary>
        /// 致命问题数
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public int? Critical { get; set; }

        /// <summary>
        /// 严重问题数
        /// </summary>
        [JsonProperty("major", NullValueHandling = NullValueHandling.Ignore)]
        public int? Major { get; set; }

        /// <summary>
        /// 一般问题数
        /// </summary>
        [JsonProperty("minor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Minor { get; set; }

        /// <summary>
        /// 提示问题数
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public int? Suggestion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticSeverityV2 {\n");
            sb.Append("  critical: ").Append(Critical).Append("\n");
            sb.Append("  major: ").Append(Major).Append("\n");
            sb.Append("  minor: ").Append(Minor).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticSeverityV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticSeverityV2 input)
        {
            if (input == null) return false;
            if (this.Critical != input.Critical || (this.Critical != null && !this.Critical.Equals(input.Critical))) return false;
            if (this.Major != input.Major || (this.Major != null && !this.Major.Equals(input.Major))) return false;
            if (this.Minor != input.Minor || (this.Minor != null && !this.Minor.Equals(input.Minor))) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;

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
                if (this.Major != null) hashCode = hashCode * 59 + this.Major.GetHashCode();
                if (this.Minor != null) hashCode = hashCode * 59 + this.Minor.GetHashCode();
                if (this.Suggestion != null) hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                return hashCode;
            }
        }
    }
}
