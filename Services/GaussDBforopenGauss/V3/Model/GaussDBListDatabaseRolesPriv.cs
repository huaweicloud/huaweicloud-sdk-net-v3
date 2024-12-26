using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GaussDBListDatabaseRolesPriv 
    {

        /// <summary>
        /// 用户/角色是否具有管理员权限。
        /// </summary>
        [JsonProperty("rolsuper", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolsuper { get; set; }

        /// <summary>
        /// 用户/角色是否自动继承其所属角色的权限。
        /// </summary>
        [JsonProperty("rolinherit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolinherit { get; set; }

        /// <summary>
        /// 用户/角色是否支持创建其他子用户。
        /// </summary>
        [JsonProperty("rolcreaterole", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolcreaterole { get; set; }

        /// <summary>
        /// 用户/角色是否可以创建数据库。
        /// </summary>
        [JsonProperty("rolcreatedb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolcreatedb { get; set; }

        /// <summary>
        /// 用户/角色是否可以登录数据库。
        /// </summary>
        [JsonProperty("rolcanlogin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolcanlogin { get; set; }

        /// <summary>
        /// 用户/角色连接实例的最大并发连接数。-1表示没有限制。
        /// </summary>
        [JsonProperty("rolconnlimit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rolconnlimit { get; set; }

        /// <summary>
        /// 用户/角色是否属于复制角色。
        /// </summary>
        [JsonProperty("rolreplication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolreplication { get; set; }

        /// <summary>
        /// 用户/角色是否绕过每个行级安全策略。
        /// </summary>
        [JsonProperty("rolbypassrls", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rolbypassrls { get; set; }

        /// <summary>
        /// 用户/角色密码过期时间。
        /// </summary>
        [JsonProperty("rolpassworddeadline", NullValueHandling = NullValueHandling.Ignore)]
        public string Rolpassworddeadline { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBListDatabaseRolesPriv {\n");
            sb.Append("  rolsuper: ").Append(Rolsuper).Append("\n");
            sb.Append("  rolinherit: ").Append(Rolinherit).Append("\n");
            sb.Append("  rolcreaterole: ").Append(Rolcreaterole).Append("\n");
            sb.Append("  rolcreatedb: ").Append(Rolcreatedb).Append("\n");
            sb.Append("  rolcanlogin: ").Append(Rolcanlogin).Append("\n");
            sb.Append("  rolconnlimit: ").Append(Rolconnlimit).Append("\n");
            sb.Append("  rolreplication: ").Append(Rolreplication).Append("\n");
            sb.Append("  rolbypassrls: ").Append(Rolbypassrls).Append("\n");
            sb.Append("  rolpassworddeadline: ").Append(Rolpassworddeadline).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBListDatabaseRolesPriv);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBListDatabaseRolesPriv input)
        {
            if (input == null) return false;
            if (this.Rolsuper != input.Rolsuper || (this.Rolsuper != null && !this.Rolsuper.Equals(input.Rolsuper))) return false;
            if (this.Rolinherit != input.Rolinherit || (this.Rolinherit != null && !this.Rolinherit.Equals(input.Rolinherit))) return false;
            if (this.Rolcreaterole != input.Rolcreaterole || (this.Rolcreaterole != null && !this.Rolcreaterole.Equals(input.Rolcreaterole))) return false;
            if (this.Rolcreatedb != input.Rolcreatedb || (this.Rolcreatedb != null && !this.Rolcreatedb.Equals(input.Rolcreatedb))) return false;
            if (this.Rolcanlogin != input.Rolcanlogin || (this.Rolcanlogin != null && !this.Rolcanlogin.Equals(input.Rolcanlogin))) return false;
            if (this.Rolconnlimit != input.Rolconnlimit || (this.Rolconnlimit != null && !this.Rolconnlimit.Equals(input.Rolconnlimit))) return false;
            if (this.Rolreplication != input.Rolreplication || (this.Rolreplication != null && !this.Rolreplication.Equals(input.Rolreplication))) return false;
            if (this.Rolbypassrls != input.Rolbypassrls || (this.Rolbypassrls != null && !this.Rolbypassrls.Equals(input.Rolbypassrls))) return false;
            if (this.Rolpassworddeadline != input.Rolpassworddeadline || (this.Rolpassworddeadline != null && !this.Rolpassworddeadline.Equals(input.Rolpassworddeadline))) return false;

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
                if (this.Rolsuper != null) hashCode = hashCode * 59 + this.Rolsuper.GetHashCode();
                if (this.Rolinherit != null) hashCode = hashCode * 59 + this.Rolinherit.GetHashCode();
                if (this.Rolcreaterole != null) hashCode = hashCode * 59 + this.Rolcreaterole.GetHashCode();
                if (this.Rolcreatedb != null) hashCode = hashCode * 59 + this.Rolcreatedb.GetHashCode();
                if (this.Rolcanlogin != null) hashCode = hashCode * 59 + this.Rolcanlogin.GetHashCode();
                if (this.Rolconnlimit != null) hashCode = hashCode * 59 + this.Rolconnlimit.GetHashCode();
                if (this.Rolreplication != null) hashCode = hashCode * 59 + this.Rolreplication.GetHashCode();
                if (this.Rolbypassrls != null) hashCode = hashCode * 59 + this.Rolbypassrls.GetHashCode();
                if (this.Rolpassworddeadline != null) hashCode = hashCode * 59 + this.Rolpassworddeadline.GetHashCode();
                return hashCode;
            }
        }
    }
}
