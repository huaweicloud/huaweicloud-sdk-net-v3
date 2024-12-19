using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 聚合数据的源帐号。
    /// </summary>
    public class AccountAggregationSource 
    {

        /// <summary>
        /// 帐号列表。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAggregationSource {\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountAggregationSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountAggregationSource input)
        {
            if (input == null) return false;
            if (this.DomainIds != input.DomainIds || (this.DomainIds != null && input.DomainIds != null && !this.DomainIds.SequenceEqual(input.DomainIds))) return false;

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
