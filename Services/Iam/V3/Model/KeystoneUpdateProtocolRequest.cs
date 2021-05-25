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
    public class KeystoneUpdateProtocolRequest 
    {

        /// <summary>
        /// 身份提供商ID。
        /// </summary>
        [SDKProperty("idp_id", IsPath = true)]
        [JsonProperty("idp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpId { get; set; }

        /// <summary>
        /// 待更新的协议ID。
        /// </summary>
        [SDKProperty("protocol_id", IsPath = true)]
        [JsonProperty("protocol_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public KeystoneUpdateProtocolRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneUpdateProtocolRequest {\n");
            sb.Append("  idpId: ").Append(IdpId).Append("\n");
            sb.Append("  protocolId: ").Append(ProtocolId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneUpdateProtocolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneUpdateProtocolRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdpId == input.IdpId ||
                    (this.IdpId != null &&
                    this.IdpId.Equals(input.IdpId))
                ) && 
                (
                    this.ProtocolId == input.ProtocolId ||
                    (this.ProtocolId != null &&
                    this.ProtocolId.Equals(input.ProtocolId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.IdpId != null)
                    hashCode = hashCode * 59 + this.IdpId.GetHashCode();
                if (this.ProtocolId != null)
                    hashCode = hashCode * 59 + this.ProtocolId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
