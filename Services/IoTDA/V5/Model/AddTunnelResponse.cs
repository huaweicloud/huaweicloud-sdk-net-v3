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
    public class AddTunnelResponse : SdkResponse
    {

        /// <summary>
        /// 隧道ID
        /// </summary>
        [JsonProperty("tunnel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TunnelId { get; set; }

        /// <summary>
        /// 鉴权信息
        /// </summary>
        [JsonProperty("tunnel_access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string TunnelAccessToken { get; set; }

        /// <summary>
        /// 鉴权信息的过期时间, 单位：秒
        /// </summary>
        [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// websocket接入地址
        /// </summary>
        [JsonProperty("tunnel_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TunnelUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTunnelResponse {\n");
            sb.Append("  tunnelId: ").Append(TunnelId).Append("\n");
            sb.Append("  tunnelAccessToken: ").Append(TunnelAccessToken).Append("\n");
            sb.Append("  expiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  tunnelUri: ").Append(TunnelUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddTunnelResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddTunnelResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TunnelId == input.TunnelId ||
                    (this.TunnelId != null &&
                    this.TunnelId.Equals(input.TunnelId))
                ) && 
                (
                    this.TunnelAccessToken == input.TunnelAccessToken ||
                    (this.TunnelAccessToken != null &&
                    this.TunnelAccessToken.Equals(input.TunnelAccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.TunnelUri == input.TunnelUri ||
                    (this.TunnelUri != null &&
                    this.TunnelUri.Equals(input.TunnelUri))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TunnelId != null)
                    hashCode = hashCode * 59 + this.TunnelId.GetHashCode();
                if (this.TunnelAccessToken != null)
                    hashCode = hashCode * 59 + this.TunnelAccessToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.TunnelUri != null)
                    hashCode = hashCode * 59 + this.TunnelUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
