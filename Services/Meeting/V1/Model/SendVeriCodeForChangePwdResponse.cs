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
    /// Response Object
    /// </summary>
    public class SendVeriCodeForChangePwdResponse : SdkResponse
    {

        /// <summary>
        /// 过期时间，单位：秒。
        /// </summary>
        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public int? Expire { get; set; }

        /// <summary>
        /// 如果通过手机发送验证码，则该字段携带该用户绑定的手机号（手机号经过处理，屏蔽中间几位，如+8618****12345）。
        /// </summary>
        [JsonProperty("bindPhone", NullValueHandling = NullValueHandling.Ignore)]
        public string BindPhone { get; set; }

        /// <summary>
        /// 如果通过邮箱发送验证码，则该字段携带用户绑定的邮箱帐号（邮箱帐号经过处理，屏蔽中间几位，如tes****ount@huawei.com）。
        /// </summary>
        [JsonProperty("bindEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string BindEmail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendVeriCodeForChangePwdResponse {\n");
            sb.Append("  expire: ").Append(Expire).Append("\n");
            sb.Append("  bindPhone: ").Append(BindPhone).Append("\n");
            sb.Append("  bindEmail: ").Append(BindEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendVeriCodeForChangePwdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendVeriCodeForChangePwdResponse input)
        {
            if (input == null) return false;
            if (this.Expire != input.Expire || (this.Expire != null && !this.Expire.Equals(input.Expire))) return false;
            if (this.BindPhone != input.BindPhone || (this.BindPhone != null && !this.BindPhone.Equals(input.BindPhone))) return false;
            if (this.BindEmail != input.BindEmail || (this.BindEmail != null && !this.BindEmail.Equals(input.BindEmail))) return false;

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
                if (this.Expire != null) hashCode = hashCode * 59 + this.Expire.GetHashCode();
                if (this.BindPhone != null) hashCode = hashCode * 59 + this.BindPhone.GetHashCode();
                if (this.BindEmail != null) hashCode = hashCode * 59 + this.BindEmail.GetHashCode();
                return hashCode;
            }
        }
    }
}
