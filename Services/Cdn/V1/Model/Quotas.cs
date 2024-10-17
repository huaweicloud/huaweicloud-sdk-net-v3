using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Quotas 
    {

        /// <summary>
        /// 配额上限。
        /// </summary>
        [JsonProperty("quota_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaLimit { get; set; }

        /// <summary>
        /// 配额类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 已使用配额数。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 域名所属用户的domain_id。
        /// </summary>
        [JsonProperty("user_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quotas {\n");
            sb.Append("  quotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  userDomainId: ").Append(UserDomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quotas);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Quotas input)
        {
            if (input == null) return false;
            if (this.QuotaLimit != input.QuotaLimit || (this.QuotaLimit != null && !this.QuotaLimit.Equals(input.QuotaLimit))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.UserDomainId != input.UserDomainId || (this.UserDomainId != null && !this.UserDomainId.Equals(input.UserDomainId))) return false;

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
                if (this.QuotaLimit != null) hashCode = hashCode * 59 + this.QuotaLimit.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.UserDomainId != null) hashCode = hashCode * 59 + this.UserDomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
