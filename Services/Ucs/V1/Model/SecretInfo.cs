using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SecretInfo 
    {

        /// <summary>
        /// 使用的认证模式
        /// </summary>
        [JsonProperty("authMode", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthMode { get; set; }

        /// <summary>
        /// 存储了实际认证凭据的Secret
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public Object Secret { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretInfo {\n");
            sb.Append("  authMode: ").Append(AuthMode).Append("\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecretInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecretInfo input)
        {
            if (input == null) return false;
            if (this.AuthMode != input.AuthMode || (this.AuthMode != null && !this.AuthMode.Equals(input.AuthMode))) return false;
            if (this.Secret != input.Secret || (this.Secret != null && !this.Secret.Equals(input.Secret))) return false;

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
                if (this.AuthMode != null) hashCode = hashCode * 59 + this.AuthMode.GetHashCode();
                if (this.Secret != null) hashCode = hashCode * 59 + this.Secret.GetHashCode();
                return hashCode;
            }
        }
    }
}
