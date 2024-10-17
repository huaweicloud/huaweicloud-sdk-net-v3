using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KeystoneUpdatePasswordOption 
    {

        /// <summary>
        /// IAM用户的新密码。 - 系统默认密码最小长度为6位字符，在6-32位之间支持用户自定义密码长度。 - 至少包含以下四种字符中的两种： 大写字母、小写字母、数字和特殊字符。 - 不能包含手机号和邮箱。 - 必须满足用户所属账号的[密码策略](https://support.huaweicloud.com/usermanual-iam/iam_01_0607.html)要求。 - 新密码不能与当前密码相同。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// IAM用户的原密码。
        /// </summary>
        [JsonProperty("original_password", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneUpdatePasswordOption {\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  originalPassword: ").Append(OriginalPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneUpdatePasswordOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneUpdatePasswordOption input)
        {
            if (input == null) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.OriginalPassword != input.OriginalPassword || (this.OriginalPassword != null && !this.OriginalPassword.Equals(input.OriginalPassword))) return false;

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
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.OriginalPassword != null) hashCode = hashCode * 59 + this.OriginalPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
