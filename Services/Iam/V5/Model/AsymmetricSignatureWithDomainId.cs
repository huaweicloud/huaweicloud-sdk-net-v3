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
    /// 账号非对称签名开关信息。
    /// </summary>
    public class AsymmetricSignatureWithDomainId 
    {

        /// <summary>
        /// 账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 非对称签名开关。
        /// </summary>
        [JsonProperty("asymmetric_signature_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsymmetricSignatureSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsymmetricSignatureWithDomainId {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  asymmetricSignatureSwitch: ").Append(AsymmetricSignatureSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsymmetricSignatureWithDomainId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsymmetricSignatureWithDomainId input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.AsymmetricSignatureSwitch != input.AsymmetricSignatureSwitch || (this.AsymmetricSignatureSwitch != null && !this.AsymmetricSignatureSwitch.Equals(input.AsymmetricSignatureSwitch))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.AsymmetricSignatureSwitch != null) hashCode = hashCode * 59 + this.AsymmetricSignatureSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
