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
    /// Request Object
    /// </summary>
    public class AssociateResolverRuleRouterRequest 
    {

        /// <summary>
        /// 转发规则ID。
        /// </summary>
        [SDKProperty("resolverrule_id", IsPath = true)]
        [JsonProperty("resolverrule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResolverruleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateOrDisassociateRouterWithRuleRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateResolverRuleRouterRequest {\n");
            sb.Append("  resolverruleId: ").Append(ResolverruleId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateResolverRuleRouterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateResolverRuleRouterRequest input)
        {
            if (input == null) return false;
            if (this.ResolverruleId != input.ResolverruleId || (this.ResolverruleId != null && !this.ResolverruleId.Equals(input.ResolverruleId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ResolverruleId != null) hashCode = hashCode * 59 + this.ResolverruleId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
