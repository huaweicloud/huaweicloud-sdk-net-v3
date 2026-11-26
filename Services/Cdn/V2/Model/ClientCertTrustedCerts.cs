using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientCertTrustedCerts 
    {

        /// <summary>
        /// **参数解释：** 客户端CA证书的内容 **约束限制：** 仅支持PEM格式 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("trusted_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustedCert { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientCertTrustedCerts {\n");
            sb.Append("  trustedCert: ").Append(TrustedCert).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientCertTrustedCerts);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientCertTrustedCerts input)
        {
            if (input == null) return false;
            if (this.TrustedCert != input.TrustedCert || (this.TrustedCert != null && !this.TrustedCert.Equals(input.TrustedCert))) return false;

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
                if (this.TrustedCert != null) hashCode = hashCode * 59 + this.TrustedCert.GetHashCode();
                return hashCode;
            }
        }
    }
}
