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
    /// 
    /// </summary>
    public class CreateResolverRuleRequestBody 
    {

        /// <summary>
        /// 规则名称。 取值范围：1-64个字符，支持数字、字母、中文、_（下划线）、-（中划线）、.（点）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 当前规则所属的终端节点ID。
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// 规则的目标IP地址。
        /// </summary>
        [JsonProperty("ipaddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpInfo> Ipaddresses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResolverRuleRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  ipaddresses: ").Append(Ipaddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResolverRuleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResolverRuleRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.Ipaddresses != input.Ipaddresses || (this.Ipaddresses != null && input.Ipaddresses != null && !this.Ipaddresses.SequenceEqual(input.Ipaddresses))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.Ipaddresses != null) hashCode = hashCode * 59 + this.Ipaddresses.GetHashCode();
                return hashCode;
            }
        }
    }
}
