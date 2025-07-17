using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModPwdReqDTO 
    {

        /// <summary>
        /// 帐号，必须是携带域名的帐号。 
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 用户旧的登录密码。 
        /// </summary>
        [JsonProperty("oldPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPwd { get; set; }

        /// <summary>
        /// 用户新的登录密码。 密码要求： * 长度范围要求8~32 * 至少包含两种字符类型：小写字母、大写字母、数字、特殊字符（&#x60; ~ ! @ # $ % ^ &amp; * ( ) - _ &#x3D; + \\ | [ { } ] ; : \&quot; ,&#39; &lt; . &gt; / ?） * 旧密码和新密码不能相同 * 上次修改密码后5分钟内不能更新密码 * 不能与最近使用的旧密码相同 * 不能包含3个以上重复字符 * 密码不能包含与其对应的用户名（不区分大小写）以及逆序的用户名（不区分大小写） * 新密码与旧密码之间允许的最少不相同字符数为2个 
        /// </summary>
        [JsonProperty("newPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPwd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModPwdReqDTO {\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  oldPwd: ").Append(OldPwd).Append("\n");
            sb.Append("  newPwd: ").Append(NewPwd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModPwdReqDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModPwdReqDTO input)
        {
            if (input == null) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.OldPwd != input.OldPwd || (this.OldPwd != null && !this.OldPwd.Equals(input.OldPwd))) return false;
            if (this.NewPwd != input.NewPwd || (this.NewPwd != null && !this.NewPwd.Equals(input.NewPwd))) return false;

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
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.OldPwd != null) hashCode = hashCode * 59 + this.OldPwd.GetHashCode();
                if (this.NewPwd != null) hashCode = hashCode * 59 + this.NewPwd.GetHashCode();
                return hashCode;
            }
        }
    }
}
