using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetCallerIdentityResponse : SdkResponse
    {

        /// <summary>
        /// 账号ID。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 主体URN。
        /// </summary>
        [JsonProperty("principal_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalUrn { get; set; }

        /// <summary>
        /// 主体ID。
        /// </summary>
        [JsonProperty("principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCallerIdentityResponse {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  principalUrn: ").Append(PrincipalUrn).Append("\n");
            sb.Append("  principalId: ").Append(PrincipalId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCallerIdentityResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetCallerIdentityResponse input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.PrincipalUrn != input.PrincipalUrn || (this.PrincipalUrn != null && !this.PrincipalUrn.Equals(input.PrincipalUrn))) return false;
            if (this.PrincipalId != input.PrincipalId || (this.PrincipalId != null && !this.PrincipalId.Equals(input.PrincipalId))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.PrincipalUrn != null) hashCode = hashCode * 59 + this.PrincipalUrn.GetHashCode();
                if (this.PrincipalId != null) hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                return hashCode;
            }
        }
    }
}
