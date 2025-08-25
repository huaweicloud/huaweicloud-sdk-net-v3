using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 数据库用户信息。
    /// </summary>
    public class UserForList 
    {

        /// <summary>
        /// 数据库用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库及其权限。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseWithPrivilegeObject> Databases { get; set; }

        /// <summary>
        /// 授权用户登录主机IP列表 • 若IP地址为%，则表示允许所有地址访问MySQL实例。 • 若IP地址为“10.10.10.%”，则表示10.10.10.X的IP地址都可以访问该MySQL实例。 • 支持添加多个IP地址。
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// 数据库用户备注
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserForList {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  hosts: ").Append(Hosts).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserForList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserForList input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;
            if (this.Hosts != input.Hosts || (this.Hosts != null && input.Hosts != null && !this.Hosts.SequenceEqual(input.Hosts))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;

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
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.Hosts != null) hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }
    }
}
