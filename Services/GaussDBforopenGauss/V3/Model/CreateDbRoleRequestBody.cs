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
    public class CreateDbRoleRequestBody 
    {

        /// <summary>
        /// 数据库角色名称，不可与已有角色名称重复。 数据库角色名称在1到63个字符之间，由字母、数字、或下划线组成，不能包含其他特殊字符，不能以“pg”和数字开头，不能和系统用户/角色名称相同。 系统用户/角色包括“rdsAdmin”,“ rdsMetric”, “rdsBackup”, “rdsRepl”, “root”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库角色密码。 取值范围：非空，密码长度在8到32个字符之间，至少包含大写字母、小写字母、数字、特殊字符~!@#%^*-_&#x3D;+?,三种字符的组合，不能和数据库账号“name”或“name”的逆序相同。 建议您输入高强度密码，以提高安全性，防止出现密码被暴力破解等安全风险。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDbRoleRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDbRoleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDbRoleRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;

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
                return hashCode;
            }
        }
    }
}
