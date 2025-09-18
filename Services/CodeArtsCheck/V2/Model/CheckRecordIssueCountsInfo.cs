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
    public class CheckRecordIssueCountsInfo 
    {

        /// <summary>
        /// 致命问题
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public int? Critical { get; set; }

        /// <summary>
        /// 严重问题
        /// </summary>
        [JsonProperty("serious", NullValueHandling = NullValueHandling.Ignore)]
        public int? Serious { get; set; }

        /// <summary>
        /// 常规问题
        /// </summary>
        [JsonProperty("normal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Normal { get; set; }

        /// <summary>
        /// 提示问题
        /// </summary>
        [JsonProperty("prompt", NullValueHandling = NullValueHandling.Ignore)]
        public int? Prompt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckRecordIssueCountsInfo {\n");
            sb.Append("  critical: ").Append(Critical).Append("\n");
            sb.Append("  serious: ").Append(Serious).Append("\n");
            sb.Append("  normal: ").Append(Normal).Append("\n");
            sb.Append("  prompt: ").Append(Prompt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckRecordIssueCountsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckRecordIssueCountsInfo input)
        {
            if (input == null) return false;
            if (this.Critical != input.Critical || (this.Critical != null && !this.Critical.Equals(input.Critical))) return false;
            if (this.Serious != input.Serious || (this.Serious != null && !this.Serious.Equals(input.Serious))) return false;
            if (this.Normal != input.Normal || (this.Normal != null && !this.Normal.Equals(input.Normal))) return false;
            if (this.Prompt != input.Prompt || (this.Prompt != null && !this.Prompt.Equals(input.Prompt))) return false;

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
                if (this.Serious != null) hashCode = hashCode * 59 + this.Serious.GetHashCode();
                if (this.Normal != null) hashCode = hashCode * 59 + this.Normal.GetHashCode();
                if (this.Prompt != null) hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                return hashCode;
            }
        }
    }
}
