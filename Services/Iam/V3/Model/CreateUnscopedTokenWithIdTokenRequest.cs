using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateUnscopedTokenWithIdTokenRequest 
    {

        /// <summary>
        /// 身份提供商id。
        /// </summary>
        [SDKProperty("idp_id", IsPath = true)]
        [JsonProperty("idp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpId { get; set; }

        /// <summary>
        /// 协议id。
        /// </summary>
        [SDKProperty("protocol_id", IsPath = true)]
        [JsonProperty("protocol_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolId { get; set; }

        /// <summary>
        /// OpenID Connect身份提供商的ID Token，格式为Bearer {ID Token}。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUnscopedTokenWithIdTokenRequest {\n");
            sb.Append("  idpId: ").Append(IdpId).Append("\n");
            sb.Append("  protocolId: ").Append(ProtocolId).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUnscopedTokenWithIdTokenRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUnscopedTokenWithIdTokenRequest input)
        {
            if (input == null) return false;
            if (this.IdpId != input.IdpId || (this.IdpId != null && !this.IdpId.Equals(input.IdpId))) return false;
            if (this.ProtocolId != input.ProtocolId || (this.ProtocolId != null && !this.ProtocolId.Equals(input.ProtocolId))) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;

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
                if (this.IdpId != null) hashCode = hashCode * 59 + this.IdpId.GetHashCode();
                if (this.ProtocolId != null) hashCode = hashCode * 59 + this.ProtocolId.GetHashCode();
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                return hashCode;
            }
        }
    }
}
