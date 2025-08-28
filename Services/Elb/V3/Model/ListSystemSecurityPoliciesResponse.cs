using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSystemSecurityPoliciesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：系统安全策略列表。
        /// </summary>
        [JsonProperty("system_security_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemSecurityPolicy> SystemSecurityPolicies { get; set; }

        /// <summary>
        /// **参数解释**：请求ID。  **取值范围**：由数字、小写字母和中划线（-）组成的字符串，自动生成。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSystemSecurityPoliciesResponse {\n");
            sb.Append("  systemSecurityPolicies: ").Append(SystemSecurityPolicies).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSystemSecurityPoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSystemSecurityPoliciesResponse input)
        {
            if (input == null) return false;
            if (this.SystemSecurityPolicies != input.SystemSecurityPolicies || (this.SystemSecurityPolicies != null && input.SystemSecurityPolicies != null && !this.SystemSecurityPolicies.SequenceEqual(input.SystemSecurityPolicies))) return false;
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
                if (this.SystemSecurityPolicies != null) hashCode = hashCode * 59 + this.SystemSecurityPolicies.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
