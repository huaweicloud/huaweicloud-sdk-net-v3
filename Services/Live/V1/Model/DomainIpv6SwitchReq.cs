using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainIpv6SwitchReq 
    {

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// IPV6开关配置，默认关闭，true为开启，false为关闭
        /// </summary>
        [JsonProperty("is_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIpv6 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainIpv6SwitchReq {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  isIpv6: ").Append(IsIpv6).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainIpv6SwitchReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainIpv6SwitchReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.IsIpv6 == input.IsIpv6 ||
                    (this.IsIpv6 != null &&
                    this.IsIpv6.Equals(input.IsIpv6))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.IsIpv6 != null)
                    hashCode = hashCode * 59 + this.IsIpv6.GetHashCode();
                return hashCode;
            }
        }
    }
}
