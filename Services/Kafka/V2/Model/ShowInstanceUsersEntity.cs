using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowInstanceUsersEntity 
    {

        /// <summary>
        /// 用户名称。  由英文字符开头，只能由英文字母、数字、中划线、下划线组成，长度为4~64的字符。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户描述。
        /// </summary>
        [JsonProperty("user_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDesc { get; set; }

        /// <summary>
        /// 用户角色。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 是否为默认应用。
        /// </summary>
        [JsonProperty("default_app", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultApp { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceUsersEntity {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userDesc: ").Append(UserDesc).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  defaultApp: ").Append(DefaultApp).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceUsersEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceUsersEntity input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserDesc != input.UserDesc || (this.UserDesc != null && !this.UserDesc.Equals(input.UserDesc))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.DefaultApp != input.DefaultApp || (this.DefaultApp != null && !this.DefaultApp.Equals(input.DefaultApp))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;

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
                if (this.UserDesc != null) hashCode = hashCode * 59 + this.UserDesc.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.DefaultApp != null) hashCode = hashCode * 59 + this.DefaultApp.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
