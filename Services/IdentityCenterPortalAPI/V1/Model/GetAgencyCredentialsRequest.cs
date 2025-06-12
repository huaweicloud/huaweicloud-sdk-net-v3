using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class GetAgencyCredentialsRequest 
    {

        /// <summary>
        /// 创建令牌接口调用签发的访问令牌
        /// </summary>
        [SDKProperty("access-token", IsHeader = true)]
        [JsonProperty("access-token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 目标账户的全局唯一标识符（ID）
        /// </summary>
        [SDKProperty("target_account_id", IsQuery = true)]
        [JsonProperty("target_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetAccountId { get; set; }

        /// <summary>
        /// 委托或信任委托的统一资源名称（URN）
        /// </summary>
        [SDKProperty("agency_urn", IsQuery = true)]
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAgencyCredentialsRequest {\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  targetAccountId: ").Append(TargetAccountId).Append("\n");
            sb.Append("  agencyUrn: ").Append(AgencyUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAgencyCredentialsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetAgencyCredentialsRequest input)
        {
            if (input == null) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.TargetAccountId != input.TargetAccountId || (this.TargetAccountId != null && !this.TargetAccountId.Equals(input.TargetAccountId))) return false;
            if (this.AgencyUrn != input.AgencyUrn || (this.AgencyUrn != null && !this.AgencyUrn.Equals(input.AgencyUrn))) return false;

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
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.TargetAccountId != null) hashCode = hashCode * 59 + this.TargetAccountId.GetHashCode();
                if (this.AgencyUrn != null) hashCode = hashCode * 59 + this.AgencyUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
