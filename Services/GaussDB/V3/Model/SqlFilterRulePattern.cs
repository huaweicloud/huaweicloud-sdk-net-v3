using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// SQL限流规则和最大并发数
    /// </summary>
    public class SqlFilterRulePattern 
    {

        /// <summary>
        /// SQL限流规则。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 最大并发数。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlFilterRulePattern {\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlFilterRulePattern);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlFilterRulePattern input)
        {
            if (input == null) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.MaxConcurrency != input.MaxConcurrency || (this.MaxConcurrency != null && !this.MaxConcurrency.Equals(input.MaxConcurrency))) return false;

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
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.MaxConcurrency != null) hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                return hashCode;
            }
        }
    }
}
