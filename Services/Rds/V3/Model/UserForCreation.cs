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
    /// 
    /// </summary>
    public class UserForCreation 
    {

        /// <summary>
        /// 数据库用户名称。 数据库帐号名称在1到32个字符之间，由字母、数字、中划线或下划线组成，不能包含其他特殊字符。 - 若数据库版本为MySQL5.6，帐号长度为1～16个字符。 - 若数据库版本为MySQL5.7和8.0，帐号长度为1～32个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库帐号密码。  取值范围：  非空，由大小写字母、数字和特殊符号~!@#$%^*-_&#x3D;+?,()&amp;组成，长度8~32个字符，不能和数据库帐号“name”或“name”的逆序相同。  建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 数据库用户备注。 取值范围：长度1~512个字符。目前仅支持MySQL 8.0.25及以上版本。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 授权用户登录主机IP列表 • 若IP地址为%，则表示允许所有地址访问MySQL实例。 • 若IP地址为“10.10.10.%”，则表示10.10.10.X的IP地址都可以访问该MySQL实例。 • 支持添加多个IP地址。
        /// </summary>
        [JsonProperty("hosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// 授权用户数据库权限
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseWithPrivilegeObject> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserForCreation {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  hosts: ").Append(Hosts).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserForCreation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserForCreation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.Databases == input.Databases ||
                    this.Databases != null &&
                    input.Databases != null &&
                    this.Databases.SequenceEqual(input.Databases)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.Databases != null)
                    hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
