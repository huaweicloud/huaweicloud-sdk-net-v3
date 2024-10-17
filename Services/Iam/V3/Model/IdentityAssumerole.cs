using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IdentityAssumerole 
    {

        /// <summary>
        /// 委托名。
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 委托方的账号ID。“domain_id”与“domain_name”至少填写一个。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 委托方的账号名。“domain_id”与“domain_name”至少填写一个。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// AK/SK和securitytoken的有效期，时间单位为秒。取值范围：15min ~ 24h ，默认为15min。
        /// </summary>
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_user", NullValueHandling = NullValueHandling.Ignore)]
        public AssumeroleSessionuser SessionUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityAssumerole {\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  sessionUser: ").Append(SessionUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityAssumerole);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdentityAssumerole input)
        {
            if (input == null) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.DurationSeconds != input.DurationSeconds || (this.DurationSeconds != null && !this.DurationSeconds.Equals(input.DurationSeconds))) return false;
            if (this.SessionUser != input.SessionUser || (this.SessionUser != null && !this.SessionUser.Equals(input.SessionUser))) return false;

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
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.DurationSeconds != null) hashCode = hashCode * 59 + this.DurationSeconds.GetHashCode();
                if (this.SessionUser != null) hashCode = hashCode * 59 + this.SessionUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
