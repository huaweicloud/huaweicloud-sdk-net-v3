using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResetServerPasswordOption 
    {

        /// <summary>
        /// 弹性云服务器新密码。  该接口默认不做密码安全性校验；如需校验，请指定字段“is_check_password”为true。  新密码的校验规则： - 密码长度范围为8到26位。 - 允许输入的字符包括：!@%-_&#x3D;+[]:./? - 禁止输入的字符包括：汉字及【】：；“”‘’、，。《》？￥…（）—— ·！~&#x60;#&amp;^,{}*();\&quot;&#39;&lt;&gt;|\\ $ - 复杂度上必须包含大写字母（A-Z）、小写字母（a-z）、数字（0-9）、以及允许的特殊字符中的3种以上搭配 - 不能包含用户名 \&quot;Administrator\&quot; 和“root”及逆序字符 - 不能包含用户名 \&quot;Administrator\&quot; 中连续3个字符
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        /// <summary>
        /// 是否检查密码的复杂度。
        /// </summary>
        [JsonProperty("is_check_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCheckPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetServerPasswordOption {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  isCheckPassword: ").Append(IsCheckPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetServerPasswordOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetServerPasswordOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.IsCheckPassword == input.IsCheckPassword ||
                    (this.IsCheckPassword != null &&
                    this.IsCheckPassword.Equals(input.IsCheckPassword))
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
                if (this.IsCheckPassword != null)
                    hashCode = hashCode * 59 + this.IsCheckPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
