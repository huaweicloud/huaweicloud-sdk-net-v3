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
        /// **参数解释**： 更新节点池时，移除当前节点池密码方式登录的配置 **约束限制**： 仅更新节点池场景支持该参数，设置为true时不允许设置userPassword **取值范围**： 不涉及 **默认取值**： false
        /// </summary>
        [JsonProperty("removeUserPassword", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveUserPassword { get; set; }

        /// <summary>
        /// **参数解释**： 更新节点池时，移除当前节点池密钥对方式登录的配置 **约束限制**： 仅更新节点池场景支持该参数，设置为true时不允许设置sshKey **取值范围**： 不涉及 **默认取值**： false
        /// </summary>
        [JsonProperty("removeSSHKey", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveSSHKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Login {\n");
            sb.Append("  sshKey: ").Append(SshKey).Append("\n");
            sb.Append("  userPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  removeUserPassword: ").Append(RemoveUserPassword).Append("\n");
            sb.Append("  removeSSHKey: ").Append(RemoveSSHKey).Append("\n");
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
            if (input == null) return false;
            if (this.SshKey != input.SshKey || (this.SshKey != null && !this.SshKey.Equals(input.SshKey))) return false;
            if (this.UserPassword != input.UserPassword || (this.UserPassword != null && !this.UserPassword.Equals(input.UserPassword))) return false;
            if (this.RemoveUserPassword != input.RemoveUserPassword || (this.RemoveUserPassword != null && !this.RemoveUserPassword.Equals(input.RemoveUserPassword))) return false;
            if (this.RemoveSSHKey != input.RemoveSSHKey || (this.RemoveSSHKey != null && !this.RemoveSSHKey.Equals(input.RemoveSSHKey))) return false;

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
                if (this.SshKey != null) hashCode = hashCode * 59 + this.SshKey.GetHashCode();
                if (this.UserPassword != null) hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                if (this.RemoveUserPassword != null) hashCode = hashCode * 59 + this.RemoveUserPassword.GetHashCode();
                if (this.RemoveSSHKey != null) hashCode = hashCode * 59 + this.RemoveSSHKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
