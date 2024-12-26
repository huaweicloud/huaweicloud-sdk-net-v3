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
    /// 用户的权限属性。
    /// </summary>
    public class GaussDBforOpenGaussRoleAttributes 
    {

        /// <summary>
        /// 数据库角色名称。 不能使用系统用户或角色，且名称必须存在。 系统用户/角色包括“rdsAdmin”,“rdsMetric”, “rdsBackup”, “rdsRepl”, “root”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// SCHEMA名称。 不能和模板库以及系统内schema重名，且schema名称必须存在。 模板库包括postgres， template0 ，template1, 系统内schema包括public，information_schema。
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// 数据库角色权限。 - true：只读。 - false：可读可写。
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// 数据库用户/角色名称。 该字段的含义是将此用户/角色的权限授予给name字段指定的角色，通过readonly字段判断是否授予只读权限。 不能和系统用户/角色名称相同，且用户/角色名称必须存在，系统用户/角色包括“rdsAdmin”,“ rdsMetric”, “rdsBackup”, “rdsRepl”, “root”。
        /// </summary>
        [JsonProperty("default_privilege_grantee", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPrivilegeGrantee { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenGaussRoleAttributes {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  defaultPrivilegeGrantee: ").Append(DefaultPrivilegeGrantee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenGaussRoleAttributes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenGaussRoleAttributes input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;
            if (this.Readonly != input.Readonly || (this.Readonly != null && !this.Readonly.Equals(input.Readonly))) return false;
            if (this.DefaultPrivilegeGrantee != input.DefaultPrivilegeGrantee || (this.DefaultPrivilegeGrantee != null && !this.DefaultPrivilegeGrantee.Equals(input.DefaultPrivilegeGrantee))) return false;

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
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Readonly != null) hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                if (this.DefaultPrivilegeGrantee != null) hashCode = hashCode * 59 + this.DefaultPrivilegeGrantee.GetHashCode();
                return hashCode;
            }
        }
    }
}
