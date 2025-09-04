using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// DomainsStatuses请求体
    /// </summary>
    public class DomainsStatusesRequestBody 
    {

        /// <summary>
        /// **参数解释**： 租户id集合。 **约束限制**： 不涉及。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainsStatusesRequestBody {\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainsStatusesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainsStatusesRequestBody input)
        {
            if (input == null) return false;
            if (this.DomainIds != input.DomainIds || (this.DomainIds != null && !this.DomainIds.Equals(input.DomainIds))) return false;

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
                if (this.DomainIds != null) hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
