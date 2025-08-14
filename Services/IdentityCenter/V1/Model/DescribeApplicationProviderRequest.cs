using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DescribeApplicationProviderRequest 
    {

        /// <summary>
        /// 应用程序提供方Id
        /// </summary>
        [SDKProperty("application_provider_id", IsPath = true)]
        [JsonProperty("application_provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationProviderId { get; set; }

        /// <summary>
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeApplicationProviderRequest {\n");
            sb.Append("  applicationProviderId: ").Append(ApplicationProviderId).Append("\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeApplicationProviderRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeApplicationProviderRequest input)
        {
            if (input == null) return false;
            if (this.ApplicationProviderId != input.ApplicationProviderId || (this.ApplicationProviderId != null && !this.ApplicationProviderId.Equals(input.ApplicationProviderId))) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;

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
                if (this.ApplicationProviderId != null) hashCode = hashCode * 59 + this.ApplicationProviderId.GetHashCode();
                if (this.XSecurityToken != null) hashCode = hashCode * 59 + this.XSecurityToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
