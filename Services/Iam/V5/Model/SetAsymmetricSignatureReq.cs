using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Set asymmetric signature API request body.
    /// </summary>
    public class SetAsymmetricSignatureReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asymmetric_signature", NullValueHandling = NullValueHandling.Ignore)]
        public AsymmetricSignature AsymmetricSignature { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAsymmetricSignatureReq {\n");
            sb.Append("  asymmetricSignature: ").Append(AsymmetricSignature).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAsymmetricSignatureReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAsymmetricSignatureReq input)
        {
            if (input == null) return false;
            if (this.AsymmetricSignature != input.AsymmetricSignature || (this.AsymmetricSignature != null && !this.AsymmetricSignature.Equals(input.AsymmetricSignature))) return false;

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
                if (this.AsymmetricSignature != null) hashCode = hashCode * 59 + this.AsymmetricSignature.GetHashCode();
                return hashCode;
            }
        }
    }
}
