using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DisassociateVaultPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dissociate_policy", NullValueHandling = NullValueHandling.Ignore)]
        public VaultPolicyResp DissociatePolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateVaultPolicyResponse {\n");
            sb.Append("  dissociatePolicy: ").Append(DissociatePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateVaultPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateVaultPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DissociatePolicy == input.DissociatePolicy ||
                    (this.DissociatePolicy != null &&
                    this.DissociatePolicy.Equals(input.DissociatePolicy))
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
                if (this.DissociatePolicy != null)
                    hashCode = hashCode * 59 + this.DissociatePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
