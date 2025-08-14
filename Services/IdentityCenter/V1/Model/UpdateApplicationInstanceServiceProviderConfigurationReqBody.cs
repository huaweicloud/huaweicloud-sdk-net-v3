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
    /// UpdateApplicationInstanceServiceProviderConfiguration的请求体
    /// </summary>
    public class UpdateApplicationInstanceServiceProviderConfigurationReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_provider_config", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceProviderConfigDto ServiceProviderConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationInstanceServiceProviderConfigurationReqBody {\n");
            sb.Append("  serviceProviderConfig: ").Append(ServiceProviderConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateApplicationInstanceServiceProviderConfigurationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateApplicationInstanceServiceProviderConfigurationReqBody input)
        {
            if (input == null) return false;
            if (this.ServiceProviderConfig != input.ServiceProviderConfig || (this.ServiceProviderConfig != null && !this.ServiceProviderConfig.Equals(input.ServiceProviderConfig))) return false;

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
                if (this.ServiceProviderConfig != null) hashCode = hashCode * 59 + this.ServiceProviderConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
