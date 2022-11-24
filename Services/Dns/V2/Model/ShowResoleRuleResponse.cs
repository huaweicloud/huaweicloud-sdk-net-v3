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
    public class ShowResoleRuleResponse : SdkResponse
    {

        /// <summary>
        /// 查询单个resolver_rule响应。
        /// </summary>
        [JsonProperty("resolver_rule", NullValueHandling = NullValueHandling.Ignore)]
        public Object ResolverRule { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResoleRuleResponse {\n");
            sb.Append("  resolverRule: ").Append(ResolverRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResoleRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResoleRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolverRule == input.ResolverRule ||
                    (this.ResolverRule != null &&
                    this.ResolverRule.Equals(input.ResolverRule))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResolverRule != null)
                    hashCode = hashCode * 59 + this.ResolverRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
