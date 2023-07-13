using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// kerberos认证需要的信息
    /// </summary>
    public class KerberosVO 
    {

        /// <summary>
        /// krb5配置文件
        /// </summary>
        [JsonProperty("krb5_conf_file", NullValueHandling = NullValueHandling.Ignore)]
        public string Krb5ConfFile { get; set; }

        /// <summary>
        /// key文件
        /// </summary>
        [JsonProperty("key_tab_file", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyTabFile { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// Kerberos用户对象
        /// </summary>
        [JsonProperty("user_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrincipal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KerberosVO {\n");
            sb.Append("  krb5ConfFile: ").Append(Krb5ConfFile).Append("\n");
            sb.Append("  keyTabFile: ").Append(KeyTabFile).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  userPrincipal: ").Append(UserPrincipal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KerberosVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KerberosVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Krb5ConfFile == input.Krb5ConfFile ||
                    (this.Krb5ConfFile != null &&
                    this.Krb5ConfFile.Equals(input.Krb5ConfFile))
                ) && 
                (
                    this.KeyTabFile == input.KeyTabFile ||
                    (this.KeyTabFile != null &&
                    this.KeyTabFile.Equals(input.KeyTabFile))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.UserPrincipal == input.UserPrincipal ||
                    (this.UserPrincipal != null &&
                    this.UserPrincipal.Equals(input.UserPrincipal))
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
                if (this.Krb5ConfFile != null)
                    hashCode = hashCode * 59 + this.Krb5ConfFile.GetHashCode();
                if (this.KeyTabFile != null)
                    hashCode = hashCode * 59 + this.KeyTabFile.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.UserPrincipal != null)
                    hashCode = hashCode * 59 + this.UserPrincipal.GetHashCode();
                return hashCode;
            }
        }
    }
}
