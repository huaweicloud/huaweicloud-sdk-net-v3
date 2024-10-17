using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 跳过预检查项参数。
    /// </summary>
    public class SkipPreCheckInfo 
    {

        /// <summary>
        /// 跳过的预检查项。
        /// </summary>
        [JsonProperty("skipped_precheck_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SkippedPrecheckList { get; set; }

        /// <summary>
        /// 跳过预检查原因。
        /// </summary>
        [JsonProperty("skip_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SkipReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkipPreCheckInfo {\n");
            sb.Append("  skippedPrecheckList: ").Append(SkippedPrecheckList).Append("\n");
            sb.Append("  skipReason: ").Append(SkipReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkipPreCheckInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SkipPreCheckInfo input)
        {
            if (input == null) return false;
            if (this.SkippedPrecheckList != input.SkippedPrecheckList || (this.SkippedPrecheckList != null && input.SkippedPrecheckList != null && !this.SkippedPrecheckList.SequenceEqual(input.SkippedPrecheckList))) return false;
            if (this.SkipReason != input.SkipReason || (this.SkipReason != null && !this.SkipReason.Equals(input.SkipReason))) return false;

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
                if (this.SkippedPrecheckList != null) hashCode = hashCode * 59 + this.SkippedPrecheckList.GetHashCode();
                if (this.SkipReason != null) hashCode = hashCode * 59 + this.SkipReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
