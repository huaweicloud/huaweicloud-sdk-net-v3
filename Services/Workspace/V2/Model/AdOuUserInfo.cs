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
    /// 
    /// </summary>
    public class AdOuUserInfo 
    {

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 过期时间 -1代表永不过期
        /// </summary>
        [JsonProperty("expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 是否存在于用户列表
        /// </summary>
        [JsonProperty("has_existed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasExisted { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdOuUserInfo {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  expiredTime: ").Append(ExpiredTime).Append("\n");
            sb.Append("  hasExisted: ").Append(HasExisted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdOuUserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdOuUserInfo input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.ExpiredTime != input.ExpiredTime || (this.ExpiredTime != null && !this.ExpiredTime.Equals(input.ExpiredTime))) return false;
            if (this.HasExisted != input.HasExisted || (this.HasExisted != null && !this.HasExisted.Equals(input.HasExisted))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ExpiredTime != null) hashCode = hashCode * 59 + this.ExpiredTime.GetHashCode();
                if (this.HasExisted != null) hashCode = hashCode * 59 + this.HasExisted.GetHashCode();
                return hashCode;
            }
        }
    }
}
