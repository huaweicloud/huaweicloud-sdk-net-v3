using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResetBridgeSecretResponse : SdkResponse
    {

        /// <summary>
        /// 网桥ID
        /// </summary>
        [JsonProperty("bridge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeId { get; set; }

        /// <summary>
        /// 网桥密钥。
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetBridgeSecretResponse {\n");
            sb.Append("  bridgeId: ").Append(BridgeId).Append("\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetBridgeSecretResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetBridgeSecretResponse input)
        {
            if (input == null) return false;
            if (this.BridgeId != input.BridgeId || (this.BridgeId != null && !this.BridgeId.Equals(input.BridgeId))) return false;
            if (this.Secret != input.Secret || (this.Secret != null && !this.Secret.Equals(input.Secret))) return false;

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
                if (this.BridgeId != null) hashCode = hashCode * 59 + this.BridgeId.GetHashCode();
                if (this.Secret != null) hashCode = hashCode * 59 + this.Secret.GetHashCode();
                return hashCode;
            }
        }
    }
}
