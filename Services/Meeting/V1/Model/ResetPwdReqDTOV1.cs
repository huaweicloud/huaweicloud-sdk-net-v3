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
    public class ResetPwdReqDTOV1 
    {

        /// <summary>
        /// 用户身份信息（手机号码或邮箱帐号或用户真实帐号）。 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 用户新的登录密码。 密码要求： * 长度范围要求8~32 * 至少包含大小写字母、数字 * 不能包含3个以上重复字符 * 密码不能包含与其对应的用户名（不区分大小写）以及逆序的用户名（不区分大小写） 
        /// </summary>
        [JsonProperty("newPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPwd { get; set; }

        /// <summary>
        /// * 1：临时密码，重置完密码后登录Web Portal根据配置可能需要强制修改密码 * 非1：正式密码，重置完密码后登录Web Portal不需要强制修改密码 
        /// </summary>
        [JsonProperty("passWordType", NullValueHandling = NullValueHandling.Ignore)]
        public int? PassWordType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetPwdReqDTOV1 {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  newPwd: ").Append(NewPwd).Append("\n");
            sb.Append("  passWordType: ").Append(PassWordType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetPwdReqDTOV1);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetPwdReqDTOV1 input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.NewPwd != input.NewPwd || (this.NewPwd != null && !this.NewPwd.Equals(input.NewPwd))) return false;
            if (this.PassWordType != input.PassWordType || (this.PassWordType != null && !this.PassWordType.Equals(input.PassWordType))) return false;

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
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.NewPwd != null) hashCode = hashCode * 59 + this.NewPwd.GetHashCode();
                if (this.PassWordType != null) hashCode = hashCode * 59 + this.PassWordType.GetHashCode();
                return hashCode;
            }
        }
    }
}
