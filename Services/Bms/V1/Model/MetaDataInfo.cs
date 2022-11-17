using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// metadata字段数据结构说明
    /// </summary>
    public class MetaDataInfo 
    {

        /// <summary>
        /// 用户ID（登录管理控制台，进入我的凭证，即可看到“用户ID”）。
        /// </summary>
        [JsonProperty("op_svc_userid", NullValueHandling = NullValueHandling.Ignore)]
        public string OpSvcUserid { get; set; }

        /// <summary>
        /// 以Windows镜像创建的裸金属服务器Administrator用户的密码，示例：cloud.1234。密码复杂度要求：长度为8-26位。密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。密码不能包含用户名或用户名的逆序，不能包含用户名中超过两个连续字符的部分。
        /// </summary>
        [JsonProperty("admin_pass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// 否自带许可，取值“true”或“false”。
        /// </summary>
        [JsonProperty("BYOL", NullValueHandling = NullValueHandling.Ignore)]
        public string Byol { get; set; }

        /// <summary>
        /// 委托的名称。委托是由租户管理员在统一身份认证服务（Identity and Access Management，IAM）上创建的，可以作为其他租户访问此裸金属服务器的临时凭证。 说明:委托获取、更新请参考如下步骤：使用IAM服务提供的查询委托列表，获取有效可用的委托名称。使用更新裸金属服务器元数据接口，更新metadata中agency_name字段为新的委托名称。
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaDataInfo {\n");
            sb.Append("  opSvcUserid: ").Append(OpSvcUserid).Append("\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  byol: ").Append(Byol).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaDataInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaDataInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpSvcUserid == input.OpSvcUserid ||
                    (this.OpSvcUserid != null &&
                    this.OpSvcUserid.Equals(input.OpSvcUserid))
                ) && 
                (
                    this.AdminPass == input.AdminPass ||
                    (this.AdminPass != null &&
                    this.AdminPass.Equals(input.AdminPass))
                ) && 
                (
                    this.Byol == input.Byol ||
                    (this.Byol != null &&
                    this.Byol.Equals(input.Byol))
                ) && 
                (
                    this.AgencyName == input.AgencyName ||
                    (this.AgencyName != null &&
                    this.AgencyName.Equals(input.AgencyName))
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
                if (this.OpSvcUserid != null)
                    hashCode = hashCode * 59 + this.OpSvcUserid.GetHashCode();
                if (this.AdminPass != null)
                    hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                if (this.Byol != null)
                    hashCode = hashCode * 59 + this.Byol.GetHashCode();
                if (this.AgencyName != null)
                    hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
