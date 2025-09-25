using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyEmailAddressDto 
    {

        /// <summary>
        /// **参数解释：** 邮箱。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// **参数解释：** 验证码。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("verify_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyEmailAddressDto {\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  verifyCode: ").Append(VerifyCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyEmailAddressDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyEmailAddressDto input)
        {
            if (input == null) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.VerifyCode != input.VerifyCode || (this.VerifyCode != null && !this.VerifyCode.Equals(input.VerifyCode))) return false;

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
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.VerifyCode != null) hashCode = hashCode * 59 + this.VerifyCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
