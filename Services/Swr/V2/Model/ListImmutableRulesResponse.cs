using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListImmutableRulesResponse : SdkResponse
    {

        /// <summary>
        /// 策略列表
        /// </summary>
        [JsonProperty("immutable_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImmutableRule> ImmutableRules { get; set; }

        /// <summary>
        /// 策略总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListImmutableRulesResponse {\n");
            sb.Append("  immutableRules: ").Append(ImmutableRules).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListImmutableRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListImmutableRulesResponse input)
        {
            if (input == null) return false;
            if (this.ImmutableRules != input.ImmutableRules || (this.ImmutableRules != null && input.ImmutableRules != null && !this.ImmutableRules.SequenceEqual(input.ImmutableRules))) return false;
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
                if (this.ImmutableRules != null) hashCode = hashCode * 59 + this.ImmutableRules.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
