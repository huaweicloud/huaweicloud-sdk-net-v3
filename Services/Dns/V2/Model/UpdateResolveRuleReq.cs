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
    public class UpdateResolveRuleReq 
    {

        /// <summary>
        /// 规则名称。 取值范围：1-64个字符，支持数字、字母、中文、_（下划线）、-（中划线）、.（点）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipaddresses", NullValueHandling = NullValueHandling.Ignore)]
        public IpInfo Ipaddresses { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateResolveRuleReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ipaddresses: ").Append(Ipaddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateResolveRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateResolveRuleReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ipaddresses == input.Ipaddresses ||
                    (this.Ipaddresses != null &&
                    this.Ipaddresses.Equals(input.Ipaddresses))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ipaddresses != null)
                    hashCode = hashCode * 59 + this.Ipaddresses.GetHashCode();
                return hashCode;
            }
        }
    }
}
