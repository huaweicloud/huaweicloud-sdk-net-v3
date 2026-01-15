using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 校验域控请求体。
    /// </summary>
    public class ValidateDcRequestBody 
    {

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 域控制器IP地址。
        /// </summary>
        [JsonProperty("dc_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DcIp { get; set; }

        /// <summary>
        /// 域控制器名称。
        /// </summary>
        [JsonProperty("dc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DcName { get; set; }

        /// <summary>
        /// 域管理员账号。
        /// </summary>
        [JsonProperty("domain_admin_account", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAdminAccount { get; set; }

        /// <summary>
        /// 域管理员账号密码。
        /// </summary>
        [JsonProperty("domain_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainPassword { get; set; }

        /// <summary>
        /// 是否开启LDAPS。
        /// </summary>
        [JsonProperty("is_ldaps_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLdapsEnable { get; set; }

        /// <summary>
        /// LDAPS用的密钥证书。
        /// </summary>
        [JsonProperty("ldaps_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string LdapsCertificate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateDcRequestBody {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  dcIp: ").Append(DcIp).Append("\n");
            sb.Append("  dcName: ").Append(DcName).Append("\n");
            sb.Append("  domainAdminAccount: ").Append(DomainAdminAccount).Append("\n");
            sb.Append("  domainPassword: ").Append(DomainPassword).Append("\n");
            sb.Append("  isLdapsEnable: ").Append(IsLdapsEnable).Append("\n");
            sb.Append("  ldapsCertificate: ").Append(LdapsCertificate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateDcRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateDcRequestBody input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.DcIp != input.DcIp || (this.DcIp != null && !this.DcIp.Equals(input.DcIp))) return false;
            if (this.DcName != input.DcName || (this.DcName != null && !this.DcName.Equals(input.DcName))) return false;
            if (this.DomainAdminAccount != input.DomainAdminAccount || (this.DomainAdminAccount != null && !this.DomainAdminAccount.Equals(input.DomainAdminAccount))) return false;
            if (this.DomainPassword != input.DomainPassword || (this.DomainPassword != null && !this.DomainPassword.Equals(input.DomainPassword))) return false;
            if (this.IsLdapsEnable != input.IsLdapsEnable || (this.IsLdapsEnable != null && !this.IsLdapsEnable.Equals(input.IsLdapsEnable))) return false;
            if (this.LdapsCertificate != input.LdapsCertificate || (this.LdapsCertificate != null && !this.LdapsCertificate.Equals(input.LdapsCertificate))) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.DcIp != null) hashCode = hashCode * 59 + this.DcIp.GetHashCode();
                if (this.DcName != null) hashCode = hashCode * 59 + this.DcName.GetHashCode();
                if (this.DomainAdminAccount != null) hashCode = hashCode * 59 + this.DomainAdminAccount.GetHashCode();
                if (this.DomainPassword != null) hashCode = hashCode * 59 + this.DomainPassword.GetHashCode();
                if (this.IsLdapsEnable != null) hashCode = hashCode * 59 + this.IsLdapsEnable.GetHashCode();
                if (this.LdapsCertificate != null) hashCode = hashCode * 59 + this.LdapsCertificate.GetHashCode();
                return hashCode;
            }
        }
    }
}
