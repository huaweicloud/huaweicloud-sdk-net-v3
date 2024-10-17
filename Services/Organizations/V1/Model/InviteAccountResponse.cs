using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class InviteAccountResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("handshake", NullValueHandling = NullValueHandling.Ignore)]
        public HandshakeDto Handshake { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteAccountResponse {\n");
            sb.Append("  handshake: ").Append(Handshake).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InviteAccountResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InviteAccountResponse input)
        {
            if (input == null) return false;
            if (this.Handshake != input.Handshake || (this.Handshake != null && !this.Handshake.Equals(input.Handshake))) return false;

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
                if (this.Handshake != null) hashCode = hashCode * 59 + this.Handshake.GetHashCode();
                return hashCode;
            }
        }
    }
}
