using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PluginInstallBasicParam 
    {

        /// <summary>
        /// 指定安装的ICAgent版本。
        /// </summary>
        [JsonProperty("install_version", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallVersion { get; set; }

        /// <summary>
        /// IAM账号AK，选填。.
        /// </summary>
        [JsonProperty("domain_ak", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAk { get; set; }

        /// <summary>
        /// IAM账号SK，选填。
        /// </summary>
        [JsonProperty("domain_sk", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainSk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginInstallBasicParam {\n");
            sb.Append("  installVersion: ").Append(InstallVersion).Append("\n");
            sb.Append("  domainAk: ").Append(DomainAk).Append("\n");
            sb.Append("  domainSk: ").Append(DomainSk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginInstallBasicParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginInstallBasicParam input)
        {
            if (input == null) return false;
            if (this.InstallVersion != input.InstallVersion || (this.InstallVersion != null && !this.InstallVersion.Equals(input.InstallVersion))) return false;
            if (this.DomainAk != input.DomainAk || (this.DomainAk != null && !this.DomainAk.Equals(input.DomainAk))) return false;
            if (this.DomainSk != input.DomainSk || (this.DomainSk != null && !this.DomainSk.Equals(input.DomainSk))) return false;

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
                if (this.InstallVersion != null) hashCode = hashCode * 59 + this.InstallVersion.GetHashCode();
                if (this.DomainAk != null) hashCode = hashCode * 59 + this.DomainAk.GetHashCode();
                if (this.DomainSk != null) hashCode = hashCode * 59 + this.DomainSk.GetHashCode();
                return hashCode;
            }
        }
    }
}
