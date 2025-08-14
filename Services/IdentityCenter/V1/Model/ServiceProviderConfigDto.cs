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
    /// 服务提供商
    /// </summary>
    public class ServiceProviderConfigDto 
    {

        /// <summary>
        /// SAML受众
        /// </summary>
        [JsonProperty("audience", NullValueHandling = NullValueHandling.Ignore)]
        public string Audience { get; set; }

        /// <summary>
        /// 是否需要签名
        /// </summary>
        [JsonProperty("require_request_signature", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireRequestSignature { get; set; }

        /// <summary>
        /// SAML响应接收方
        /// </summary>
        [JsonProperty("consumers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConsumersDto> Consumers { get; set; }

        /// <summary>
        /// 应用程序启动Url
        /// </summary>
        [JsonProperty("start_url", NullValueHandling = NullValueHandling.Ignore)]
        public string StartUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceProviderConfigDto {\n");
            sb.Append("  audience: ").Append(Audience).Append("\n");
            sb.Append("  requireRequestSignature: ").Append(RequireRequestSignature).Append("\n");
            sb.Append("  consumers: ").Append(Consumers).Append("\n");
            sb.Append("  startUrl: ").Append(StartUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceProviderConfigDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceProviderConfigDto input)
        {
            if (input == null) return false;
            if (this.Audience != input.Audience || (this.Audience != null && !this.Audience.Equals(input.Audience))) return false;
            if (this.RequireRequestSignature != input.RequireRequestSignature || (this.RequireRequestSignature != null && !this.RequireRequestSignature.Equals(input.RequireRequestSignature))) return false;
            if (this.Consumers != input.Consumers || (this.Consumers != null && input.Consumers != null && !this.Consumers.SequenceEqual(input.Consumers))) return false;
            if (this.StartUrl != input.StartUrl || (this.StartUrl != null && !this.StartUrl.Equals(input.StartUrl))) return false;

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
                if (this.Audience != null) hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.RequireRequestSignature != null) hashCode = hashCode * 59 + this.RequireRequestSignature.GetHashCode();
                if (this.Consumers != null) hashCode = hashCode * 59 + this.Consumers.GetHashCode();
                if (this.StartUrl != null) hashCode = hashCode * 59 + this.StartUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
