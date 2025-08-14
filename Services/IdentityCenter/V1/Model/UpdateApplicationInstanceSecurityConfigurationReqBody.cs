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
    /// UpdateApplicationInstanceSecurityConfiguration的请求体
    /// </summary>
    public class UpdateApplicationInstanceSecurityConfigurationReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_config", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityConfigDto SecurityConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationInstanceSecurityConfigurationReqBody {\n");
            sb.Append("  securityConfig: ").Append(SecurityConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateApplicationInstanceSecurityConfigurationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateApplicationInstanceSecurityConfigurationReqBody input)
        {
            if (input == null) return false;
            if (this.SecurityConfig != input.SecurityConfig || (this.SecurityConfig != null && !this.SecurityConfig.Equals(input.SecurityConfig))) return false;

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
                if (this.SecurityConfig != null) hashCode = hashCode * 59 + this.SecurityConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
