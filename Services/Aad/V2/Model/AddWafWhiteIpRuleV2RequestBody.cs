using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddWafWhiteIpRuleV2RequestBody 
    {

        /// <summary>
        /// 域名+端口组合，标准端口80/443无须加端口。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 待添加ip/ip段
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// 防护区域,0-大陆,1-海外
        /// </summary>
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverseasType { get; set; }

        /// <summary>
        /// 0-黑名单，1-白名单
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddWafWhiteIpRuleV2RequestBody {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  ips: ").Append(Ips).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddWafWhiteIpRuleV2RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddWafWhiteIpRuleV2RequestBody input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.Ips != input.Ips || (this.Ips != null && input.Ips != null && !this.Ips.SequenceEqual(input.Ips))) return false;
            if (this.OverseasType != input.OverseasType || (this.OverseasType != null && !this.OverseasType.Equals(input.OverseasType))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Ips != null) hashCode = hashCode * 59 + this.Ips.GetHashCode();
                if (this.OverseasType != null) hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
