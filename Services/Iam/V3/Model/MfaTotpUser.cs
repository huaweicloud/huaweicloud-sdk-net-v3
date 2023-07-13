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
    public class MfaTotpUser 
    {

        /// <summary>
        /// 已开启虚拟MFA方式的登录保护的IAM用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 虚拟MFA验证码，在MFA应用程序中获取动态验证码，获取方法请参见：[如何获取虚拟MFA验证码](https://support.huaweicloud.com/iam_faq/iam_01_0001.html)。
        /// </summary>
        [JsonProperty("passcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Passcode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MfaTotpUser {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  passcode: ").Append(Passcode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MfaTotpUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MfaTotpUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Passcode == input.Passcode ||
                    (this.Passcode != null &&
                    this.Passcode.Equals(input.Passcode))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Passcode != null)
                    hashCode = hashCode * 59 + this.Passcode.GetHashCode();
                return hashCode;
            }
        }
    }
}
