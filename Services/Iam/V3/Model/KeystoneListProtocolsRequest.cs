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
    public class KeystoneListProtocolsRequest 
    {

        /// <summary>
        /// 身份提供商ID。
        /// </summary>
        [SDKProperty("idp_id", IsPath = true)]
        [JsonProperty("idp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneListProtocolsRequest {\n");
            sb.Append("  idpId: ").Append(IdpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneListProtocolsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneListProtocolsRequest input)
        {
            if (input == null) return false;
            if (this.IdpId != input.IdpId || (this.IdpId != null && !this.IdpId.Equals(input.IdpId))) return false;

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
                return hashCode;
            }
        }
    }
}
