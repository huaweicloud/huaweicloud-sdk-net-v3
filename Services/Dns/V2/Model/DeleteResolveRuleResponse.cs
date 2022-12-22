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
    public class DeleteResolveRuleResponse : SdkResponse
    {

        /// <summary>
        /// 查询resolver_rule的列表响应。
        /// </summary>
        [JsonProperty("resolver_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResolveRuleParam> ResolverRules { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteResolveRuleResponse {\n");
            sb.Append("  resolverRules: ").Append(ResolverRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteResolveRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteResolveRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResolverRules == input.ResolverRules ||
                    this.ResolverRules != null &&
                    input.ResolverRules != null &&
                    this.ResolverRules.SequenceEqual(input.ResolverRules)
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
                if (this.ResolverRules != null)
                    hashCode = hashCode * 59 + this.ResolverRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
