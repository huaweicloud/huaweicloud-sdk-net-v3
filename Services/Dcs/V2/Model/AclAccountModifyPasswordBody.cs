using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AclAccountModifyPasswordBody 
    {

        /// <summary>
        /// 旧密码
        /// </summary>
        [JsonProperty("old_password", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPassword { get; set; }

        /// <summary>
        /// 新密码 - 输入长度为8到64位的字符串。 - 不能包含正序逆序用户名。 - 必须包含如下四种字符中的三种组合（不允许包含冒号）：   - 小写字母   - 大写字母   - 数字   - 特殊字符包括（&#x60;~!@#$%^&amp;*()-_&#x3D;+\\|{},&lt;.&gt;/?） 
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AclAccountModifyPasswordBody {\n");
            sb.Append("  oldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AclAccountModifyPasswordBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AclAccountModifyPasswordBody input)
        {
            if (input == null) return false;
            if (this.OldPassword != input.OldPassword || (this.OldPassword != null && !this.OldPassword.Equals(input.OldPassword))) return false;
            if (this.NewPassword != input.NewPassword || (this.NewPassword != null && !this.NewPassword.Equals(input.NewPassword))) return false;

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
                if (this.OldPassword != null) hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null) hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
