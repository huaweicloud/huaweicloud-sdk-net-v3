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
    public class DeleteWafWhiteIpRuleV2RequestBody 
    {

        /// <summary>
        /// 待删除规则id
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 域名+端口组合，标准端口80/443无须加端口。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 防护区域
        /// </summary>
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverseasType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteWafWhiteIpRuleV2RequestBody {\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteWafWhiteIpRuleV2RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteWafWhiteIpRuleV2RequestBody input)
        {
            if (input == null) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.OverseasType != input.OverseasType || (this.OverseasType != null && !this.OverseasType.Equals(input.OverseasType))) return false;

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
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.OverseasType != null) hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                return hashCode;
            }
        }
    }
}
