using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateResolverRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resolver_rule", NullValueHandling = NullValueHandling.Ignore)]
        public ResolverRuleParam ResolverRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateResolverRuleResponse {\n");
            sb.Append("  resolverRule: ").Append(ResolverRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateResolverRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateResolverRuleResponse input)
        {
            if (input == null) return false;
            if (this.ResolverRule != input.ResolverRule || (this.ResolverRule != null && !this.ResolverRule.Equals(input.ResolverRule))) return false;

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
                if (this.ResolverRule != null) hashCode = hashCode * 59 + this.ResolverRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
