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
    /// 上网DNS管控策略
    /// </summary>
    public class PoliciesDomainControl 
    {

        /// <summary>
        /// 默认开关
        /// </summary>
        [JsonProperty("default_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultEnabled { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain_rules", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDomainControl {\n");
            sb.Append("  defaultEnabled: ").Append(DefaultEnabled).Append("\n");
            sb.Append("  domainRules: ").Append(DomainRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDomainControl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDomainControl input)
        {
            if (input == null) return false;
            if (this.DefaultEnabled != input.DefaultEnabled || (this.DefaultEnabled != null && !this.DefaultEnabled.Equals(input.DefaultEnabled))) return false;
            if (this.DomainRules != input.DomainRules || (this.DomainRules != null && !this.DomainRules.Equals(input.DomainRules))) return false;

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
                if (this.DefaultEnabled != null) hashCode = hashCode * 59 + this.DefaultEnabled.GetHashCode();
                if (this.DomainRules != null) hashCode = hashCode * 59 + this.DomainRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
