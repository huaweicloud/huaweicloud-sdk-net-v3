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
    public class SlideVerifyCodeSendDTO 
    {

        /// <summary>
        /// 用户身份信息（手机号码或邮箱帐号或用户真实帐号）。 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 登录客户端类型。 * 0：Web客户端类型 * 5：cloudlink pc * 6：cloudlink mobile 
        /// </summary>
        [JsonProperty("clientType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientType { get; set; }

        /// <summary>
        /// 校验类型。默认值：0。 * 0：登录 * 1：忘记密码 
        /// </summary>
        [JsonProperty("checkType", NullValueHandling = NullValueHandling.Ignore)]
        public int? CheckType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlideVerifyCodeSendDTO {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  checkType: ").Append(CheckType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SlideVerifyCodeSendDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SlideVerifyCodeSendDTO input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.CheckType != input.CheckType || (this.CheckType != null && !this.CheckType.Equals(input.CheckType))) return false;

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
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.CheckType != null) hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                return hashCode;
            }
        }
    }
}
