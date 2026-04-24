using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 查询订阅用户信息
    /// </summary>
    public class SubscribeUserInfo 
    {

        /// <summary>
        /// 用户id。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 桌面用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户手机号。
        /// </summary>
        [JsonProperty("user_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPhone { get; set; }

        /// <summary>
        /// ai 功能是否启用。 * true： 启用 * false： 不启用
        /// </summary>
        [JsonProperty("ai_func", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiFunc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeUserInfo {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userPhone: ").Append(UserPhone).Append("\n");
            sb.Append("  aiFunc: ").Append(AiFunc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscribeUserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscribeUserInfo input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserPhone != input.UserPhone || (this.UserPhone != null && !this.UserPhone.Equals(input.UserPhone))) return false;
            if (this.AiFunc != input.AiFunc || (this.AiFunc != null && !this.AiFunc.Equals(input.AiFunc))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserPhone != null) hashCode = hashCode * 59 + this.UserPhone.GetHashCode();
                if (this.AiFunc != null) hashCode = hashCode * 59 + this.AiFunc.GetHashCode();
                return hashCode;
            }
        }
    }
}
