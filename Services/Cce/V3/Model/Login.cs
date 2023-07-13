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
    /// 
    /// </summary>
    public class Login 
    {

        /// <summary>
        /// 选择密钥对方式登录时的密钥对名称。
        /// </summary>
        [JsonProperty("sshKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SshKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("userPassword", NullValueHandling = NullValueHandling.Ignore)]
        public UserPassword UserPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Login {\n");
            sb.Append("  sshKey: ").Append(SshKey).Append("\n");
            sb.Append("  userPassword: ").Append(UserPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Login);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Login input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SshKey == input.SshKey ||
                    (this.SshKey != null &&
                    this.SshKey.Equals(input.SshKey))
                ) && 
                (
                    this.UserPassword == input.UserPassword ||
                    (this.UserPassword != null &&
                    this.UserPassword.Equals(input.UserPassword))
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
                if (this.SshKey != null)
                    hashCode = hashCode * 59 + this.SshKey.GetHashCode();
                if (this.UserPassword != null)
                    hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
