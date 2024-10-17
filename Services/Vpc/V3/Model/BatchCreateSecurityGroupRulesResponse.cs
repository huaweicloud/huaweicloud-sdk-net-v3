using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchCreateSecurityGroupRulesResponse : SdkResponse
    {

        /// <summary>
        /// 批量创建安全组规则的响应体
        /// </summary>
        [JsonProperty("security_group_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupRule> SecurityGroupRules { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateSecurityGroupRulesResponse {\n");
            sb.Append("  securityGroupRules: ").Append(SecurityGroupRules).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateSecurityGroupRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateSecurityGroupRulesResponse input)
        {
            if (input == null) return false;
            if (this.SecurityGroupRules != input.SecurityGroupRules || (this.SecurityGroupRules != null && input.SecurityGroupRules != null && !this.SecurityGroupRules.SequenceEqual(input.SecurityGroupRules))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.SecurityGroupRules != null) hashCode = hashCode * 59 + this.SecurityGroupRules.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
