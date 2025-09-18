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
    public class StatisticStatusV2 
    {

        /// <summary>
        /// 未解决
        /// </summary>
        [JsonProperty("unresolved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unresolved { get; set; }

        /// <summary>
        /// 已解决
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public int? Resolved { get; set; }

        /// <summary>
        /// 已忽略
        /// </summary>
        [JsonProperty("dismissed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dismissed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticStatusV2 {\n");
            sb.Append("  unresolved: ").Append(Unresolved).Append("\n");
            sb.Append("  resolved: ").Append(Resolved).Append("\n");
            sb.Append("  dismissed: ").Append(Dismissed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticStatusV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticStatusV2 input)
        {
            if (input == null) return false;
            if (this.Unresolved != input.Unresolved || (this.Unresolved != null && !this.Unresolved.Equals(input.Unresolved))) return false;
            if (this.Resolved != input.Resolved || (this.Resolved != null && !this.Resolved.Equals(input.Resolved))) return false;
            if (this.Dismissed != input.Dismissed || (this.Dismissed != null && !this.Dismissed.Equals(input.Dismissed))) return false;

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
                if (this.Unresolved != null) hashCode = hashCode * 59 + this.Unresolved.GetHashCode();
                if (this.Resolved != null) hashCode = hashCode * 59 + this.Resolved.GetHashCode();
                if (this.Dismissed != null) hashCode = hashCode * 59 + this.Dismissed.GetHashCode();
                return hashCode;
            }
        }
    }
}
