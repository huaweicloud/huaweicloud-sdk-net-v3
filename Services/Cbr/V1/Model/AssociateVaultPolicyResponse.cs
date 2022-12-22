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
    public class AssociateVaultPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("associate_policy", NullValueHandling = NullValueHandling.Ignore)]
        public VaultPolicyResp AssociatePolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateVaultPolicyResponse {\n");
            sb.Append("  associatePolicy: ").Append(AssociatePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateVaultPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateVaultPolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssociatePolicy == input.AssociatePolicy ||
                    (this.AssociatePolicy != null &&
                    this.AssociatePolicy.Equals(input.AssociatePolicy))
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
                if (this.AssociatePolicy != null)
                    hashCode = hashCode * 59 + this.AssociatePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
