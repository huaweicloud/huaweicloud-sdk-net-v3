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
    /// 入参对象
    /// </summary>
    public class DbUserPrivilegeRequest 
    {

        /// <summary>
        /// 账号，数据库相关联的帐号
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 授权SQL类型,枚举： 1、ROLE(支持对指定用户设置以下权限) 2、RECYCLING_ROLE(支持对指定用户回收以下权限) 3、SYSTEM_ROLE(支持对指定用户授予以下系统角色) 4、RECYCLING_SYSTEM_ROLE(支持对指定用户回收以下系统角色)
        /// </summary>
        [JsonProperty("authorization_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// 支持用户设置的权限集合。 1、privilege_type为ROLE时需要使用,枚举： CREATEDB CREATEROLE LOGIN REPLICATION 2、privilege_type为RECYCLING_ROLE时需要使用,枚举： NOCREATEDB NOCREATEROLE NOLOGIN NOREPLICATION 3、privilege_type为SYSTEM_ROLE /RECYCLING_ SYSTEM_ROLE时需要使用,枚举： pg_monitor pg_signal_backend root
        /// </summary>
        [JsonProperty("privileges", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Privileges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbUserPrivilegeRequest {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  authorizationType: ").Append(AuthorizationType).Append("\n");
            sb.Append("  privileges: ").Append(Privileges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbUserPrivilegeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbUserPrivilegeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.AuthorizationType == input.AuthorizationType ||
                    (this.AuthorizationType != null &&
                    this.AuthorizationType.Equals(input.AuthorizationType))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    input.Privileges != null &&
                    this.Privileges.SequenceEqual(input.Privileges)
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AuthorizationType != null)
                    hashCode = hashCode * 59 + this.AuthorizationType.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                return hashCode;
            }
        }
    }
}
