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
    /// MFA设备。
    /// </summary>
    public class VirtualMfaDevice 
    {

        /// <summary>
        /// MFA设备序列号。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 密钥信息，用于第三方生成图片验证码。
        /// </summary>
        [JsonProperty("base32_string_seed", NullValueHandling = NullValueHandling.Ignore)]
        public string Base32StringSeed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualMfaDevice {\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  base32StringSeed: ").Append(Base32StringSeed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VirtualMfaDevice);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VirtualMfaDevice input)
        {
            if (input == null) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.Base32StringSeed != input.Base32StringSeed || (this.Base32StringSeed != null && !this.Base32StringSeed.Equals(input.Base32StringSeed))) return false;

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
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.Base32StringSeed != null) hashCode = hashCode * 59 + this.Base32StringSeed.GetHashCode();
                return hashCode;
            }
        }
    }
}
