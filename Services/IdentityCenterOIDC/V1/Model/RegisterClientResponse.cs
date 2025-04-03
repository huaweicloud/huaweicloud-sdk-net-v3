using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class RegisterClientResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("client_info", NullValueHandling = NullValueHandling.Ignore)]
        public ClientInfoDto ClientInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterClientResponse {\n");
            sb.Append("  clientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterClientResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterClientResponse input)
        {
            if (input == null) return false;
            if (this.ClientInfo != input.ClientInfo || (this.ClientInfo != null && !this.ClientInfo.Equals(input.ClientInfo))) return false;

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
                if (this.ClientInfo != null) hashCode = hashCode * 59 + this.ClientInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
