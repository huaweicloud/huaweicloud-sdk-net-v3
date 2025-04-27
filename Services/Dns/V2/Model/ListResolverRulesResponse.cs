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
    public class ListResolverRulesResponse : SdkResponse
    {

        /// <summary>
        /// 解析器转发规则列表。
        /// </summary>
        [JsonProperty("resolver_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListResolverRuleParam> ResolverRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public PageLink Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResolverRulesResponse {\n");
            sb.Append("  resolverRules: ").Append(ResolverRules).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResolverRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResolverRulesResponse input)
        {
            if (input == null) return false;
            if (this.ResolverRules != input.ResolverRules || (this.ResolverRules != null && input.ResolverRules != null && !this.ResolverRules.SequenceEqual(input.ResolverRules))) return false;
            if (this.Links != input.Links || (this.Links != null && !this.Links.Equals(input.Links))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ResolverRules != null) hashCode = hashCode * 59 + this.ResolverRules.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
