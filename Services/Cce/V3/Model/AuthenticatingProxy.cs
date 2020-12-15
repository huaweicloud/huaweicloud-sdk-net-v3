using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// authenticatingProxy模式相关配置。认证模式为authenticating_proxy时必选
    /// </summary>
    public class AuthenticatingProxy 
    {

        /// <summary>
        /// authenticating_proxy模式配置的x509格式CA证书(base64编码)。 最大长度：1M
        /// </summary>
        [JsonProperty("ca", NullValueHandling = NullValueHandling.Ignore)]
        public string Ca { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatingProxy {\n");
            sb.Append("  ca: ").Append(Ca).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthenticatingProxy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthenticatingProxy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ca == input.Ca ||
                    (this.Ca != null &&
                    this.Ca.Equals(input.Ca))
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
                if (this.Ca != null)
                    hashCode = hashCode * 59 + this.Ca.GetHashCode();
                return hashCode;
            }
        }
    }
}
