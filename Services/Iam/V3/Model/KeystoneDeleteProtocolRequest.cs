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
    public class KeystoneDeleteProtocolRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("idp_id", IsPath = true)]
        [JsonProperty("idp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("protocol_id", IsPath = true)]
        [JsonProperty("protocol_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneDeleteProtocolRequest {\n");
            sb.Append("  idpId: ").Append(IdpId).Append("\n");
            sb.Append("  protocolId: ").Append(ProtocolId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneDeleteProtocolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneDeleteProtocolRequest input)
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
                return hashCode;
            }
        }
    }
}
