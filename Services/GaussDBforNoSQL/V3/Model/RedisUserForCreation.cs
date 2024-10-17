using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RedisUserForCreation 
    {

        /// <summary>
        /// 账号名称。  小于36个字符，以字母开头，仅包含数字、字母、中划线、下划线。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// - 密码长度为8~32位。  - 密码需包含大写字母、小写字母、数字和特殊字符中的至少三种，支持的特殊字符为!@#$%^&amp;*()_+-&#x3D; 。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 账号授权的数据库名称列表，至少指定一个数据库。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// 账号权限。  - 取值\&quot;ReadOnly\&quot;：账号为只读权限； - 取值\&quot;ReadWrite\&quot;：账号为读写权限。
        /// </summary>
        [JsonProperty("privilege", NullValueHandling = NullValueHandling.Ignore)]
        public string Privilege { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedisUserForCreation {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  privilege: ").Append(Privilege).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedisUserForCreation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedisUserForCreation input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;
            if (this.Privilege != input.Privilege || (this.Privilege != null && !this.Privilege.Equals(input.Privilege))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.Privilege != null) hashCode = hashCode * 59 + this.Privilege.GetHashCode();
                return hashCode;
            }
        }
    }
}
