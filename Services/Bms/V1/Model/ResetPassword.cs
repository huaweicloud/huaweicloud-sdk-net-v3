using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// reset-password信息详情
    /// </summary>
    public class ResetPassword 
    {

        /// <summary>
        /// 裸金属服务器新密码。该接口不做密码安全性校验，设置的密码复杂度请遵循密码规则。密码规则：密码长度范围为8到26位。密码至少包含以下4种字符中的3种：大写字母小写字母数字特殊字符Windows：!@$%-_&#x3D;+[]:./?Linux：!@%^-_&#x3D;+[]{}:,./?密码不能包含用户名或用户名的逆序。Windows系统的裸金属服务器，不能包含用户名中超过两个连续字符的部分。
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetPassword {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetPassword);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetPassword input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
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
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
