using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 云服务器元数据
    /// </summary>
    public class VmMetaData 
    {

        /// <summary>
        /// 如果需要使用密码方式登录云服务器，可使用adminPass字段指定云服务器管理员帐户初始登录密码。其中，Linux管理员帐户为root，Windows管理员帐户为Administrator。  密码复杂度要求： - 长度为8-26位。 - 密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。 - 密码不能包含用户名或用户名的逆序。 - Windows系统密码不能包含用户名或用户名的逆序，不能包含用户名中超过两个连续字符的部分。
        /// </summary>
        [JsonProperty("admin_pass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmMetaData {\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VmMetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VmMetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminPass == input.AdminPass ||
                    (this.AdminPass != null &&
                    this.AdminPass.Equals(input.AdminPass))
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
                if (this.AdminPass != null)
                    hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                return hashCode;
            }
        }
    }
}
