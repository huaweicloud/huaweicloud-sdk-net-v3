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
    /// 域信息，加域实例单转主备时必填，非加域实例不需要填写
    /// </summary>
    public class ADDomainInfo 
    {

        /// <summary>
        /// 域管理员账号名
        /// </summary>
        [JsonProperty("domain_admin_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAdminAccountName { get; set; }

        /// <summary>
        /// 域管理员密码
        /// </summary>
        [JsonProperty("domain_admin_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAdminPwd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ADDomainInfo {\n");
            sb.Append("  domainAdminAccountName: ").Append(DomainAdminAccountName).Append("\n");
            sb.Append("  domainAdminPwd: ").Append(DomainAdminPwd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ADDomainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ADDomainInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainAdminAccountName == input.DomainAdminAccountName ||
                    (this.DomainAdminAccountName != null &&
                    this.DomainAdminAccountName.Equals(input.DomainAdminAccountName))
                ) && 
                (
                    this.DomainAdminPwd == input.DomainAdminPwd ||
                    (this.DomainAdminPwd != null &&
                    this.DomainAdminPwd.Equals(input.DomainAdminPwd))
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
                if (this.DomainAdminAccountName != null)
                    hashCode = hashCode * 59 + this.DomainAdminAccountName.GetHashCode();
                if (this.DomainAdminPwd != null)
                    hashCode = hashCode * 59 + this.DomainAdminPwd.GetHashCode();
                return hashCode;
            }
        }
    }
}
