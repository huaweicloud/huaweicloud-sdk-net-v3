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
    /// 设置账号是否开启非对称签名功能。
    /// </summary>
    public class AsymmetricSignature 
    {

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
            sb.Append("class AsymmetricSignature {\n");
            sb.Append("  asymmetricSignatureSwitch: ").Append(AsymmetricSignatureSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsymmetricSignature);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsymmetricSignature input)
        {
            if (input == null) return false;
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
                if (this.AsymmetricSignatureSwitch != null) hashCode = hashCode * 59 + this.AsymmetricSignatureSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
