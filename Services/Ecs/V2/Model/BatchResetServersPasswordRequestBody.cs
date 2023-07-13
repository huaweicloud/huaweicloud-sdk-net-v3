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
    /// This is a auto create Body Object
    /// </summary>
    public class BatchResetServersPasswordRequestBody 
    {

        /// <summary>
        /// 新密码。  当dry_run字段为true时，该字段为非必填字段，否则为必填字段。  新密码的校验规则：  - 允许输入的字符包括：!@%-_&#x3D;+[]:./? - 禁止输入的字符包括：汉字及【】：；“”‘’、，。《》？￥…（）—— ·！~&#x60;#&amp;^,{}*();\&quot;&#39;&lt;&gt;|\\ $ - 复杂度上必须包含大写字母（A-Z）、小写字母（a-z）、数字（0-9）、以及允许的特殊字符中的3种以上搭配 - 不能包含用户名 \&quot;Administrator\&quot; 和“root”及逆序字符 - 不能包含用户名 \&quot;Administrator\&quot; 中连续3个字符
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        /// <summary>
        /// 是否只预检此次请求。  - true：发送检查请求，不会重置密码。检查项包括是否填写了必需参数、请求格式、业务限制。如果检查不通过，则返回对应错误。如果检查通过，则返回响应结果。 - false：发送正常请求，通过检查后并且进行重置密码请求。  默认值：false
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 待批量重置密码的弹性云服务器ID信息。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerId> Servers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResetServersPasswordRequestBody {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResetServersPasswordRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResetServersPasswordRequestBody input)
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
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
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
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                return hashCode;
            }
        }
    }
}
