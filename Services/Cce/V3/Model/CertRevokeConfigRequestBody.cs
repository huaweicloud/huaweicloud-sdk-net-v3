using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CertRevokeConfigRequestBody 
    {

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 委托用户ID
        /// </summary>
        [JsonProperty("agencyId", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertRevokeConfigRequestBody {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  agencyId: ").Append(AgencyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertRevokeConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertRevokeConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.AgencyId != input.AgencyId || (this.AgencyId != null && !this.AgencyId.Equals(input.AgencyId))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AgencyId != null) hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
