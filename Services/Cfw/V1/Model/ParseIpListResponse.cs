using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 查询域名解析的ip列表 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
    /// </summary>
    public class ParseIpListResponse 
    {

        /// <summary>
        /// **参数解释**： 超过限制的ip列表 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("excess_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcessIp { get; set; }

        /// <summary>
        /// **参数解释**： 成功解析的ip列表 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("parsed_success_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ParsedSuccessIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseIpListResponse {\n");
            sb.Append("  excessIp: ").Append(ExcessIp).Append("\n");
            sb.Append("  parsedSuccessIp: ").Append(ParsedSuccessIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParseIpListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParseIpListResponse input)
        {
            if (input == null) return false;
            if (this.ExcessIp != input.ExcessIp || (this.ExcessIp != null && input.ExcessIp != null && !this.ExcessIp.SequenceEqual(input.ExcessIp))) return false;
            if (this.ParsedSuccessIp != input.ParsedSuccessIp || (this.ParsedSuccessIp != null && input.ParsedSuccessIp != null && !this.ParsedSuccessIp.SequenceEqual(input.ParsedSuccessIp))) return false;

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
                if (this.ExcessIp != null) hashCode = hashCode * 59 + this.ExcessIp.GetHashCode();
                if (this.ParsedSuccessIp != null) hashCode = hashCode * 59 + this.ParsedSuccessIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
