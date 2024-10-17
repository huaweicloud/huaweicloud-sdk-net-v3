using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 别名记录。
    /// </summary>
    public class AliasTarget 
    {

        /// <summary>
        /// 资源服务类型，支持别名记录的服务。取值：  cloudsite：云速建站 waf：Web应用防火墙
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 对应服务下的域名，由各服务提供。
        /// </summary>
        [JsonProperty("resource_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceDomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AliasTarget {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceDomainName: ").Append(ResourceDomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AliasTarget);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AliasTarget input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceDomainName != input.ResourceDomainName || (this.ResourceDomainName != null && !this.ResourceDomainName.Equals(input.ResourceDomainName))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceDomainName != null) hashCode = hashCode * 59 + this.ResourceDomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
