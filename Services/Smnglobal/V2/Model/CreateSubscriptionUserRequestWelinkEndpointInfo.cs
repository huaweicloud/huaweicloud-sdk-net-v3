using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smnglobal.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSubscriptionUserRequestWelinkEndpointInfo 
    {

        /// <summary>
        /// 终端地址。必须是一个welink的群号。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// welink协议订阅用户的client_id，从Welink方获取。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// welink协议订阅用户的client_secret，从Welink方获取。
        /// </summary>
        [JsonProperty("client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionUserRequestWelinkEndpointInfo {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionUserRequestWelinkEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionUserRequestWelinkEndpointInfo input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientSecret != input.ClientSecret || (this.ClientSecret != null && !this.ClientSecret.Equals(input.ClientSecret))) return false;

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
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null) hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                return hashCode;
            }
        }
    }
}
