using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateWebSocketTokenResponse : SdkResponse
    {

        /// <summary>
        /// WebSocket建链Token(有效期1分钟，且一次有效)。
        /// </summary>
        [JsonProperty("webSocketToken", NullValueHandling = NullValueHandling.Ignore)]
        public string WebSocketToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebSocketTokenResponse {\n");
            sb.Append("  webSocketToken: ").Append(WebSocketToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWebSocketTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWebSocketTokenResponse input)
        {
            if (input == null) return false;
            if (this.WebSocketToken != input.WebSocketToken || (this.WebSocketToken != null && !this.WebSocketToken.Equals(input.WebSocketToken))) return false;

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
                if (this.WebSocketToken != null) hashCode = hashCode * 59 + this.WebSocketToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
